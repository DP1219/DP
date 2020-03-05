using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(geTNumbers);
            Thread th = new Thread(tsd);

            ThreadStart td= new ThreadStart(geTEvenNumbers);
            Thread t = new Thread(td);
            t.Start();
            th.Start();
            Console.ReadKey();
        }
        public static void geTNumbers()
        {
            for(int i=1;i<=10;i++)
            {
                Console.Write(i+"\t");
                Thread.Sleep(1000);
            }
        }
        public static void geTEvenNumbers()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "\t");
                    Thread.Sleep(800);
                }
            }
        }
    }
}
