using Jil;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Payloads;
using Quality.Json.Performance.Requirements;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class JilSubject : ISubject, IJsonImplementation
    {
        public string Name
        {
            get { return "Jil-" + FileVersionInfo.GetVersionInfo(typeof(JSON).Assembly.Location).FileVersion; }
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
            return new JsonPayload(JSON.Serialize(instance));
        }

        public T Deserialize<T>(IPayload payload)
            where T : class
        {
            return payload.Deserialize<T>(this);
        }

        public T Deserialize<T>(string data)
            where T : class
        {
            return JSON.Deserialize<T>(data);
        }
    }
}