using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Elmosok> elmosoks = new List<Elmosok>();
            elmosoks.Add( new Macska("Cirmí",2.1, "kandur"));
            elmosoks.Add(new Kutya("Bodri",5.2, "kan"));
            elmosoks.Add(new Macska("Szerénke", 1.3, "nőstény"));
            foreach(var item in elmosoks)
            {
                Console.WriteLine($"{item} - {item.faj}");
            }
            

            Console.ReadKey();
        }
    }
}
