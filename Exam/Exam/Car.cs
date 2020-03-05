using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Car
    {
        string regno, model, color;
        double price;
        public Car() { }
        public Car(string regno)
        {
            this.regno = regno;
        }
        public Car(string reg,string mod)
        {
            regno = reg;
            model = mod;
        }
        public Car(string reg, string mod,string color,double pr)
        {
            regno = reg;
            model = mod;
            this.color = color;
            price = pr;
        }
        public string Display()
        {
            /* Console.WriteLine("Reg no:" + regno);
            Console.WriteLine("model is:" + model);
            Console.WriteLine("color is:" + color);
            Console.WriteLine("price is:" + price); */

            return string.Format("Reg no:{0}\nModel :{1}\nColor:{2}\nPrice:{3}", regno, model, color, price);
        }
    }
}
