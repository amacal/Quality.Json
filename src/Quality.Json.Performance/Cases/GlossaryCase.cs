using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class GlossaryCase : ICase, IResource<GlossaryContainer>
    {
        public string Name
        {
            get { return "Glossary"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IEnumerable<IRequirement> GetRequirements()
        {
            yield return new CaseInsensitiveRequirement();
        }

        public IResultData Execute(IProcedure procedure, ISubject subject)
        {
            return procedure.Process(this, subject);
        }

        public string GetText()
        {
            return File.ReadAllText(@"Resources\Glossary.json");
        }

        public byte[] GetData()
        {
            return File.ReadAllBytes(@"Resources\Glossary.json");
        }

        public int Multiply(int times)
        {
            return times * 200;
        }

        public GlossaryContainer GetInstance()
        {
            return new GlossaryContainer
            {
                glossary = new GlossaryContainer.Glossary
                {
                    title = "example glossary",
                    glossdiv = new GlossaryContainer.GlossaryDiv
                    {
                        title = "S",
                        glosslist = new GlossaryContainer.GlossaryList
                        {
                            glossentry = new GlossaryContainer.GlossaryEntry
                            {
                                id = "SGML",
                                sortas = "SGML",
                                glossterm = "Standard Generalized Markup Language",
                                acronym = "SGML",
                                abbrev = "ISO 8879:1986",
                                glossdef = new GlossaryContainer.GlossaryDef
                                {
                                    para = "A meta-markup language, used to create markup languages such as DocBook.",
                                    glossseealso = new string[] { "GML", "XML" }
                                },
                                glosssee = "markup"
                            }
                        }
                    }
                }
            };
        }
    }
}