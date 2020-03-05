using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODOTNET
{
    class DataLayer
    {
      
        Restaurent f = new Restaurent
        {
            resId = 121,
            resName = "Dp",
            resType = "Arab",
            resCity = "Hyd"
        };
        public void show()
        {
            Console.WriteLine(f.resId);
            Console.WriteLine(f.resName);
            Console.WriteLine(f.resType);
            Console.WriteLine(f.resCity);
        }
    }
}
