namespace Quality.Json.Performance.Domain
{
    public interface IParallelism
    {
        IResult[] Execute(IInstance[] instances, ITimes times);
    }
}
