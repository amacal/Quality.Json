using Quality.Json.Performance.Domain;
using System;
using System.Diagnostics;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class NetJsonSubject : ISubject
    {
        static NetJsonSubject()
        {
            NetJSON.NetJSON.CaseSensitive = false;
        }

        public string Name
        {
            get { return "NetJSON-" + FileVersionInfo.GetVersionInfo(typeof(NetJSON.NetJSON).Assembly.Location).FileVersion; }
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
            where T : class, new()
        {
            return NetJSON.NetJSON.Serialize<T>(instance);
        }

        public T Deserialize<T>(string data) 
            where T : class, new()
        {
            return NetJSON.NetJSON.Deserialize<T>(data);
        }
    }
}
