namespace Quality.Json.Performance.Domain
{
    public interface IPayload
    {
        void SaveAs(string path);

        T Deserialize<T>(IJsonImplementation implementation)
            where T : class;

        T Deserialize<T>(IProtobufImplementation implementation)
            where T : class;
    }
}
