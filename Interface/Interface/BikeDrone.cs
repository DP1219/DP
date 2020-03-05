using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
     class BikeDrone :Bike,Idrone
    {
        public void geTdetails()
        {
            Console.WriteLine("This is from drone Interface");
        }
        public void Show(string A)
        {
            this.A = A;
            Console.WriteLine("This is:{0}" ,A);
        }
    }
}
