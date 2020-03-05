using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Calculate
    {
        public string area(int side)
        {
            return string.Format("Square Area :{0}", side * side);
        }
        public string area(int len, int wid)
        {
            return string.Format("Rectangle Area :{0}", len * wid);
        }
        public string area(double rad)
        {
            return string.Format("Circle Area :{0}", rad * rad * Math.PI);
        }
        public string area(double bas, double height)
        {
            return string.Format("Triangle Area :{0}", 0.5 * bas * height);
        }

    }
}
