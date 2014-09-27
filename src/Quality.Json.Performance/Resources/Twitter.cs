namespace Quality.Json.Performance.Resources
{
    public class Twitter
    {
        public Query query { get; set; }
        public Result result { get; set; }

        public class Query
        {
            public Parameters @params { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }

        public class Parameters
        {
            public int accuracy { get; set; }
            public bool autocomplete { get; set; }
            public string granularity { get; set; }
            public string query { get; set; }
            public bool trim_place { get; set; }
        }

        public class Result
        {
            public Place[] places { get; set; }
        }

        public class Place
        {
            public Attributes attributes { get; set; }
            public BoundingBox bounding_box { get; set; }
            public Place[] contained_within { get; set; }

            public string country { get; set; }
            public string country_code { get; set; }
            public string full_name { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string place_type { get; set; }
            public string url { get; set; }
        }
        
        public class Attributes
        {
        }

        public class BoundingBox
        {
            public double[][][] coordinates  { get; set; }
            public string type { get; set; }
        }
    }
}
