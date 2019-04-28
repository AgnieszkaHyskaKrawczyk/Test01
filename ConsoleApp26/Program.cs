using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            try
            {
                double vysledek = kalkulacka.Vydel(x, y);
                Console.WriteLine(vysledek);
            } catch (Exception e)
            {

            }
        }
    }
}
