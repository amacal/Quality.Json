using ComputerBeacon.Json;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Payloads;
using Quality.Json.Performance.Requirements;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class JsonToolkitSubject : ISubject, IJsonImplementation
    {
        public string Name
        {
            get { return "JsonToolkit-" + FileVersionInfo.GetVersionInfo(typeof(Serializer).Assembly.Location).FileVersion; }
        }

        public string Description
        {
            get { return null; }
        }

        public bool CanHandle(IRequirement requirement)
        {
            return requirement is CaseInsensitiveRequirement == false;
        }

        public IPayload Create<T>(IResource<T> resource)
            where T : class
        {
            return new JsonPayload(resource.GetText());
        }

        public IPayload Serialize<T>(T instance)
            where T : class
        {
            return new JsonPayload(Serializer.Serialize(instance));
        }

        public T Deserialize<T>(IPayload payload)
            where T : class
        {
            return payload.Deserialize<T>(this);
        }

        public T Deserialize<T>(string data)
            where T : class
        {
            return Serializer.Deserialize<T>(data);
        }
    }
}