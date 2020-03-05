using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emp = new string[6];
            string[] n = new string[6];
            
            int i = 0;
            while(i<emp.Length)
            {
                Console.Write("Enter name{0}:",i);
                emp[i] = Console.ReadLine();
                Console.Write("   Enter ID{0}:",i);
                n[i] = (Console.ReadLine());
                i++;
            }
            i = 0;
            while(i<emp.Length)
            {
                Console.WriteLine("Employee Name:"+emp[i]+" & ID:"+n[i]);
                i++;
            }
            Console.ReadKey();
        }
    }
}
