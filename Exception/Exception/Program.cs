using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            MathException m = new MathException { A = 8, B = 0 };
            m.show();
            Console.ReadKey();
        }
    }
}
