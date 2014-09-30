using System.IO;

namespace Quality.Json.Performance.Domain
{
    public interface IProtobufImplementation
    {
        T Deserialize<T>(MemoryStream stream)
            where T : class;
    }
}
