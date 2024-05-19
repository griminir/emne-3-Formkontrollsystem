using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Formkontrollsystem
{
    internal class Triangle : Shape
    {
        public override decimal Areal { get; protected set; }
        public decimal B { get; private set; }
        public decimal Height { get; private set; }

        public Triangle(string name, string color, decimal height, decimal b) : base(name, color)
        {
            Height = height;
            B = b;
            Areal = BeregnAreal();
        }

        protected override decimal BeregnAreal()
        {
            return (Height * B) / 2;
        }
    }
}
