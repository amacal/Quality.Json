using Quality.Json.Performance.Domain;

namespace Quality.Json.Performance.Requirements
{
    public class CaseInsensitiveRequirement : IRequirement
    {
        public string Name
        {
            get { return "case-insensitive"; }
        }

        public string Description
        {
            get { return null; }
        }
    }
}