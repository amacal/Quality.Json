using Quality.Json.Performance.Domain;

namespace Quality.Json.Performance.Requirements
{
    public class EmptyArrayRequirement : IRequirement
    {
        public string Name
        {
            get { return "empty-array"; }
        }

        public string Description
        {
            get { return null; }
        }
    }
}
