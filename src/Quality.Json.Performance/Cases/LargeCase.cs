using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class LargeCase : ICase, IResource<Large>
    {
        public string Name
        {
            get { return "Large"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield return new JsonOnlyRequirement();
            yield return new DeserializeOnlyRequirement();
        }

        public IResultData Execute(IProcedure procedure, ISubject subject, ITimes times)
        {
            return procedure.Process(this, subject, times);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Large.json");
        }

        public MemoryStream GetData()
        {
            return new MemoryStream(File.ReadAllBytes(@"Resources\Large.bin"));
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(1);
        }

        public Large GetInstance()
        {
            return new Large
            {
                all_ascii = new Large.Text
                {
                    here = File.ReadAllText(@"Resources\Large.ascii")
                },
                all_unicode = new Large.Text
                {
                    here = File.ReadAllText(@"Resources\Large.unicode")
                },
                json_data = new Large.Data { },
                some_html = new Large.Html
                {
                    credits = @"http://www.immigration-usa.com/html_colors.html"
                }
            };
        }
    }
}
