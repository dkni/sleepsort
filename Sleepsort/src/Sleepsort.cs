using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Sleepsort
{
    public class Sleepsort
    {
        public int[] Sort(IEnumerable<int> source)
        {
            List<int> output = new List<int>();
            source.AsParallel().ForAll(number =>
            {
                Thread.Sleep(100 * number);
                output.Add(number);
            });
            return output.ToArray();
        }
    }
}
