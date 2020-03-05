using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "This is";
            Console.WriteLine(d+"\n");
            string a = d.Insert(7, " Durga Prasad. ");
            Console.WriteLine(a+"\n");
            string s = "I am from Rajahmundry";
            Console.WriteLine(String.Concat(a, s)+"\n");
            
            string up = s.ToUpper();
            Console.WriteLine(up+"\n");
            string lc = up.ToLower();
            Console.WriteLine(lc+"\n");
            string[] names = new string[] { "DP", "Anil", "Leela" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine("\n"+allnames + "\n");
            int l = allnames.Length;
            Console.WriteLine(l + "\n");
            string[] words = s.Split();
            foreach(string st1 in words)
            {
                Console.WriteLine(st1);
            }
            
            string st2 = "I am Working in Cognizant";
            string st3 = string.Copy(st2);
            Console.WriteLine(st3);
            Console.ReadKey();
         }
    }
}
