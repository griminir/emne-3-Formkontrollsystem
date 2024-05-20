using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Formkontrollsystem
{
    internal class Circle : Shape
    {
        public decimal Radius { get; private set; }

        public Circle(string name, string color, decimal radius) : base(name, color)
        {
            Radius = radius;
            Areal = BeregnAreal();
        }
        protected override decimal BeregnAreal()
        {
            return 3.14M * (Radius * Radius);
        }
    }
}
