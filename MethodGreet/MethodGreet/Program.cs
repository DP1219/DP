using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodGreet
{
    class Program
    {
        static void Greet(string msg)
        {
            Console.WriteLine("Welcome Mr.{0} ",msg);
        }
        static void Main(string[] args)
        {
            Greet("DP");
        }
    }
}
