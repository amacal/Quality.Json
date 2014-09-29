using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Cases
{
    [Serializable]
    public class NumberCase : ICase, IResource<Number[]>
    {
        public string Name
        {
            get { return "Number"; }
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
            return File.ReadAllText(@"Resources\Number.json");
        }

        public byte[] GetData()
        {
            return File.ReadAllBytes(@"Resources\Number.json");
        }

        public ITimes Multiply(ITimes times)
        {
            return times.Multiply(100);
        }

        public Number[] GetInstance()
        {
            return new[]
            {
                new Number
                {
                    description = "integer",
                    schema = new Number.Schema { type = "integer" },
                    tests = new[]
                    {
                        new Number.Test { description = "a bignum is an integer", valid = true }
                    }
                },
                new Number
                {
                    description = "number",
                    schema = new Number.Schema { type = "number" },
                    tests = new[]
                    {
                        new Number.Test { description = "a bignum is a number", valid = true }
                    }
                },
                new Number
                {
                    description = "string",
                    schema = new Number.Schema { type = "string" },
                    tests = new[]
                    {
                        new Number.Test { description = "a bignum is not a string", valid = false }
                    }
                },
                new Number
                {
                    description = "integer comparison",
                    schema = new Number.Schema { },
                    tests = new[]
                    {
                        new Number.Test { description = "comparison works for high numbers", valid = true }
                    }
                },
                new Number
                {
                    description = "float comparison with high precision",
                    schema = new Number.Schema { },
                    tests = new[]
                    {
                        new Number.Test { description = "comparison works for high numbers", valid = false }
                    }
                }
            };
        }
    }
}
