using System;
using System.Linq;
using System.Threading.Tasks;

namespace Quality.Json.Performance.Domain
{
    public class Parallelism : IParallelism
    {
        private readonly int degree;

        public Parallelism(int degree)
        {
            this.degree = degree;
        }

        public IResult[] Execute(IInstance[] instances, ITimes times)
        {
            return
                instances
                    .AsParallel()
                    .WithDegreeOfParallelism(this.degree)
                    .Select(Parallelism.CreateCallback(times))
                    .ToArray();
        }

        private static Func<IInstance, IResult> CreateCallback(ITimes times)
        {
            return instance => instance.Execute(times);
        }
    }
}
