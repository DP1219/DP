using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Measure
    {

        double cm;
        int inch;

        public double Inch
        {
            get  { return cm / 2.54; }
            set { cm = value * 2.54; }
        }
        public int Cm
        {
            get { return (int)(inch * 2.54); }
            set { inch = (int)(value / 2.54); }
        }
  
        public void CmShow()
        {
            Console.WriteLine("Inches to Cm :" + cm);
            Console.WriteLine("cm to Feet:" + (cm / (2.54*12)));
        }
        public void InchShow()
        {
            Console.WriteLine("Cms to Inches :" +inch);
            Console.WriteLine("Inches to Feet:" + (inch / 12));
        }

    }
}
