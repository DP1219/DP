using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Inwords i = new Inwords();
            Console.Write("Enter a number to find string Name:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            i.convertTo(num);
            Console.ReadKey();
        }
    }
}
