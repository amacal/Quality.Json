using Jil;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class JilSubject : ISubject
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

        public string Serialize<T>(T instance)
            where T : class, new()
        {
            return JSON.Serialize(instance);
        }

        public T Deserialize<T>(string data)
            where T : class, new()
        {
            return JSON.Deserialize<T>(data);
        }
    }
}
