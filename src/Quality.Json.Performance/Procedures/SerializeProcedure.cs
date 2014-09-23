using KellermanSoftware.CompareNetObjects;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Results;
using System;

namespace Quality.Json.Performance.Procedures
{
    [Serializable]
    public class SerializeProcedure : IProcedure
    {
        private readonly int times;

        public SerializeProcedure(int times)
        {
            this.times = times;
        }

        public string Name
        {
            get { return "Serialize"; }
        }

        public string Description
        {
            get { return null; }
        }

        public IResultData Process<T>(IResource<T> resource, ISubject subject)
            where T : class
        {
            IResultData result = null;

            try
            {
                result = result ?? ValidateContent<T>(resource, subject);
                result = result ?? SerializeInLoop<T>(resource, subject);
            }
            catch (Exception ex)
            {
                result = new FailedByExceptionResult(ex);
            }

            return result;
        }

        private IResultData ValidateContent<T>(IResource<T> resource, ISubject subject)
            where T : class
        {
            T instance = resource.GetInstance();
            ICompareLogic comparer = new CompareLogic(new ComparisonConfig { MaxDifferences = 100 });

            string text = subject.Serialize<T>(instance);
            T deserialized = subject.Deserialize<T>(text);

            IResultData result = null;
            ComparisonResult comparision = comparer.Compare(instance, deserialized);

            if (comparision.AreEqual == false)
            {
                result = new InvalidComparisionResult(comparision.DifferencesString);
            }

            return result;
        }

        private IResultData SerializeInLoop<T>(IResource<T> resource, ISubject subject)
            where T : class
        {
            int times = resource.Multiply(this.times);
            T instance = resource.GetInstance();

            DateTime started = DateTime.Now;

            for (int i = 0; i < times; i++)
            {
                subject.Serialize<T>(instance);
            }

            return new MeasuredDurationResult(DateTime.Now - started);
        }
    }
}
