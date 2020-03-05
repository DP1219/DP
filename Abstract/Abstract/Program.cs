using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // geTAbstractArea();
        }

        private static void geTAbstractArea()
        {
            Circle c = new Circle(14.0);
            Console.WriteLine("Area of Circle:" + c.Area());
            Console.ReadKey();
        }
    }
}
