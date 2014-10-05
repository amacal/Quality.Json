using ProtoBuf;

namespace Quality.Json.Performance.Resources
{
    [ProtoContract]
    public class GlossaryContainer
    {
        [ProtoMember(1)]
        public Glossary glossary { get; set; }

        [ProtoContract]
        public class Glossary
        {
            [ProtoMember(1)]
            public string title { get; set; }

            [ProtoMember(2)]
            public GlossaryDiv glossdiv { get; set; }
        }

        [ProtoContract]
        public class GlossaryDiv
        {
            [ProtoMember(1)]
            public string title { get; set; }

            [ProtoMember(2)]
            public GlossaryList glosslist { get; set; }
        }

        [ProtoContract]
        public class GlossaryList
        {
            [ProtoMember(1)]
            public GlossaryEntry glossentry { get; set; }
        }

        [ProtoContract]
        public class GlossaryEntry
        {
            [ProtoMember(1)]
            public string id { get; set; }

            [ProtoMember(2)]
            public string sortas { get; set; }

            [ProtoMember(3)]
            public string glossterm { get; set; }

            [ProtoMember(4)]
            public string acronym { get; set; }

            [ProtoMember(5)]
            public string abbrev { get; set; }

            [ProtoMember(6)]
            public string glosssee { get; set; }

            [ProtoMember(7)]
            public GlossaryDef glossdef { get; set; }
        }

        [ProtoContract]
        public class GlossaryDef
        {
            [ProtoMember(1)]
            public string para { get; set; }

            [ProtoMember(2)]
            public string[] glossseealso { get; set; }
        }
    }
}