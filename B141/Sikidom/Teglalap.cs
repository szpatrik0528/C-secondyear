using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Teglalap : Sikidom
    {
        readonly double aoldal;
        readonly double boldal;
        public Teglalap(double aoldal, double boldal) : base("Téglalap")
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
        }

        public double Aoldal { get => aoldal; }
        public double Boldal { get => boldal; }

        public override double Kerulet()
        {
            return (Aoldal + Boldal) * 2;
        }

        public override double Terulet()
        {
            return (Aoldal * Boldal);
        }
    }
}
