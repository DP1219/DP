using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Circle :Shape
    {
        public double rad;
        public Circle() { }
        public Circle(double rad)
        {
            this.rad = rad;
        }
        public override double Area()
        {
            return rad * rad * Math.PI;
        }
    }
}
