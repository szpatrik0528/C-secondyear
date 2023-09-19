using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidegburkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a szoba szélességét méterbe: ");
            double szobaSzelesseg = double.Parse(Console.ReadLine());

            Console.WriteLine("Kérlek add meg a szoba husszúságát méterbe: ");
            double szobaHosszusag = double.Parse(Console.ReadLine());

            double alapterulet = szobaSzelesseg * szobaHosszusag;
            double oldalfalTerulet = 1.5 * (alapterulet);
            double teljesTerulet = alapterulet + oldalfalTerulet;

            double egyCsomagTerulet = 1.44;
            double csomagSzukseges = (teljesTerulet / egyCsomagTerulet);

            Console.WriteLine("Teljes felület: " + teljesTerulet + " m2");
            Console.WriteLine("Szükséges csempék száma: " + Math.Ceiling(csomagSzukseges) + " csomag kell.");

            Console.ReadKey();
        }
    }
}
