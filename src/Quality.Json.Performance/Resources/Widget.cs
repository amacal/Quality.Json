using ProtoBuf;

namespace Quality.Json.Performance.Resources
{
    [ProtoContract]
    public class WidgetContainer
    {
        [ProtoMember(1)]
        public Widget widget { get; set; }

        [ProtoContract]
        public class Widget
        {
            [ProtoMember(1)]
            public string debug { get; set; }

            [ProtoMember(2)]
            public Window window { get; set; }

            [ProtoMember(3)]
            public Image image { get; set; }

            [ProtoMember(4)]
            public Text text { get; set; }
        }

        [ProtoContract]
        public class Window
        {
            [ProtoMember(1)]
            public string title { get; set; }

            [ProtoMember(2)]
            public string name { get; set; }

            [ProtoMember(3)]
            public int width { get; set; }

            [ProtoMember(4)]
            public int height { get; set; }
        }

        [ProtoContract]
        public class Image
        {
            [ProtoMember(1)]
            public string src { get; set; }

            [ProtoMember(2)]
            public string name { get; set; }

            [ProtoMember(3)]
            public int hOffset { get; set; }

            [ProtoMember(4)]
            public int vOffset { get; set; }

            [ProtoMember(5)]
            public string alignment { get; set; }
        }

        [ProtoContract]
        public class Text
        {
            [ProtoMember(1)]
            public string data { get; set; }

            [ProtoMember(2)]
            public int size { get; set; }

            [ProtoMember(3)]
            public string style { get; set; }

            [ProtoMember(4)]
            public string name { get; set; }

            [ProtoMember(5)]
            public int hOffset { get; set; }

            [ProtoMember(6)]
            public int vOffset { get; set; }

            [ProtoMember(7)]
            public string alignment { get; set; }

            [ProtoMember(8)]
            public string onMouseUp { get; set; }
        }
    }
}