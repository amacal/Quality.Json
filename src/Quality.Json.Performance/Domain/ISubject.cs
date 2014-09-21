using System;

namespace Quality.Json.Performance.Domain
{
    public interface ISubject : ISubjectInfo
    {
        string Serialize<T>(T instance) 
            where T : class, new();

        T Deserialize<T>(string data)
            where T : class, new();
    }
}
