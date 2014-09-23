using Quality.Json.Performance.Domain;
using ServiceStack;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class ServiceStackSubject : ISubject
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

        public string Serialize<T>(T instance) 
            where T : class
        {
            return StringExtensions.ToJson(instance);
        }

        public T Deserialize<T>(string data) 
            where T : class
        {
            return StringExtensions.FromJson<T>(data);
        }
    }
}
