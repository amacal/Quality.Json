using Quality.Json.Performance.Domain;
using System;

namespace Quality.Json.Performance.Results
{
    [Serializable]
    public class InvalidComparisionResult : IResultData
    {
        private readonly IRemark remark;

        public InvalidComparisionResult(string difference)
        {
            this.remark = new Remark(difference);
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
            return "INVALID   ";
        }

        public void Visit(IResultDataVisitor visitor)
        {
        }
    }
}