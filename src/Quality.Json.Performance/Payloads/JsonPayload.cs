using Quality.Json.Performance.Domain;

namespace Quality.Json.Performance.Payloads
{
    public class JsonPayload : IPayload
    {
        private readonly string data;

        public JsonPayload(string data)
        {
            this.data = data;
        }

        public T Deserialize<T>(IJsonImplementation implementation) 
            where T : class
        {
            return implementation.Deserialize<T>(this.data);
        }
    }
}
