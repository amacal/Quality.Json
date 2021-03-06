﻿using fastJSON;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Payloads;
using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Quality.Json.Performance.Subjects
{
    [Serializable]
    public class FastJsonSubject : ISubject, IJsonImplementation, ISerializable
    {
        private readonly JSONParameters parameters;

        public FastJsonSubject()
        {
            this.parameters = new JSONParameters { IgnoreCaseOnDeserialize = true, UseExtensions = false, UsingGlobalTypes = false };
        }

        public FastJsonSubject(SerializationInfo info, StreamingContext context)
        {
            this.parameters = new JSONParameters { IgnoreCaseOnDeserialize = true, UseExtensions = false, UsingGlobalTypes = false };
        }

        public string Name
        {
            get { return "fastJSON-" + FileVersionInfo.GetVersionInfo(typeof(JSON).Assembly.Location).FileVersion; }
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
            return new JsonPayload(JSON.ToJSON(instance, this.parameters));
        }

        public T Deserialize<T>(IPayload payload)
            where T : class
        {
            return payload.Deserialize<T>(this);
        }

        public T Deserialize<T>(string data)
            where T : class
        {
            return JSON.ToObject<T>(data, this.parameters);
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }
    }
}