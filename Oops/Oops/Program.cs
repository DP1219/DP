using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTrObj();
            GetTr1Obj();
            Console.ReadKey();
        }

        private static void GetTr1Obj()
        {
            Trainee t1 = new Trainee();
            t1.GetDetails("Anil", "844920", "Vijayawada", 22);
            t1.ShowDetails();
        }

        private static void GetTrObj()
        {
            Trainee t = new Trainee();
            t.GetDetails("Dp", "844918", "Rajahmundry", 22);
            t.ShowDetails();
        }
    }
}
