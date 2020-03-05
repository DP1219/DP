using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMat
{
    class Program
    {
        static int[,] Add(int[,] arr,int r,int c)
        {
            int[,] result = new int[r, c];
            int i, j;
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    result[i, j] = arr[i, j] + arr[i, j];

                }
            }
            return result;

        }
        static void Main(string[] args)
        {
            int r, c, i, j;
            Console.WriteLine("Enter size of identity Matrix:");
            r = int.Parse(Console.ReadLine());
            c = r;
            Console.WriteLine();
            int[,] arr = new int[r, c];
            int[,] arr1 = new int[r, c];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    if(i==j)
                    {
                        arr[i, j] = 1;
                    }
                }
            }
            Console.WriteLine("Desired Identity Matrix:");
            Console.WriteLine();
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("  " + arr[i, j]);
                }
                Console.WriteLine();
            }
            arr1 = Add(arr, r, c);
            Console.WriteLine();
            Console.WriteLine("Addition of given  Identity matrix:");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("  " + arr1[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
