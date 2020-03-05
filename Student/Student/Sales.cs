using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Sales
    {
        string pname;
        int quantity;
        double price;
        public static double sales = 0;
        
        public Sales(string pname, int quantity, double price)
        {
            this.pname = pname;
            this.quantity = quantity;
            this.price = price;
            sales = sales + price * quantity;
        }
        public  double Show()
        {
            return sales;
        }
    }
}
