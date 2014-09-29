using System;

namespace Quality.Json.Performance.Domain
{
    public interface ISubject : ISubjectInfo
    {
        IPayload Create<T>(IResource<T> resource)
            where T : class;

        IPayload Serialize<T>(T instance)
            where T : class;

        T Deserialize<T>(IPayload payload)
            where T : class;
    }
}