using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace delhi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(); // While giving Inputs Make Sure that Strings should
                                    // be given Either in Lower or Upper But not Combination

            s.Push("madam");
            s.Push("teacher");
            s.Push("malayalam");
            s.Push("doctor");
            s.Push("telugu");
            s.Push("level");
            Console.WriteLine("Given Stack Strings:\n");
            foreach (string st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("\nPalindromic Words:\n");
            foreach (string st in s)
             {
                char[] word1 = st.ToCharArray();
                Array.Reverse(word1);
                string word2 = new string(word1);
                
                if (word2.Equals(st))
                {
                    Console.WriteLine(st);
                }

            }
            Console.ReadKey();

        }

    }
}
