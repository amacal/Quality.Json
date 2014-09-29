using Nancy.Json;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Payloads;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class NancySubject : ISubject, IJsonImplementation, ISerializable
    {
        private readonly JavaScriptSerializer instance;

        public NancySubject()
        {
            this.instance = new JavaScriptSerializer();
        }

        public NancySubject(SerializationInfo info, StreamingContext context)
        {
            this.instance = new JavaScriptSerializer();
        }

        public string Name
        {
            get { return "Nancy-" + FileVersionInfo.GetVersionInfo(typeof(JavaScriptSerializer).Assembly.Location).FileVersion; }
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
            return new JsonPayload(this.instance.Serialize(instance));
        }

        public T Deserialize<T>(IPayload payload)
            where T : class
        {
            return payload.Deserialize<T>(this);
        }

        public T Deserialize<T>(string data)
            where T : class
        {
            return this.instance.Deserialize<T>(data);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }
    }
}