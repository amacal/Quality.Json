using System.Collections.Generic;

namespace Quality.Json.Performance.Domain
{
    public interface ICaseInfo : IDescriptive
    {
        IEnumerable<IRequirement> GetRequirements();
    }
}