using KellermanSoftware.CompareNetObjects;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Results;
using System;

namespace Quality.Json.Performance.Procedures
{
    [Serializable]
    public class DeserializeProcedure : IProcedure
    {
        public string Name
        {
            get { return "Deserialize"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IResultData Process<T>(IResource<T> resource, ISubject subject, ITimes times)
            where T : class
        {
            IResultData result = null;

            try
            {
                result = result ?? Validate<T>(resource, subject);
                result = result ?? Deserialize<T>(resource, subject, times);
            }
            catch (Exception ex)
            {
                result = new FailedByExceptionResult(ex);
            }

            return result;
        }

        private IResultData Validate<T>(IResource<T> resource, ISubject subject)
            where T : class
        {
            IPayload payload = subject.Create<T>(resource);
            T template = resource.GetInstance();

            ICompareLogic comparer = new CompareLogic(new ComparisonConfig { MaxDifferences = 100 });
            T deserialized = subject.Deserialize<T>(payload);

            IResultData result = null;
            ComparisonResult comparision = comparer.Compare(template, deserialized);

            if (comparision.AreEqual == false)
            {
                result = new InvalidComparisionResult(comparision.DifferencesString);
            }

            return result;
        }

        private IResultData Deserialize<T>(IResource<T> resource, ISubject subject, ITimes times)
            where T : class
        {
            times = resource.Multiply(times);
            IPayload payload = subject.Create<T>(resource);

            IRoutine routine = new Routine<T>(subject, payload);
            DateTime started = DateTime.Now;

            times.Execute(routine);
            return new MeasuredDurationResult(DateTime.Now - started);
        }

        private class Routine<T> : IRoutine
            where T : class
        {
            private readonly ISubject subject;
            private readonly IPayload payload;

            public Routine(ISubject subject, IPayload payload)
            {
                this.subject = subject;
                this.payload = payload;
            }

            public void Execute()
            {
                this.subject.Deserialize<T>(this.payload);
            }
        }
    }
}