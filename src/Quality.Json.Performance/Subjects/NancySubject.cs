using Nancy.Json;
using Quality.Json.Performance.Domain;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class NancySubject : ISubject, ISerializable
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

        public string Serialize<T>(T instance)
            where T : class
        {
            return this.instance.Serialize(instance);
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