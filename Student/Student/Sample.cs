using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Sample
    {
        int no = 0;
        public static int count = 0;
        public Sample()
        {
            no++;
            count++;
            Console.WriteLine("No:{0}\nCount:{1}", no, count);
        }
        public static string dp()
        {
            Console.WriteLine(count);
            return string.Format("Welcome my dear Durga Prasad");
        }
    }
}
