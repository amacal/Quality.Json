namespace Quality.Json.Performance.Domain
{
    public interface ITestSuit
    {
        IReport Execute(ITimes times, IParallelism parallelism);
    }
}