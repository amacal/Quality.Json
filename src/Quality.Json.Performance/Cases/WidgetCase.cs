using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class WidgetCase : ICase, IResource<WidgetContainer>
    {
        public string Name
        {
            get { return "Widget"; }
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
            return File.ReadAllText(@"Resources\Widget.json");
        }

        public MemoryStream GetData()
        {
            return new MemoryStream(File.ReadAllBytes(@"Resources\Widget.bin"));
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(200);
        }

        public WidgetContainer GetInstance()
        {
            return new WidgetContainer
            {
                widget = new WidgetContainer.Widget
                {
                    debug = "on",
                    window = new WidgetContainer.Window
                    {
                        title = "Sample Konfabulator Widget",
                        name = "main_window",
                        width = 500,
                        height = 500,
                    },
                    image = new WidgetContainer.Image
                    {
                        src = "Images/Sun.png",
                        name = "sun1",
                        hOffset = 250,
                        vOffset = 250,
                        alignment = "center"
                    },
                    text = new WidgetContainer.Text
                    {
                        data = "Click Here",
                        size = 36,
                        style = "bold",
                        name = "text1",
                        hOffset = 250,
                        vOffset = 100,
                        alignment = "center",
                        onMouseUp = "sun1.opacity = (sun1.opacity / 100) * 90;"
                    }
                }
            };
        }
    }
}