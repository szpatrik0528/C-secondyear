using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Berek2020_Feladat
{
    internal class Program
    {
        static List<Berek> adatok = new List<Berek>();
        private static string bekertReszleg;

        static void Main(string[] args)
        {
            adatokBeolvasasa();
            feladatok3();
            feladatok4();
            feladatok5();
            feladatok6();
            feladatok7();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladatok7()
        {
            Console.WriteLine("7. feladat: ");
            adatok.GroupBy(x => x.Részleg1).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()} fő"));
        }

        private static void feladatok6()
        {
            try
            {
                int index = adatok.IndexOf(adatok.Where(x => x.Részleg1 == bekertReszleg).OrderByDescending(x => x.Bér1).First());
                Console.WriteLine("6. Feladat: A legtöbbet kereső dolgozó a megadott részlegen");
                Console.WriteLine($"\tNév: {adatok[index].Név1}");
                Console.WriteLine($"\tNem: {adatok[index].Neme1}");
                Console.WriteLine($"\tBelépés: {adatok[index].Belépés1}");
                Console.WriteLine($"\tBér: {adatok[index].Bér1:### ###} Forint");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("6. Feladat: A megadott részleg nem létezik a cégnél!");
            }
        }



        private static void feladatok5()
        {
            Console.Write("5. feladat  ");
            bekertReszleg = Console.ReadLine();

        }

        private static void feladatok4()
        {
            Console.WriteLine($"4. Feladat: Bérek átlaga: ");
            Console.WriteLine($"\t{(double)adatok.Average(x => x.Bér1) / 1000:00.0} eFt");
        }

        private static void feladatok3()
        {
            Console.WriteLine("Ez a 3. feladat.");
            Console.WriteLine($"\t{adatok.Count} fő.");
        }

        private static void adatokBeolvasasa()
        {
            try
            {
                using (StreamReader file = new StreamReader("berek2020.txt"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {   
                        adatok.Add(new Berek(file.ReadLine()));
                        Console.WriteLine();
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
