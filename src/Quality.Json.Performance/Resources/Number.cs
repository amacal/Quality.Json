namespace Quality.Json.Performance.Resources
{
    public class Number
    {
        public string description { get; set; }
        public Schema schema { get; set; }
        public Test[] tests { get; set; }

        public class Schema
        {
            public string type { get; set; }
        }

        public class Test
        {
            public string description { get; set; }
            public bool valid { get; set; }
        }
    }
}
