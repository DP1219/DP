using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class C
    {
       public C(int a, int b)
        {
            Console.WriteLine("product of a and b is:" + (a * b));
        }
    }
}

    namespace Test
{
    partial  class C
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition of a and b is:"+(a+b));
        

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Demo.C ob = new Demo.C(6,9);
            Console.WriteLine();
            C c = new C();
            c.Add(4, 5);
            Console.ReadKey();
        }
    }
}
