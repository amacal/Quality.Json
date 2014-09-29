namespace Quality.Json.Performance.Domain
{
    public interface IJsonImplementation
    {
        T Deserialize<T>(string data)
            where T : class;
    }
}
