using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Circle
    {
        double rad;
        string s;
        public double calculate(Func<double,double>mp)
        {
            return mp(rad);
        }
        public string change(Func<string,string>c)
        {
            return c(s);
        }
    }
}
