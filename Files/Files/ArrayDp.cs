using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class ArrayDp
    {
        public void CreateArray()
        {
            int r, i, j = 0;
            Console.Write("Enter the size of array:");
            r = int.Parse(Console.ReadLine());
            int[] array = new int[r];
            int[] array1 = new int[r];
            Console.WriteLine("\nEnter array items");
            for (i=0;i<r;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nGiven Array list\n");
            for (i = 0; i < r; i++)
            {
                Console.Write(array[i] + "\t");
            }
            for (i = 0; i < r; i++)
            {
                if(array[i]==0)
                {
                    array1[j] = array[i];
                    j++;
                    
                }
            }
            for (i = 0; i < r; i++)
            {
                if (array[i]!=0 && array[i]!=1)
                {
                    array1[j] = array[i];
                    j++;
                 
                }
            }
            for(i = 0; i < r; i++)
            {
                if (array[i] == 1)
                {
                    array1[j] = array[i];
                    j++;
                   
                }
            }
            Console.WriteLine("\nYour desired Array:\n");
            for(i=0;i<r;i++)
            {
                Console.Write(array1[i] + "\t");
            }
            

        }
    }
}
