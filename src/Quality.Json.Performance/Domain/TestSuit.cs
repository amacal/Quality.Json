using System.Collections.Generic;

namespace Quality.Json.Performance.Domain
{
    internal class TestSuit : ITestSuit
    {
        private readonly List<TestInstance> items;

        public TestSuit()
        {
            this.items = new List<TestInstance>();
        }

        public void AddInstance(TestInstance instance)
        {
            this.items.Add(instance);
        }

        public IReport Execute()
        {
            Report report = new Report();

            foreach (ITestInstance instance in this.items)
            {
                report.AddResult(instance.Execute());
            }

            return report;
        }
    }
}