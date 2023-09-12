using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // két szám bekérése és összeadás

            Console.WriteLine("Adj meg két számot:");
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
