using System;

namespace Quality.Json.Performance.Domain
{
    internal class TestInstance : ITestInstance
    {
        public ICase Case { get; set; }
        public ISubject Subject { get; set; }
        public IProcedure Procedure { get; set; }

        public IResult Execute(ITimes times)
        {
            AppDomain domain = AppDomain.CreateDomain(String.Join("-", this.Case.Name, this.Subject.Name, this.Procedure.Name));

            try
            {
                Proxy proxy = (Proxy)domain.CreateInstanceFromAndUnwrap(this.GetType().Assembly.CodeBase, typeof(Proxy).FullName);
                IResultData data = proxy.Execute(this.Case, this.Procedure, this.Subject, times);
                IResult result = new Result(this.Case, this.Procedure, this.Subject, data);

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