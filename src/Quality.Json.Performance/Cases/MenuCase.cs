using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class MenuCase : ICase, IResource<MenuContainer>
    {
        public string Name
        {
            get { return "Menu"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield break;
        }

        public IResultData Execute(IProcedure procedure, ISubject subject, ITimes times)
        {
            return procedure.Process(this, subject, times);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Menu.json");
        }

        public byte[] GetData()
        {
            return File.ReadAllBytes(@"Resources\Menu.json");
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(400);
        }

        public MenuContainer GetInstance()
        {
            return new MenuContainer
            {
                menu = new MenuContainer.Menu
                {
                    id = "file",
                    value = "File",
                    popup = new MenuContainer.Popup
                    {
                        menuitem = new[]
                        {
                            new MenuContainer.MenuItem { value = "New", onclick = "CreateNewDoc()" },
                            new MenuContainer.MenuItem { value = "Open", onclick = "OpenDoc()" },
                            new MenuContainer.MenuItem { value = "Close", onclick = "CloseDoc()" },
                        }
                    }
                }
            };
        }
    }
}