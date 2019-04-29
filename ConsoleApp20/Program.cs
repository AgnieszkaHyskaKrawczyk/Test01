using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    abstract class Hodiny
    {
        public DateTime Cas;
        
        public abstract void NastavCas(string casH, string casM, string casV);

        public virtual string ZobrazAktualniCas(string aktualniCas)
        {
            return aktualniCas;
        }

    }
    class RucickoveHodiny : Hodiny, IHodinyNaBaterky
    {
        public override void NastavCas(string casH, string casM, string casV)
        {
            Console.WriteLine("Input: " + casH + " hodin " + casM + " minut " + casV + " vterin");
        }
        public override string ZobrazAktualniCas(string aktualniCas)
        {
            return base.ZobrazAktualniCas(aktualniCas);
        }
        /*public RucickoveHodiny(TypBaterky t, int pocet)
        {

        }*/
        void IHodinyNaBaterky.VymenBaterky()
        {
            Console.WriteLine("Vymena Baterek. Typ: {0}. Pocet: {1}", _typBaterky, PocetBaterek);
        }

        TypBaterky _typBaterky;
        public TypBaterky TypBaterky 
        {
            get { return this._typBaterky; }
            set { this._typBaterky = value; }
        }

        public int PocetBaterek 
        {
            get;
            set;
        }
        /*public static TypBaterky TypBaterek { get; internal set; }

        internal void VymenBaterky()
        {
           
        }*/
    }
    class JednoduheDigitalniHodiny : Hodiny
    {
        public override void NastavCas(string casH, string casM, string casV)
        {
            Console.WriteLine("Input: " + casH + casM);
        }

        public override string ZobrazAktualniCas(string aktualniCas)
        {
            return base.ZobrazAktualniCas(aktualniCas);
        }
    }
    class DigitalniHodiny : JednoduheDigitalniHodiny, IHodinyNaBaterky
    {
        public override void NastavCas(string casH, string casM, string casV)
        {
            Console.WriteLine("Input: " + casH + ":" + casM + ":" + casV);
        }

        public override string ZobrazAktualniCas(string aktualniCas)
        {
            return base.ZobrazAktualniCas(aktualniCas);
        }
        void IHodinyNaBaterky.VymenBaterky()
        {
            Console.WriteLine("Vymena Baterek. Typ: {0}. Pocet: {1}", _typBaterky, PocetBaterek);
        }
        TypBaterky _typBaterky;
        public TypBaterky TypBaterky
        {
            get { return this._typBaterky; }
            set { this._typBaterky = value; }
        }

        public int PocetBaterek
        {
            get;
            set;
        }
    }
    enum TypBaterky { AAA, AA };

    interface IHodinyNaBaterky
    {
        TypBaterky TypBaterky { get; set; } 
        int PocetBaterek { get; set; } 
        void VymenBaterky();
    }

    class Program
    {
        static void UdrzbaHodin(List<Hodiny> hodiny)
        {
            Console.WriteLine("Baterky ");
        }
        static void Main(string[] args)
        {
            string c = "10:24:15";

            RucickoveHodiny rucickove = new RucickoveHodiny();
            rucickove.Cas = DateTime.Parse(c);
            IHodinyNaBaterky hodinyNaBaterky = new RucickoveHodiny();
            hodinyNaBaterky.TypBaterky = TypBaterky.AA;
            hodinyNaBaterky.PocetBaterek = 3;
            hodinyNaBaterky.VymenBaterky();

            Hodiny jednoduhe = new JednoduheDigitalniHodiny();
            jednoduhe.Cas = DateTime.Parse(c);

            Hodiny digitalni = new DigitalniHodiny();
            digitalni.Cas = DateTime.Parse(c);
            IHodinyNaBaterky hodinyNaBaterky1 = new DigitalniHodiny();
            hodinyNaBaterky1.TypBaterky = TypBaterky.AAA;
            hodinyNaBaterky1.PocetBaterek = 1;
            hodinyNaBaterky1.VymenBaterky();

            var hodinarstvi = new List<Hodiny>()
            {
                rucickove,
                jednoduhe,
                digitalni
            };

            foreach (Hodiny item in hodinarstvi)
            {
                item.NastavCas("10", "24", "15");
                
                if (item is RucickoveHodiny)
                {
                    RucickoveHodiny rh = (RucickoveHodiny)item;
                    string aktualniCasH = item.Cas.ToString("HH");
                    string aktualniCasM = item.Cas.ToString("mm");
                    string aktualniCasV = item.Cas.ToString("ss");
                    Console.WriteLine("Output: malá ručička na " + rh.ZobrazAktualniCas(aktualniCasH) + ", velká ručička na " + rh.ZobrazAktualniCas(aktualniCasM) + " a vteřinová na " + rh.ZobrazAktualniCas(aktualniCasV));

                }
                else
                {
                    string aktualniCas = item.Cas.ToLongTimeString();
                    string aC = item.ZobrazAktualniCas(aktualniCas);
                    Console.WriteLine("Output: " + aC);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
