using ProtoBuf;

namespace Quality.Json.Performance.Resources
{
    [ProtoContract]
    public class WeatherContainer
    {
        [ProtoMember(1)]
        public int cnt { get; set; }

        [ProtoMember(2)]
        public City[] list { get; set; }

        [ProtoContract]
        public class City
        {
            [ProtoMember(1)]
            public int dt { get; set; }

            [ProtoMember(2)]
            public int id { get; set; }

            [ProtoMember(3)]
            public string name { get; set; }

            [ProtoMember(4)]
            public Clouds clouds { get; set; }

            [ProtoMember(5)]
            public Coordinates coord { get; set; }

            [ProtoMember(6)]
            public Main main { get; set; }

            [ProtoMember(7)]
            public System sys { get; set; }

            [ProtoMember(8)]
            public Weather[] weather { get; set; }

            [ProtoMember(9)]
            public Wind wind { get; set; }
        }

        [ProtoContract]
        public class Clouds
        {
            [ProtoMember(1)]
            public int all { get; set; }
        }

        [ProtoContract]
        public class Coordinates
        {
            [ProtoMember(1)]
            public double lat { get; set; }

            [ProtoMember(2)]
            public double lon { get; set; }
        }

        [ProtoContract]
        public class Main
        {
            [ProtoMember(1)]
            public int humidity { get; set; }

            [ProtoMember(2)]
            public int pressure { get; set; }

            [ProtoMember(3)]
            public double temp { get; set; }

            [ProtoMember(4)]
            public int temp_max { get; set; }

            [ProtoMember(5)]
            public int temp_min { get; set; }
        }

        [ProtoContract]
        public class System
        {
            [ProtoMember(1)]
            public string country { get; set; }

            [ProtoMember(2)]
            public int id { get; set; }

            [ProtoMember(3)]
            public double message { get; set; }

            [ProtoMember(4)]
            public int sunrise { get; set; }

            [ProtoMember(5)]
            public int sunset { get; set; }

            [ProtoMember(6)]
            public int type { get; set; }
        }

        [ProtoContract]
        public class Weather
        {
            [ProtoMember(1)]
            public string description { get; set; }

            [ProtoMember(2)]
            public string icon { get; set; }

            [ProtoMember(3)]
            public int id { get; set; }

            [ProtoMember(4)]
            public string main { get; set; }
        }

        [ProtoContract]
        public class Wind
        {
            [ProtoMember(1)]
            public int deg { get; set; }

            [ProtoMember(2)]
            public int speed { get; set; }
        }
    }
}