using System.Collections.Generic;

namespace Quality.Json.Performance.Domain
{
    public interface ICase : IDescriptive
    {
        IEnumerable<IRequirement> GetRequirements();

        IResultData Execute(IProcedure procedure, ISubject subject);
    }
}
