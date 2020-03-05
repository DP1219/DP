using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{

    public class sales
    {
        string pname;
        int quantity;
        double price;
        public static double Tsales = 0;
        public sales(string pname, int quantity, double price)
        {
            this.pname = pname;
            this.quantity = quantity;
            this.price = price;
            Tsales = Tsales + price;
        }
        public void show()
        {
            Console.WriteLine("Product Name:{0}\nQuantity:{1}\nPrice:{2}", pname, quantity, price);
        }

        class Program
    {
        static void Main(string[] args)
        {
            sales st = new sales("Mobile", 2, 15000);
            sales st1 = new sales("Laptop", 1, 35000);
            sales st2 = new sales("Projector", 1, 20000);
            sales st3 = new sales("Screen", 5, 30000);
            st.show();
            Console.WriteLine();
            st1.show();
            Console.WriteLine();
            st2.show();
            Console.WriteLine();
            st3.show();
            Console.WriteLine();
            Console.WriteLine("Total Sales Amount:"+sales.Tsales);
            Console.ReadKey();
        }
    }
}
