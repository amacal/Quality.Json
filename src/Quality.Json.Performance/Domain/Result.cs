namespace Quality.Json.Performance.Domain
{
    internal class Result : IResult
    {
        private readonly ICase @case;
        private readonly IProcedure procedure;
        private readonly ISubject subject;
        private readonly IResultData data;

        public Result(ICase @case, IProcedure procedure, ISubject subject, IResultData data)
        {
            this.@case = @case;
            this.procedure = procedure;
            this.subject = subject;
            this.data = data;
        }

        public IDescriptive Case
        {
            get { return this.@case; }
        }

        public IDescriptive Procedure
        {
            get { return this.procedure; }
        }

        public IDescriptive Subject
        {
            get { return this.subject; }
        }

        public IResultData Data
        {
            get { return this.data; }
        }
    }
}
