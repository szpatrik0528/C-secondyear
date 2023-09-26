using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    abstract class Sikidom
    {
        public string tipus;

        protected Sikidom(string tipus)
        {
            this.tipus = tipus;
        }
        abstract public double Terulet();
        abstract public double Kerulet();

        public override string ToString()
        {
            return tipus;
        }

    }
}
