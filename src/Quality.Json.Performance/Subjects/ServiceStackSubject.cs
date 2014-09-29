using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Payloads;
using ServiceStack;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class ServiceStackSubject : ISubject, IJsonImplementation
    {
        public string Name
        {
            get { return "ServiceStack.Text-" + FileVersionInfo.GetVersionInfo(typeof(StringExtensions).Assembly.Location).FileVersion; }
        }

        public string Description
        {
            get { return null; }
        }

        public bool CanHandle(IRequirement requirement)
        {
            return true;
        }

        public IPayload Create<T>(IResource<T> resource)
            where T : class
        {
            return new JsonPayload(resource.GetText());
        }

        public IPayload Serialize<T>(T instance)
            where T : class
        {
            return new JsonPayload(StringExtensions.ToJson(instance));
        }

        public T Deserialize<T>(IPayload payload)
            where T : class
        {
            return payload.Deserialize<T>(this);
        }

        public T Deserialize<T>(string data)
            where T : class
        {
            return StringExtensions.FromJson<T>(data);
        }
    }
}