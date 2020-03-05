using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static StudentContext sc = new StudentContext();
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("1.Insert\t2.Remove\t3.Display\t4.Exit");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1: geTInsert();break;
                    case 2: getRemove();break;
                    case 3: geTDisplay();break;
                    
                }
            } while (op <= 3);
            Console.ReadKey();
        }

        private static void getRemove()
        {
            var st = sc.Students;
            sc.Students.RemoveRange(st);
            sc.SaveChanges();
        }

        private static void geTInsert()
        {
            Console.WriteLine("\nEnter How many records You want to Insert\n");
            int f = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= f; i++)
            {
                Console.WriteLine("\nEnter Name & Loaction Details for {0}:\n", i);
                var students = new Student1
                {

                    SName = Console.ReadLine(),
                    Location = Console.ReadLine()
                };
                sc.Students.Add(students);
                sc.SaveChanges();
            }
        }

        private static void geTDisplay()
        {
            var students = sc.Students;
            Console.WriteLine("\nSID\t\tSName\t\t\tLocation\n");
            foreach (var c in students)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c.SId, c.SName, c.Location);
                
            }
        }
    }
}
