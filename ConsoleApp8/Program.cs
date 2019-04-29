using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static int Sum(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * Sum(a - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(6));
            Console.ReadKey();
        }
    }
}
