namespace Quality.Json.Performance.Domain
{
    public interface IExecutionGroup
    {
        IResult[] Execute(ITimes times, IParallelism parallelism);
    }
}
