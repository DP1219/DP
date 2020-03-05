using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropSum
{
    public class Sum
    {
        int A;
        int B;

        public sum(int a,int b)
        {
            A = a;
            B = b;
            Console.WriteLine("Sum is:" + (A + B));
        }

        public int x
        {
            get
            {
                return A;
            }
            set
            {
                A = value;
            }
        }

        public int y
        {
            get
            {
                return B;
            }

            set
            {
                B = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sum item = new Sum();
            item.sum(5, 5);
            Console.ReadKey();
        }
    }
}
