using Quality.Json.Performance.Domain;

namespace Quality.Json.Performance.Requirements
{
    public class DeserializeOnlyRequirement : IRequirement
    {
        public string Name
        {
            get { return "deserialize-only"; }
        }

        public string Description
        {
            get { return null; }
        }
    }
}
