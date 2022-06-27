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

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > m)
                throw new Exception("No solution");
            var queue = new Queue<int>();
            var stack = new Stack<int>();
            stack.Push(m);
            while (n != m)
            {
                if (m % 2 == 0 && m / 2 >= n)
                {
                    m /= 2;
                    stack.Push(m);
                }
                else if (m - 2 >= n)
                {
                    m -= 2;
                    stack.Push(m);
                }
                else if (m - 1 >= n)
                {
                    m -= 1;
                    stack.Push(m);
                }
            }
            Console.WriteLine(string.Join(" -> ", stack));
        }
    }
}
