using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    struct Demo
    {
        int no1, no2;
        public Demo(int no1, int no2)
        {
            this.no1 = no1;
            this.no2 = no2;
        }
        public void DisplayData()
        {
            Console.WriteLine(no1 + "  " + no2);
        }
        public static Demo operator +(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no1 = x.no1 + y.no1;
            t.no2 = x.no2 + y.no2;
            return t;
        }
        public static Demo operator *(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no1 = x.no1 * y.no1;
            t.no2 = x.no2 * y.no2;
            return t;
        }
        public static Demo operator -(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no1 = x.no1 - y.no1;
            t.no2 = x.no2 - y.no2;
            return t;
        }
    }
}
