using KellermanSoftware.CompareNetObjects;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Results;
using System;

namespace Quality.Json.Performance.Procedures
{
    [Serializable]
    public class DeserializeProcedure : IProcedure
    {
        private readonly int times;

        public DeserializeProcedure(int times)
        {
            this.times = times;
        }

        public string Name
        {
            get { return "Deserialize"; }
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
                result = result ?? DeserializeInLoop<T>(resource, subject);
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
            string text = resource.GetText();
            T template = resource.GetInstance();

            ICompareLogic comparer = new CompareLogic(new ComparisonConfig { MaxDifferences = 100 });
            T deserialized = subject.Deserialize<T>(text);

            IResultData result = null;
            ComparisonResult comparision = comparer.Compare(template, deserialized);

            if (comparision.AreEqual == false)
            {
                result = new InvalidComparisionResult(comparision.DifferencesString);
            }

            return result;
        }

        private IResultData DeserializeInLoop<T>(IResource<T> resource, ISubject subject)
            where T : class
        {
            int times = resource.Multiply(this.times);
            string text = resource.GetText();

            DateTime started = DateTime.Now;

            for (int i = 0; i < times; i++)
            {
                subject.Deserialize<T>(text);
            }

            return new MeasuredDurationResult(DateTime.Now - started);
        }
    }
}