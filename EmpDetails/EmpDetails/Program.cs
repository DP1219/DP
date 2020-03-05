using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            int Empid, sal;
            string Empname;
            Console.WriteLine("Enter the Employee Details:");
            Empid = int.Parse(Console.ReadLine());
            sal = int.Parse(Console.ReadLine());
            Empname = Console.ReadLine();
            Console.WriteLine("Employee Details you have entered:");
            Console.WriteLine("Employee id:{0}",Empid);
            Console.WriteLine("Employee Name:{1}",Empname);
            Console.WriteLine("Employee salary:{2}",sal);
            Console.ReadLine();
        }
    }
}
