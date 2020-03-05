using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class TimePeriod
    {
        double seconds;
        public double Hours
        {
            get { return seconds / 3600; }
            set
            {
                if(value<0 || value>24)
                {
                    throw new Exception("Value cannot be in Range!!!");
                }
                seconds = value * 3600;
            }
        }
        public void Show()
        {
            Console.WriteLine("Seconds:"+seconds);
        }
    }
}
