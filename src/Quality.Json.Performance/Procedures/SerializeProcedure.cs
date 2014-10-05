using KellermanSoftware.CompareNetObjects;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Requirements;
using Quality.Json.Performance.Results;
using System;

namespace Quality.Json.Performance.Procedures
{
    [Serializable]
    public class SerializeProcedure : IProcedure
    {
        public string Name
        {
            get { return "Serialize"; }
        }

        public string Description
        {
            get { return null; }
        }

        public bool CanHandle(IRequirement requirement)
        {
            return requirement is DeserializeOnlyRequirement == false;
        }

        public IResultData Process<T>(IResource<T> resource, ISubject subject, ITimes times)
            where T : class
        {
            IResultData result = null;

            try
            {
                result = result ?? Validate<T>(resource, subject);
                result = result ?? Serialize<T>(resource, subject, times);
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
            T instance = resource.GetInstance();
            ICompareLogic comparer = new CompareLogic(new ComparisonConfig { MaxDifferences = 100 });

            IPayload payload = subject.Serialize<T>(instance);
            T deserialized = subject.Deserialize<T>(payload);

            IResultData result = null;
            ComparisonResult comparision = comparer.Compare(instance, deserialized);

            if (comparision.AreEqual == false)
            {
                result = new InvalidComparisionResult(comparision.DifferencesString);
            }

            return result;
        }

        private IResultData Serialize<T>(IResource<T> resource, ISubject subject, ITimes times)
            where T : class
        {
            times = resource.Multiply(times);
            T instance = resource.GetInstance();

            IRoutine routine = new Routine<T>(subject, instance);
            TimeSpan started = AppDomain.CurrentDomain.MonitoringTotalProcessorTime;

            times.Execute(routine);
            TimeSpan ended = AppDomain.CurrentDomain.MonitoringTotalProcessorTime;

            return new MeasuredDurationResult(ended - started);
        }

        private class Routine<T> : IRoutine
            where T : class
        {
            private readonly ISubject subject;
            private readonly T instance;

            public Routine(ISubject subject, T instance)
            {
                this.subject = subject;
                this.instance = instance;
            }

            public void Execute()
            {
                this.subject.Serialize(this.instance);
            }
        }
    }
}