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

        public int[] TaskSort(IEnumerable<int> source)
        {
            var fixedSource = source.ToArray();
            List<Task> tasks = new List<Task>(fixedSource.Length);
            List<int> output = new List<int>(fixedSource.Length);
            foreach(var number in source)
            {
                tasks.Add(Task.Run(() => { Thread.Sleep(100 * number); output.Add(number); }));
            }
            Task.WaitAll(tasks.ToArray());
            return output.ToArray();
        }
    }
}
