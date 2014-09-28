using System;

namespace Quality.Json.Performance.Domain
{
    internal class Instance : IInstance
    {
        private readonly ICase @case;
        private readonly ISubject subject;
        private readonly IProcedure procedure;

        public Instance(ICase @case, ISubject subject, IProcedure procedure)
        {
            this.@case = @case;
            this.subject = subject;
            this.procedure = procedure;
        }

        public ICaseInfo Case
        {
            get { return this.@case; }
        }

        public ISubjectInfo Subject
        {
            get { return this.subject; }
        }

        public IResult Execute(ITimes times)
        {
            AppDomain domain = AppDomain.CreateDomain(String.Join("-", this.@case.Name, this.subject.Name, this.procedure.Name));

            try
            {
                Proxy proxy = (Proxy)domain.CreateInstanceFromAndUnwrap(this.GetType().Assembly.CodeBase, typeof(Proxy).FullName);
                IResultData data = proxy.Execute(this.@case, this.procedure, this.subject, times);
                IResult result = new Result(this.@case, this.procedure, this.subject, data);

                return result;
            }
            finally
            {
                AppDomain.Unload(domain);
            }
        }

        [Serializable]
        public class Proxy : MarshalByRefObject
        {
            public IResultData Execute(ICase @case, IProcedure procedure, ISubject subject, ITimes times)
            {
                return @case.Execute(procedure, subject, times);
            }
        }
    }
}