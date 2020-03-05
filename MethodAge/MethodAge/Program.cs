using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAge
{
    class Program
    {
         static string Age(string s,int n)
        {
            string msg = string.Format("Congratulations Mr."+s+" on your "+n+"nd Birth Anniversary");
            return msg;
        }
        static void Main(string[] args)
        {
            int n;
            string s;
            Console.WriteLine("Enter Number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            s = Console.ReadLine();
            Console.WriteLine(Age(s, n));
            Console.ReadKey();
        }
    }
}