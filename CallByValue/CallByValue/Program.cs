using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    class Program
    {
        static void Display(ref int a,ref int b)
        {
            int c = a + b;
            a += 5;
            b += 5;
        }
        static void Display(int x,int y)
        {
            x += 5;
            y += 5;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Display(ref a, ref b);
            Console.WriteLine("Values of a & b are " + a + " " + b);
            Display(a, b);
            Console.WriteLine("Values of a & b are " + a + " " + b);
            
            Console.ReadKey();

        }
    }
}
