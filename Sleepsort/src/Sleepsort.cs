using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Sleepsort
{
    public class Sleepsort
    {
        public int[] Sort(IEnumerable<int> source)
        {
            List<int> output = new List<int>();
            Parallel.ForEach(source, number =>
            {
                Thread.Sleep(100 * number);
                output.Add(number);
            });
            return output.ToArray();
        }
    }
}
