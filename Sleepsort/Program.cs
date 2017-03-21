using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sleepsort
{
    static class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] source = new int[10];
            for (int i = 0; i < 10; i++)
            {
                source[i] = rand.Next(100);
            }

            int[] output = source.sleepSort();

            foreach (var i in output)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        private static int[] sleepSort(this int[] source)
        {
            List<int> output = new List<int>();
            Console.WriteLine("Sorting...");
            Parallel.ForEach(source, number =>
            {
                Thread.Sleep(100 * number);
                output.Add(number);
            });
            Console.WriteLine("Sorted!");
            return output.ToArray();
        }
    }
}
