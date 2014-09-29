using Quality.Json.Performance.Domain;
using System;

namespace Quality.Json.Performance.Results
{
    [Serializable]
    public class FailedByExceptionResult : IResultData
    {
        private readonly IRemark remark;

        public FailedByExceptionResult(Exception reason)
        {
            this.remark = new Remark(reason.Message);
        }

        public bool HasRemark()
        {
            return true;
        }

        public IRemark GetRemark()
        {
            return this.remark;
        }

        public string Describe()
        {
            return "FAILED   ";
        }

        public void Visit(IResultDataVisitor visitor)
        {
        }
    }
}