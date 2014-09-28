using System.Collections.Generic;

namespace Quality.Json.Performance.Domain
{
    internal class TestSuit : ITestSuit
    {
        private readonly List<ITestInstance> items;

        public TestSuit()
        {
            this.items = new List<ITestInstance>();
        }

        public void AddInstance(ITestInstance instance)
        {
            this.items.Add(instance);
        }

        public IReport Execute(ITimes times)
        {
            Report report = new Report();

            foreach (ITestInstance instance in this.items)
            {
                report.AddResult(instance.Execute(times));
            }

            return report;
        }
    }
}