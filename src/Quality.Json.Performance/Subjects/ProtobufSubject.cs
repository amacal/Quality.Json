using ProtoBuf;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Payloads;
using Quality.Json.Performance.Requirements;
using System;
using System.Diagnostics;
using System.IO;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class ProtobufSubject : ISubject, IProtobufImplementation
    {
        public string Name
        {
            get { return "protobuf-net-" + FileVersionInfo.GetVersionInfo(typeof(Serializer).Assembly.Location).FileVersion; }
        }

        public string Description
        {
            get { return null; }
        }

        public bool CanHandle(IRequirement requirement)
        {
            return requirement is JaggedArrayRequirement == false
                && requirement is EmptyArrayRequirement == false
                && requirement is JsonOnlyRequirement == false;
        }

        public IPayload Create<T>(IResource<T> resource)
            where T : class
        {
            return new ProtobufPayload(resource.GetData());
        }

        public IPayload Serialize<T>(T instance)
            where T : class
        {
            MemoryStream stream = new MemoryStream();
            Serializer.Serialize<T>(stream, instance);
            return new ProtobufPayload(stream);
        }

        public T Deserialize<T>(IPayload payload)
            where T : class
        {
            return payload.Deserialize<T>(this);
        }

        public T Deserialize<T>(MemoryStream stream) 
            where T : class
        {
            return Serializer.Deserialize<T>(stream);
        }
    }
}
