using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program

    { 

        static StudentContext sc = new StudentContext();
        static void Main(string[] args)
        {
            
            Insert();
            Display();
            Console.ReadKey();
        }

        private static void Insert()
        {
            Console.WriteLine("enter full name of stuent");
            string name = Console.ReadLine();
            var students = new Student
            {
                FullName = name
            };
            sc.Students.Add(students);
            sc.SaveChanges();
        }

        private static void Display()
        {
            var students = sc.Students;
            foreach (var s in students)
            {
                Console.WriteLine("{0} \t{1}", s.Sid, s.FullName);
            }
        }
    }
}
