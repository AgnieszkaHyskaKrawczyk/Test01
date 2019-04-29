using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Clovek pepa = new Clovek();
            pepa.Vek = 20;
            Console.WriteLine(pepa.JePlnolety);

            Console.ReadKey();
        }
    }
    class Clovek
    {

        public bool JePlnolety { get; private set; }
        private int vek;
        public int Vek
        {
            get { return vek; }
            set
            {
                vek = value;
                if (vek >= 18)
                {
                    JePlnolety = true;
                }
                else
                {
                    JePlnolety = false;
                }
            }
        }
    }
}
