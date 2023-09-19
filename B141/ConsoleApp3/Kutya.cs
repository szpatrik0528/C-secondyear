using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Kutya : Elmosok
    {
        public Kutya(string Nev, double suly, string nem) : base(Nev,"kutya", 4, suly, nem, "wauwau")
        {
        }
    }
}
