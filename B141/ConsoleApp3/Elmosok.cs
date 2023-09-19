using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Elmosok
    {
        public string Nev;
        public string faj;
        public int labszam;
        public double suly;
        public string nem;
        string hang;

        public String getHangotAd()
        {
            return hang;
        }

        public void setHangotAd(string hang)
        {
            this.hang = hang;
        }

        public String halad()
        {
            return "előre";
        }

        public override string ToString()
        {
            return this.Nev;
        }

        public Elmosok(string Nev ,string faj, int labszam, double suly, string nem, string hang)
        {
            this.Nev = Nev;
            this.faj = faj;
            this.labszam = labszam;
            this.suly = suly;
            this.nem = nem;
            this.hang = hang;
        }

    }
}
