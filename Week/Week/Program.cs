using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week
{
    class Program
    {
        enum Week
        {
            sunday=0,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Value of sunday     :{0}", (int)Week.sunday);
            Console.WriteLine("Value of monday     :{0}", (int)Week.monday);
            Console.WriteLine("Value of tuesday    :{0}", (int)Week.tuesday);
            Console.WriteLine("Value of wednesday  :{0}", (int)Week.wednesday);
            Console.WriteLine("Value of thursday   :{0}", (int)Week.thursday);
            Console.WriteLine("Value of friday     :{0}", (int)Week.friday);
            Console.WriteLine("Value of saturday   :{0}", (int)Week.saturday);
            Console.ReadKey();
        }
    }
}
