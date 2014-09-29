namespace Quality.Json.Performance.Domain
{
    public interface IPayload
    {
        T Deserialize<T>(IJsonImplementation implementation)
            where T : class;
    }
}
