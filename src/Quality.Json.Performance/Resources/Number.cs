using ProtoBuf;

namespace Quality.Json.Performance.Resources
{
    [ProtoContract]
    public class Number
    {
        [ProtoMember(1)]
        public string description { get; set; }

        [ProtoMember(2)]
        public Schema schema { get; set; }

        [ProtoMember(3)]
        public Test[] tests { get; set; }

        [ProtoContract]
        public class Schema
        {
            [ProtoMember(1)]
            public string type { get; set; }
        }

        [ProtoContract]
        public class Test
        {
            [ProtoMember(1)]
            public string description { get; set; }

            [ProtoMember(2)]
            public bool valid { get; set; }
        }
    }
}
