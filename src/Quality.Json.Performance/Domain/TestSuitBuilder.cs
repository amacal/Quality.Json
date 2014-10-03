using System.Collections.Generic;
using System.Linq;

namespace Quality.Json.Performance.Domain
{
    public class TestSuitBuilder : ITestSuitBuilder
    {
        private readonly List<ICase> cases;
        private readonly List<ISubject> subjects;
        private readonly List<IProcedure> procedures;

        public TestSuitBuilder()
        {
            this.cases = new List<ICase>();
            this.subjects = new List<ISubject>();
            this.procedures = new List<IProcedure>();
        }

        public void AddCase(ICase @case)
        {
            this.cases.Add(@case);
        }

        public void AddSubject(ISubject subject)
        {
            this.subjects.Add(subject);
        }

        public void AddProcedure(IProcedure procedure)
        {
            this.procedures.Add(procedure);
        }

        public ITestSuit Build()
        {
            TestSuit suit = new TestSuit();

            foreach (ICase @case in this.cases)
            {
                foreach (ISubject subject in this.subjects)
                {
                    if (@case.GetRequirements().All(subject.CanHandle) == true)
                    {
                        foreach (IProcedure procedure in this.procedures)
                        {
                            if (@case.GetRequirements().All(procedure.CanHandle) == true)
                            {
                                suit.AddInstance(new Instance(@case, subject, procedure));
                            }
                        }
                    }
                }
            }

            return suit;
        }
    }
}