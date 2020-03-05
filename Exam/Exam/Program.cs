using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exam e = new Exam();
            e.Details("DP", "1219", 87, 78, 69, 78, 87, 85);
            e.Display();
            Console.WriteLine();
            Console.WriteLine();
            Exam e1 = new Exam();
            e.Details("Anil", "1220", 65, 65, 69, 48, 87, 85);
            e.Display();
            Console.ReadKey();*/
            string s, s1;
            Car c = new Car("AP05CQ7777");
            Car c1 = new Car("AP05CQ7777","Eritga","Red",1200000);
            s = c.Display();
            Console.WriteLine(s);
            Console.WriteLine();
            s1 = c1.Display();
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}
