using System.Collections.Generic;

namespace Quality.Json.Performance.Domain
{
    public interface IReport
    {
        IEnumerable<IDescriptive> GetCases();

        IEnumerable<IDescriptive> GetSubjects();

        IResultData GetDeserializationData(IDescriptive subject, IDescriptive @case);

        IResultData GetSerializationData(IDescriptive subject, IDescriptive @case);
    }
}
