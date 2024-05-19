using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Formkontrollsystem
{
    internal class Rectangle : Shape
    {
        public override decimal Areal { get; protected set; }
        public decimal Width { get; private set; }
        public decimal Length { get; private set; }

        public Rectangle(string name, string color, decimal length, decimal width) : base(name, color)
        {
            Length = length;
            Width = width;
            Areal = BeregnAreal();
        }

        protected override decimal BeregnAreal()
        {
            return Width * Length;
        }
    }
}
