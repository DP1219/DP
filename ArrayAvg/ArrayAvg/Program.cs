using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAvg
{
    class Program
    {
         static double Avg(int[] num)
        {
            double s,t;
            t = num.Sum();
            s = t / num.Length;
            return s;
        }
            static void Main(string[] args)
        {
            int[] num = new int[5];
            double f;
            int i = 0;
            Console.WriteLine("Enter numbers:");
            while (i < num.Length)
            {
                num[i] = int.Parse(Console.ReadLine());
                i++;
            }
            f = Avg(num);
            Console.WriteLine("Array Average:{0}", f);
            Console.ReadKey();
        }
    }
}
