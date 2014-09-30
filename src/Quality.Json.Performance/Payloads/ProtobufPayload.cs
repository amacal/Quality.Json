using Quality.Json.Performance.Domain;
using System;
using System.IO;

namespace Quality.Json.Performance.Payloads
{
    public class ProtobufPayload : IPayload
    {
        private readonly MemoryStream stream;

        public ProtobufPayload(MemoryStream stream)
        {
            this.stream = stream;
        }

        public T Deserialize<T>(IJsonImplementation implementation) 
            where T : class
        {
            throw new NotSupportedException();
        }
        
        public T Deserialize<T>(IProtobufImplementation implementation) 
            where T : class
        {
            this.stream.Seek(0, SeekOrigin.Begin);
            return implementation.Deserialize<T>(this.stream);
        }

        public void SaveAs(string path)
        {
            this.stream.Seek(0, SeekOrigin.Begin);
            this.stream.WriteTo(File.OpenWrite(path));
        }
    }
}
