namespace Quality.Json.Performance.Resources
{
    public class WidgetContainer
    {
        public Widget widget { get; set; }

        public class Widget
        {
            public string debug { get; set; }

            public Window window { get; set; }
            public Image image { get; set; }
            public Text text { get; set; }
        }

        public class Window
        {
            public string title { get; set; }
            public string name { get; set; }

            public int width { get; set; }
            public int height { get; set; }
        }

        public class Image
        {
            public string src { get; set; }
            public string name { get; set; }
            public int hOffset { get; set; }
            public int vOffset { get; set; }
            public string alignment { get; set; }
        }

        public class Text
        {
            public string data { get; set; }
            public int size { get; set; }
            public string style { get; set; }
            public string name { get; set; }
            public int hOffset { get; set; }
            public int vOffset { get; set; }
            public string alignment { get; set; }
            public string onMouseUp { get; set; }
        }
    }
}
