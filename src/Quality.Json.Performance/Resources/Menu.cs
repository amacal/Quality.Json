using ProtoBuf;

namespace Quality.Json.Performance.Resources
{
    [ProtoContract]
    public class MenuContainer
    {
        [ProtoMember(1)]
        public Menu menu { get; set; }

        [ProtoContract]
        public class Menu
        {
            [ProtoMember(1)]
            public string id { get; set; }

            [ProtoMember(2)]
            public string value { get; set; }

            [ProtoMember(3)]
            public Popup popup { get; set; }
        }

        [ProtoContract]
        public class Popup
        {
            [ProtoMember(1)]
            public MenuItem[] menuitem { get; set; }
        }

        [ProtoContract]
        public class MenuItem
        {
            [ProtoMember(1)]
            public string value { get; set; }

            [ProtoMember(2)]
            public string onclick { get; set; }
        }
    }
}