using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_Formkontrollsystem
{
    public abstract class Shape
    {
        public string Name { get; protected set; }
        public string Color { get; protected set; }

        public abstract decimal Areal { get; protected set; }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        protected abstract decimal BeregnAreal();
    }
}
