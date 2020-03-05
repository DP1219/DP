using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int i = 0;
            Console.WriteLine("Enter numbers:");
            while(i<num.Length)
            {
                num[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Array.Sort(num);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Sorting:");
            i = 0;
            while (i < num.Length)
            {
                Console.Write("  {0}", num[i]);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Highest Number: " + num.Max());
            Console.WriteLine();
            Console.WriteLine("Lowest Number: " + num.Min());
            Console.WriteLine();
            Console.WriteLine("Array Sum: "+num.Sum());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
