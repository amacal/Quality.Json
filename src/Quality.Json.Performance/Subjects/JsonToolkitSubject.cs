using ComputerBeacon.Json;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class JsonToolkitSubject : ISubject
    {
        public string Name
        {
            get { return "JsonToolkit-" + FileVersionInfo.GetVersionInfo(typeof(Serializer).Assembly.Location).FileVersion; }
        }

        public string Description
        {
            get { return null; }
        }

        public bool IsSupported(IRequirement requirement)
        {
            return requirement is CaseInsensitiveRequirement == false;
        }

        public string Serialize<T>(T instance)
            where T : class, new()
        {
            return Serializer.Serialize(instance);
        }

        public T Deserialize<T>(string data)
            where T : class, new()
        {
            return Serializer.Deserialize<T>(data);
        }
    }
}
