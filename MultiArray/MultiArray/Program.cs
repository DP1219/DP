using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c, i = 0, j = 0;
            Console.WriteLine("Enter row size:");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter coloumn size:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] arr = new int[r, c];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    arr[i,j]=int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Given Matrix:");
            Console.WriteLine();
            for (i=0;i<r;i++)
            {
                for(j=0;j<c;j++)
                {
                    Console.Write("  " + arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
