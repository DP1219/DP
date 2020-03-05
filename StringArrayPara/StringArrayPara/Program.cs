using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayPara
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a Long Statement to split");
            str = Console.ReadLine();
            Spilt s = new Spilt();
            string[] str1=s.geTString(str);
            foreach(string str2 in str1)
            {
                Console.WriteLine("\n"+str2);
            }
            // geTFirstLast();
            // geTParaStr();
            Console.ReadKey();


        }

        private static void geTFirstLast()
        {
            string fn, ln;
            Console.WriteLine("Enter the First Name:");
            fn = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            ln = Console.ReadLine();
            FirstLast fl = new FirstLast();
            Console.WriteLine(fl.show(fn, ln));
        }

        private static void geTParaStr()
        {
            StringPara sp = new StringPara();
            string[] array = { "My", "Name","Durga","Prasad" };
            string res = sp.show(array);
            Console.WriteLine(res);
        }
    }
}
