namespace Quality.Json.Performance.Resources
{
    public class Large
    {
        public Text all_ascii { get; set; }
        public Text all_unicode { get; set; }
        public Html some_html { get; set; }
        public Data json_data { get; set; }

        public string nothing { get; set; }

        public class Text
        {
            public string here { get; set; }
        }

        public class Html
        {
            public string credits { get; set; }
        }

        public class Data
        {
            public string nothing { get; set; }
        }
    }
}
