using Quality.Json.Performance.Domain;
using System;

namespace Quality.Json.Performance.Results
{
    [Serializable]
    public class Remark : IRemark
    {
        private readonly string data;

        public Remark(string data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return this.data;
        }
    }
}
