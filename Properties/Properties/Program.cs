using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Dp d = new Dp();
            d.A = int.Parse(Console.ReadLine());
            d.b = int.Parse(Console.ReadLine());
            a = d.A;
            b = d.B;
            Console.WriteLine("a:{0} & b:{1}",a,b);
            Console.WriteLine("Sum is:"+(a + b));
            Console.WriteLine("Product is:" + (a * b));
            Console.ReadKey();

        }
    }
}
