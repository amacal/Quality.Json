namespace Quality.Json.Performance.Resources
{
    public class MenuContainer
    {
        public Menu menu { get; set; }

        public class Menu
        {
            public string id { get; set; }
            public string value { get; set; }

            public Popup popup { get; set; }
        }

        public class Popup
        {
            public MenuItem[] menuitem { get; set; }
        }

        public class MenuItem
        {
            public string value { get; set; }
            public string onclick { get; set; }
        }
    }
}