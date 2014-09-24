using Quality.Json.Performance.Domain;
using System;

namespace Quality.Json.Performance.Results
{
    [Serializable]
    public class MeasuredDurationResult : IResultData
    {
        private readonly TimeSpan duration;

        public MeasuredDurationResult(TimeSpan duration)
        {
            this.duration = duration;
        }

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
            return this.duration.TotalMilliseconds.ToString("F3") + " ms";
        }
    }
}