using System;
using System.Collections.Generic;
using System.Linq;

namespace Quality.Json.Performance.Domain
{
    internal class TestSuit : ITestSuit
    {
        private readonly List<IInstance> items;

        public TestSuit()
        {
            this.items = new List<IInstance>();
        }

        public void AddInstance(IInstance instance)
        {
            this.items.Add(instance);
        }

        public IReport Execute(ITimes times)
        {
            Report report = new Report();

            foreach (IExecutionGroup @group in this.GroupInstances())
            {
                foreach (IResult result in @group.Execute(times))
                {
                    report.AddResult(result);
                }
            }

            return report;
        }

        private IEnumerable<IExecutionGroup> GroupInstances()
        {
            return from item in this.items
                   group item by item.Case into @group
                   select new CaseGroup(@group.Key, @group.ToArray());
        }

        private class CaseGroup : IExecutionGroup
        {
            private readonly ICaseInfo @case;
            private readonly IInstance[] instances;

            public CaseGroup(ICaseInfo @case, IInstance[] instances)
            {
                this.@case = @case;
                this.instances = instances;
            }

            public IResult[] Execute(ITimes times)
            {
                while (true)
                {
                    MinDurationVisitor visitor = new MinDurationVisitor();
                    IResult[] results = instances.Select(x => x.Execute(times)).ToArray();

                    foreach (IResult result in results)
                    {
                        result.Data.Visit(visitor);
                    }

                    if (visitor.HasValue() == false || visitor.GetValue().TotalSeconds >= 1.0d)
                    {
                        return results;
                    }

                    double ceiling = Math.Ceiling(1.0d / visitor.GetValue().TotalSeconds);
                    times = times.Multiply(Math.Max(2, (int)ceiling));
                }
            }
        }

        private class MinDurationVisitor : IResultDataVisitor
        {
            private TimeSpan? value;

            public void Visit(TimeSpan duration)
            {
                if (value == null || value > duration)
                {
                    value = duration;
                }
            }

            public bool HasValue()
            {
                return this.value != null;
            }

            public TimeSpan GetValue()
            {
                return this.value.Value;
            }
        }
    }
}