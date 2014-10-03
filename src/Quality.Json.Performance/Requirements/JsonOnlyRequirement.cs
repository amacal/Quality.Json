using Quality.Json.Performance.Domain;

namespace Quality.Json.Performance.Requirements
{
    public class JsonOnlyRequirement : IRequirement
    {
        public string Name
        {
            get { return "json-only"; }
        }

        public string Description
        {
            get { return null; }
        }
    }
}
