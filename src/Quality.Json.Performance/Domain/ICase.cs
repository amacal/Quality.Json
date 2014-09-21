namespace Quality.Json.Performance.Domain
{
    public interface ICase : ICaseInfo
    {
        IResultData Execute(IProcedure procedure, ISubject subject);
    }
}
