using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            // két szám bekérése és összeadás

            a = szamotKer("Adj meg egy számot: ");
            b = szamotKer("Adj meg egy számot: " );

            
            Console.WriteLine("A két szám összege: " + (a + b).ToString());
            

            Console.ReadLine();
        }

        private static int szamotKer(string szoveg)
        {
            int bekertSzam;
            Console.Write(szoveg);
            bekertSzam = int.Parse(Console.ReadLine());
            return bekertSzam;

        }
    }
}
