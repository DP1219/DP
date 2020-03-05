using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class MathException
    {
        public int A
        {
            get;set;
        }
        public int B
        {
            get; set;
        }
        public void show()
        {
            int c;
            try
            {
                if (B==0)
                {
                    throw new ArithmeticException();
                }
                else
                {
                    c = A / B;
                    Console.WriteLine("Division Can be Performed    "+c);
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Division cannot be performed"+e);
            }
            finally
            {
                Console.WriteLine("THis is executed");
            }
        }
    }
}
