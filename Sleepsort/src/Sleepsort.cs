using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sleepsort
{
    public class Sleepsort
    {
        public int[] TplSort(IEnumerable<int> source)
        {
            var fixedSource = source.ToArray();
            List<int> output = new List<int>(fixedSource.Length);
            Parallel.ForEach(fixedSource, number =>
            {
                Thread.Sleep(100 * number);
                output.Add(number);
            });
            return output.ToArray();
        }

        public int[] PlinqSort(IEnumerable<int> source)
        {
            var fixedSource = source.ToArray();
            List<int> output = new List<int>(fixedSource.Length);
            fixedSource.AsParallel()
                .WithDegreeOfParallelism(fixedSource.Length)
                .ForAll(number =>
                {
                    Thread.Sleep(100 * number);
                    output.Add(number);
                }
                );
            return output.ToArray();
        }
    }
}
