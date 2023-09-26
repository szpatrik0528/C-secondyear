using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Program
    {
        static List<Sikidom> sikidomok = new List<Sikidom>(); 
        static void Main(string[] args)
        {
            sikidomok.Add(new Kor(5));
            sikidomok.Add(new Kor(4.3));
            sikidomok.Add(new Negyzet(5));
            sikidomok.Add(new Teglalap(5,21));

            foreach (var item in sikidomok) 
            {
                if (item.GetType().Equals(typeof(Kor)))
                {
                    Kor kor = (Kor)item;
                    Console.WriteLine($"A kör Kerülete: {kor.Kerulet()} - Területe: {kor.Terulet()} - sugár: {kor.Sugar}");
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"A négyzet oldala: {negyzet.Oldal}");
                }else if (item.GetType().Equals(typeof(Teglalap)))
                {
                    Teglalap teglalap = (Teglalap)item;
                    Console.WriteLine($"A téglalap A oldal: {teglalap.Aoldal} - B oldal: {teglalap.Boldal}");
                }
                
            }



            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }
    }
}
