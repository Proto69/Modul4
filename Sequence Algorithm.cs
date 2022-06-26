using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 1, 1, 1, 1, 5, 4, 3, 2, 1, 1 };
            Func<int, int, bool> function = (a, b) => a == b;
            Console.WriteLine(FindLongestSequence(list, function));
        }

        private static string FindLongestSequence(List<int> list, Func<int, int, bool> function)
        {
            var maxSequence = new List<int>();
            var currentSequence = new List<int>();

            currentSequence.Add(list.First());

            for (int i = 1; i < list.Count; i++)
            {
                if (function.Invoke(currentSequence.Last(),list[i]))
                {
                    currentSequence.Add(list[i]);

                    if (currentSequence.Count > maxSequence.Count)
                    {
                        maxSequence.Clear();
                        maxSequence.AddRange(currentSequence);
                    }
                }
                else
                {
                    currentSequence.Clear();
                    currentSequence.Add(list[i]);
                }
            }
            return string.Join(", ", maxSequence);
        }
    }
}