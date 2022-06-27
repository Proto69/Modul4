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
            var queue = new Queue<int>();
            var list = new List<int>();

            int n = int.Parse(Console.ReadLine());
            list.Add(n);

            int j = 1;
            for (int i = 1; i <= 50; i++)
            {
                int s;
                switch (j)
                {
                    case 1:
                        s = n + 1;
                        queue.Enqueue(s);
                        list.Add(s);
                        break;
                    case 2:
                        s = 2 * n + 1;
                        queue.Enqueue(s);
                        list.Add(s);
                        break;
                    case 3:
                        s = n + 2;
                        queue.Enqueue(s);
                        list.Add(s);
                        break;
                    case 4:
                        n = queue.Dequeue();
                        j = 0;
                        break;
                }
                j++;
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
