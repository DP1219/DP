using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            short s = 359;
            int n = 999;
            uint m = 99999;
            long l = 547345735;
            float f = 122.56f;
            double d = 54365476.3452;
            decimal m1 = 56457325.7631612m;
            DateTime dt = DateTime.Now;
            Console.WriteLine("The Value of byte:{0}",b);
            Console.WriteLine("The Value of short:{0}",s);
            Console.WriteLine("The Value of int:{0}",n);
            Console.WriteLine("The Value of uint:{0}",m);
            Console.WriteLine("The Value of long:{0}",l);
            Console.WriteLine("The Value of float:{0}",f);
            Console.WriteLine("The Value of double:{0}",d);
            Console.WriteLine("The Value of decimal:{0}",m1);
            Console.WriteLine("Today's Date:{0}",dt);
            Console.WriteLine("Today's Date:{0}",dt.ToShortDateString);
            Console.WriteLine("Today's Date:{0}",dt.ToLongDateString);
            Console.ReadKey();
        }
    }
}
