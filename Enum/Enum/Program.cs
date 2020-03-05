using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Department
        {
            physics=10,
            mathematics =15,
            biology,
            se=20
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Department of mathematics:{0}", (int)Department.mathematics);
            Console.ReadKey();
        }
    }
}
