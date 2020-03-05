using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)

        {
            Func<double, double, double> func = new Func<double, double, double>(CalAreaRectangle);
           
            double length,breadth,bas,height;
            Console.WriteLine("Enter length and breadth of Rectangle:");
            length = double.Parse(Console.ReadLine());
            breadth= double.Parse(Console.ReadLine());
            Console.WriteLine("\nArea of Rectangle using defined Func delegate:\n");
            Console.WriteLine(func(length,breadth));

            func += new Func<double, double, double>(CalAreaTriangle);

            Console.WriteLine("\nEnter height and base of Triangle:");
            height = double.Parse(Console.ReadLine());
            bas = double.Parse(Console.ReadLine());
            Console.WriteLine("\nArea of Triangle using defined incremental Func:\n");
            Console.WriteLine(func(height,bas));

            Console.ReadKey();
        }

        static double CalAreaRectangle(double length,double breadth)

        {

            return length * breadth;

        }

        static double CalAreaTriangle(double height,double bas)
        {

            return 0.5 * height * bas;

        }
    }
}
