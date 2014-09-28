using System;

namespace Quality.Json.Performance.Domain
{
    [Serializable]
    public class Times : ITimes
    {
        private readonly int count;

        public Times(int count)
        {
            this.count = count;
        }

        public ITimes Multiply(int value)
        {
            return new Times(this.count * value);
        }

        public void Execute(IRoutine routine)
        {
            for (int i = 0; i < this.count; i++)
            {
                routine.Execute();
            }
        }

        public string Describe()
        {
            if (this.count == 1)
            {
                return "1 time";
            }

            return this.count + " times";
        }
    }
}
