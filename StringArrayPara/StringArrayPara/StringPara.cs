using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayPara
{
    class StringPara
    {
        public string show(string[] Array)
        {
            string allnames = string.Join(" ",Array);
            return allnames;
        }
    }
}
