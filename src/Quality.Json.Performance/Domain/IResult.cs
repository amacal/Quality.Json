namespace Quality.Json.Performance.Domain
{
    public interface IResult
    {
        IDescriptive Case { get; }

        IDescriptive Procedure { get; }

        IDescriptive Subject { get; }

        IResultData Data { get; }
    }
}
