using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Exam
    {
        string StudName, StudId;
        int m1, m2, m3, C,DBMS, Java;
        double Avg;
        public void Details(string name,string id,int m1,int m2,int m3,int C,int DBMS,int Java)
        {
            double sum;
            StudName = name;
            StudId = id;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.C = C;
            this.DBMS = DBMS;
            this.Java = Java;
            sum = m1 + m2 + m3 + C + DBMS + Java;
            Avg = sum / 6;
        }
        public void Display()
        {
            Console.WriteLine("Student name:" + StudName);
            Console.WriteLine("Student ID:" + StudId);
            Console.WriteLine("Semester Average:" + Avg);
            if(Avg>70)
            {
                Console.WriteLine(StudName + "  got DISTINCTION");
            }
            else
            {
                Console.WriteLine(StudName + "  got A Grade");
            }
        }
    }
}
