using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Math :MathProp,IMathOp
    {
        public void Add(int a, int b)
        {
            A = a;
            B = b;
            Console.WriteLine(A + B);
        }

        public void Mul(int a, int b)
        {
            A = a;
            B = b;
            Console.WriteLine(A * B);
        }
    }
}
