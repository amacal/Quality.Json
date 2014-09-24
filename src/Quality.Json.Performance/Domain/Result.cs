namespace Quality.Json.Performance.Domain
{
    internal class Result : IResult
    {
        private readonly ICaseInfo @case;
        private readonly IProcedure procedure;
        private readonly ISubjectInfo subject;
        private readonly IResultData data;

        public Result(ICaseInfo @case, IProcedure procedure, ISubjectInfo subject, IResultData data)
        {
            this.@case = @case;
            this.procedure = procedure;
            this.subject = subject;
            this.data = data;
        }

        public ICaseInfo Case
        {
            get { return this.@case; }
        }

        public IProcedure Procedure
        {
            get { return this.procedure; }
        }

        public ISubjectInfo Subject
        {
            get { return this.subject; }
        }

        public IResultData Data
        {
            get { return this.data; }
        }
    }
}