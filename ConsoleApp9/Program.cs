using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Zavodnik[] zavodnici = new Zavodnik[4];
            for(int i = 0; i < zavodnici.Length; i++)
            {
                Console.WriteLine("Zavodnik {0}", i+1);
                Console.WriteLine("Zadej jmeno:");
                string jmeno = Console.ReadLine();
                string vstup;
                int cas;
                do
                {
                    Console.WriteLine("Zadej cas:");
                    vstup = Console.ReadLine();
                }
                while (!int.TryParse(vstup, out cas));

                zavodnici[i] = new Zavodnik(jmeno, cas);
            }

            for (int i = 0; i < zavodnici.Length; i++)
            {
                Console.WriteLine("Zavodnik {0} ma as {1}", zavodnici[i].Jmeno, zavodnici[i].Cas);
            }
            Console.WriteLine("Zadej jmeno zavodnika:");
            string zadaneJmeno = Console.ReadLine();
            for (int i = 0; i < zavodnici.Length; i++)
            {
                if (zavodnici[i].Jmeno == zadaneJmeno)
                {
                    Console.WriteLine("Zavodnik {0} ma cas {1}", zadaneJmeno, zavodnici[i].Cas);
                    break;
                }
                else
                {
                    Console.WriteLine("Zavodnik {0} neeksistuje");
                    break;
                }
                
            }
            int nejlepsiCas = zavodnici[0].Cas;
            int indexNejZavodnika = 0;
            for (int i = 0; i < zavodnici.Length; i++)
            {
                if (zavodnici[i].Cas < nejlepsiCas)
                {
                    nejlepsiCas = zavodnici[i].Cas;
                    indexNejZavodnika = i;
                }
            }
            Console.WriteLine("Nejlepsi zavodnik {0} je s casem {1}", zavodnici[indexNejZavodnika].Jmeno, nejlepsiCas);
            Console.ReadKey();
         }
    }
}
