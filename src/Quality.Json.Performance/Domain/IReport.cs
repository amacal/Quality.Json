using System.Collections.Generic;

namespace Quality.Json.Performance.Domain
{
    public interface IReport
    {
        IEnumerable<ICaseInfo> GetCases();

        IEnumerable<ISubjectInfo> GetSubjects();

        IResultData GetDeserializationData(ISubjectInfo subject, ICaseInfo @case);

        IResultData GetSerializationData(ISubjectInfo subject, ICaseInfo @case);
    }
}
