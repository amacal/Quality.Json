namespace Quality.Json.Performance.Domain
{
    public interface ITestSuitBuilder
    {
        void AddCase(ICase @case);

        void AddSubject(ISubject subject);

        void AddProcedure(IProcedure procedure);

        ITestSuit Build();
    }
}