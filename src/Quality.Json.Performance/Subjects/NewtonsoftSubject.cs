using Newtonsoft.Json;
using Quality.Json.Performance.Domain;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class NewtonsoftSubject : ISubject
    {
        public string Name
        {
            get { return "Newtonsoft.Json-" + FileVersionInfo.GetVersionInfo(typeof(JsonConvert).Assembly.Location).FileVersion; }
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
            return JsonConvert.SerializeObject(instance);
        }

        public T Deserialize<T>(string data) 
            where T : class
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
