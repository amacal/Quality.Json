namespace Quality.Json.Performance.Resources
{
    public class GlossaryContainer
    {
        public Glossary glossary { get; set; }

        public class Glossary
        {
            public string title { get; set; }
            public GlossaryDiv glossdiv { get; set; }
        }

        public class GlossaryDiv
        {
            public string title { get; set; }
            public GlossaryList glosslist { get; set; }
        }

        public class GlossaryList
        {
            public GlossaryEntry glossentry { get; set; }
        }

        public class GlossaryEntry
        {
            public string id { get; set; }
            public string sortas { get; set; }
            public string glossterm { get; set; }
            public string acronym { get; set; }
            public string abbrev { get; set; }
            public string glosssee { get; set; }

            public GlossaryDef glossdef { get; set; }
        }

        public class GlossaryDef
        {
            public string para { get; set; }
            public string[] glossseealso { get; set; }
        }
    }
}
