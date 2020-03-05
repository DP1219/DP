using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   
    class Input 
    {
        int a, b;
        public Input(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class Mul:Input
    {
        public void sum()
        {
            return 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Input i = new Input(8, 9);
            Console.WriteLine(i.sum());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
