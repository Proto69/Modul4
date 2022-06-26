using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list2 = new List<int> { 1, 2, 3, 4, 5 };
            var list = new List<int> { 2, 3, 6, 7, 4};
            Console.WriteLine(Sechenie(list, list2));
            Console.WriteLine(Obedinenie(list, list2));
        }

        private static string Sechenie(List<int> list1, List<int> list2)
        {
            var result = new List<int>();
            foreach (int number in list1)
            {
                if (list2.Contains(number)) result.Add(number);
            }
            return string.Join(", ", result);
        }

        private static string Obedinenie(List<int> list1, List<int> list2)
        {
            foreach (int number in list2)
            {
                if (!list1.Contains(number)) list1.Add(number);
            }
            return string.Join(", ", list1);
        }
    }
}
