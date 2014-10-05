using Quality.Json.Performance.Domain;
using System;
using System.IO;

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

        public T Deserialize<T>(IProtobufImplementation implementation)
            where T : class
        {
            throw new NotSupportedException();
        }

        public void SaveAs(string path)
        {
            File.WriteAllText(path, this.data);
        }
    }
}
