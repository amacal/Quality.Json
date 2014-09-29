namespace Quality.Json.Performance.Domain
{
    public interface IProcedure : IDescriptive
    {
        IResultData Process<T>(IResource<T> resource, ISubject subject, ITimes times)
            where T : class;
    }
}