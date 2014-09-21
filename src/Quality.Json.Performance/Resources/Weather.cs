namespace Quality.Json.Performance.Resources
{
    public class WeatherContainer
    {
        public int cnt { get; set; }
        public City[] list { get; set; }

        public class City
        {
            public int dt { get; set; }
            public int id { get; set; }
            public string name { get; set; }

            public Clouds clouds { get; set; }
            public Coordinates coord { get; set; }
            public Main main { get; set; }
            public System sys { get; set; }
            public Weather[] weather { get; set; }
            public Wind wind { get; set; }
        }

        public class Clouds
        {
            public int all { get; set; }
        }

        public class Coordinates
        {
            public double lat { get; set; }
            public double lon { get; set; }
        }

        public class Main
        {
            public int humidity { get; set; }
            public int pressure { get; set; }
            public double temp { get; set; }
            public int temp_max { get; set; }
            public int temp_min { get; set; }
        }

        public class System
        {
            public string country { get; set; }
            public int id { get; set; }
            public double message { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public int type { get; set; }
        }

        public class Weather
        {
            public string description { get; set; }
            public string icon { get; set; }
            public int id { get; set; }
            public string main { get; set; }
        }

        public class Wind
        {
            public int deg { get; set; }
            public int speed { get; set; }
        }
    }
}
