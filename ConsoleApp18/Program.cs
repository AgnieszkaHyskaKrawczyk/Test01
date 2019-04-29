using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon mobil = new Telefon();
            mobil.Spustit();
            Telefon mobil2 = new Telefon(OperacniSystem.Android);
            mobil2.Spustit();

            object x = 1;
            object slovo = "sdfg";
            object mobil3 = mobil;

            Console.WriteLine(x);
            Console.WriteLine(mobil);

            Console.ReadKey();
        }
    }
    abstract class MobilniZarizeeni
    {
        public OperacniSystem System;

        public MobilniZarizeni(OperacniSystem system)
        {
            System = system;
        }

        public virtual void Spustit()
        {
            Console.WriteLine("Spistim operacni system " + System);
        }
    }
    class Telefon : MobilniZarizeeni
    {
        public Telefon() : base(OperacniSystem.iOS)
        {

        }

        public Telefon(OperacniSystem system) : base(system)
        {
        }

        public override void Spustit()
        {
            base.Spustit();
            Console.WriteLine("Spustim telefon.");
        }
        public override string ToString()
        {
            //return base.ToString();
            return "Jsem" + System;
        }
    }
    enum OperacniSystem
    {
        Windows,
        iOS,
        Android
    }
}
