using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaFibonacci(0, 1, 1, 40);
            Console.ReadKey();
        }
        private static void CalculaFibonacci(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                CalculaFibonacci(b, a + b, counter + 1, len++);
            }
        }

    }
}
