using System.IO;

namespace Quality.Json.Performance.Domain
{
    public interface IResource<T>
        where T : class
    {
        string GetText();

        MemoryStream GetData();

        T GetInstance();

        ITimes Multiply(ITimes source);
    }
}