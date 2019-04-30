using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Kalkulacka
    {
        public double Vydel(double a, double c)
        {
            if(c == 0)
                throw new Exception("Nelze delit 0!");
            return a / c;
        }
    }
}
