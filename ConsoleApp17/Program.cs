using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public abstract class MobilniZarizeni 
    {
        public string VyrobniKod; 

        public abstract void Spustit(); 

        public string OperacniSystem;
    }

    public class Smartphone : MobilniZarizeni, IUmiFotit, IUmiCist
    {

        public Smartphone(string kod, string os)
        {
            VyrobniKod = kod; 
            OperacniSystem = os;
        }

        public override void Spustit()
        {
            Console.WriteLine("spoustim smartphone");
        }

        public void UdelejFotku(string fotka)
        {
            Console.WriteLine("delam fotku {0}", fotka);
        }

        public void PrectiOtisk(string otisk, bool vysledek)
        {
            Console.WriteLine("Ctu {0} a je v poradku {1}", otisk, vysledek);
        }

        void IUmiCist.NahrajOtisk(string notisk)
        {
            throw new NotImplementedException();
        }

        void IUmiCist.PrectiOtisk(string otisk, bool vysledek)
        {
            throw new NotImplementedException();
        }
    }

    public class Tablet : MobilniZarizeni, IUmiFotit
    {
        public Tablet(string kod, string os)
        {
            VyrobniKod = kod;
            OperacniSystem = os;
        }

        public override void Spustit()
        {
            Console.WriteLine("spoustim tablet");
        }

        public void UdelejFotku(string fotka)
        {
            Console.WriteLine("delam fotku {0}", fotka);
        }
    }

    public class Notebook : MobilniZarizeni, IUmiCist
    {
        public Notebook(string kod, string os)
        {
            VyrobniKod = kod;
            OperacniSystem = os;
        }

        public override void Spustit()
        {
            Console.WriteLine("spoustim notebook");
        }

        public void PrectiOtisk(string otisk, bool vysledek)
        {
            Console.WriteLine("Ctu {0} a je v poradku {1}", otisk, vysledek);
        }

        void IUmiCist.NahrajOtisk(string notisk)
        {
            throw new NotImplementedException();
        }

        void IUmiCist.PrectiOtisk(string otisk, bool vysledek)
        {
            throw new NotImplementedException();
        }
    }

    interface IUmiFotit
    {
        void UdelejFotku(string fotka);
    }

    interface IUmiCist
    {
        void NahrajOtisk(string notisk);
        void PrectiOtisk(string otisk, bool vysledek);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("1234", "Android");
            Tablet tablet = new Tablet("3456", "iOS");
            Notebook notebook = new Notebook("6789", "Windows");

            var zarizeni = new List<MobilniZarizeni>()
            {
                smartphone,
                tablet,
                notebook
            };

            foreach (MobilniZarizeni item in zarizeni)
            {
                item.Spustit();
                if (item is Smartphone) 
                {
                    Smartphone smartphoneA = (Smartphone)item; 
                    Console.WriteLine("Kod {0} a operacni system {1}", smartphoneA.VyrobniKod, smartphoneA.OperacniSystem);
                    smartphoneA.PrectiOtisk("otisk", true); 
                }

            }

            Console.ReadKey();
        }
    }
}
   
