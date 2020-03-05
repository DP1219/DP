using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADODOTNET
{
    class Program
    {
        static void Main(string[] args)
        {
            // geTDADA();

            DataLayer d = new DataLayer();
            d.show();

            Console.ReadKey();
        }

        private static void geTDADA()
        {
            Aggregation a = new Aggregation();
            int ch;
            do
            {
                Console.WriteLine("\n1.Insert\t2.Display\t3.Update\t4.Exit\n");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: a.Insert(); break;
                    case 2: a.Display(); break;
                    case 3: a.update(); break;
                }
            } while (ch <= 3);
        }
    }
}
