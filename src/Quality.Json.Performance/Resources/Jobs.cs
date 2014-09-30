using ProtoBuf;

namespace Quality.Json.Performance.Resources
{
    [ProtoContract]
    public class Job
    {
        [ProtoMember(1)]
        public string id { get; set; }

        [ProtoMember(2)]
        public string created_at { get; set; }

        [ProtoMember(3)]
        public string title { get; set; }

        [ProtoMember(4)]
        public string location { get; set; }

        [ProtoMember(5)]
        public string type { get; set; }

        [ProtoMember(6)]
        public string description { get; set; }

        [ProtoMember(7)]
        public string how_to_apply { get; set; }

        [ProtoMember(8)]
        public string company { get; set; }

        [ProtoMember(9)]
        public string company_url { get; set; }

        [ProtoMember(10)]
        public string company_logo { get; set; }

        [ProtoMember(11)]
        public string url { get; set; }
    }
}