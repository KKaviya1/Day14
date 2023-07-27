using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    class Shape
    {
        public string ShapeType { get; protected set; }

        public virtual double Area { get; }
        public virtual double Perimeter { get; }
    }
}
