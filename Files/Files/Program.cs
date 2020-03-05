using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // geTFIleOperations();
            // geTArrayPgrm();
            // geTQuesn16();
            // geTCircleString_LAMDA();

        }

        private static void geTCircleString_LAMDA()
        {
            Circle c = new Circle();
            Console.Write("Enter radius:");
            double d = double.Parse(Console.ReadLine());
            Console.Write("\nCircumference:");
            Console.WriteLine(c.calculate(r => 2 * Math.PI * d));
            Console.WriteLine();
            Console.Write("Area:");
            Console.WriteLine(c.calculate(r => Math.PI * d * d));
            Console.Write("\nEnter String in Lower Case:");
            string s = Console.ReadLine();
            Console.Write("\nUpper Case:");
            Console.WriteLine(c.change(a => s.ToUpper()));
            Console.Write("\nEnter String in Upper Case:");
            string t = Console.ReadLine();
            Console.Write("\nLower Case:");
            Console.WriteLine(c.change(q => t.ToLower()));
            Console.ReadKey();
        }

        private static void geTQuesn16()
        {
            Console.WriteLine("Enter base & height to find Area");
            Console.Write("Base:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("height:");
            double h = double.Parse(Console.ReadLine());
            Func<double, double, double> Area = (x, y) => (0.5 * x * y);
            Console.WriteLine("Area of Triangle:" + Area(b, h));
            Console.ReadKey();
        }

        private static void geTArrayPgrm()
        {
            ArrayDp dp = new ArrayDp();
            dp.CreateArray();
        }

        private static void geTFIleOperations()
        {
            string path = @"D:\DP\FIleC#\dp.txt";
            FileOperation rw = new FileOperation();
            int op;
            do
            {
                Console.WriteLine("\n1.CreateFile\t2.Display\t3.AddtoFile\t4.Delete\t5.Quit\n");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: rw.CreateFile(path); break;
                    case 2: rw.Display(path); break;
                    case 3: rw.AddToFile(path); break;
                    case 4: rw.Delete(path); break;

                }
            } while (op <= 4);
        }
    }
}

                
         
   
