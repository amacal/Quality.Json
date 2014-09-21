using Quality.Json.Performance.Domain;
using System;

namespace Quality.Json.Performance.Results
{
    [Serializable]
    public class NotSupportedRequirementResult : IResultData
    {
        public bool HasRemark()
        {
            return false;
        }

        public IRemark GetRemark()
        {
            throw new InvalidOperationException("The result has no remarks. You should use HasRemarks method to determine if this method should be called.");
        }

        public override string ToString()
        {
            return "-- --- --";
        }
    }
}
