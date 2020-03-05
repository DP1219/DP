using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayPara
{
    class FirstLast
    {
        public string show(string fn,string ln)
        {
            string fullName;
            fullName = String.Concat(fn, ln);
            return string.Format("The full name :" + fullName);
        }
    }
}
