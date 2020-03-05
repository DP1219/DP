using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion
{
    class Inwords
    {
        
        public void convertTo(int num)
        {
            int r,rev=0;
            while(num>0)
            {
                r = num % 10;
                rev = rev * 10 + r;
                num = num / 10;
            }
            int r1;
            while(rev>0)
            {
                r1 = rev % 10;
                fan(r1);
                rev = rev / 10;
            }
        }

         public void fan(int r1)
        {
            switch (r1)
            {
                case 0: Console.Write("Zero  "); break;
                case 1: Console.Write("One  "); break;
                case 2: Console.Write("Two  "); break;
                case 3: Console.Write("Three  "); break;
                case 4: Console.Write("Four  "); break;
                case 5: Console.Write("Five  "); break;
                case 6: Console.Write("Six  "); break;
                case 7: Console.Write("Seven  "); break;
                case 8: Console.Write("Eight  "); break;
                case 9: Console.Write("Nine  "); break;
            }
        }
    }
}
