using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            geTIAirBorne();

            // geTInterfaceMath();
            // getBike();
            // geTBasicInterface();
            Console.ReadKey();
        }

        private static void geTIAirBorne()
        {
            Aeroplane a = new Aeroplane();
            Helicopter h = new Helicopter();
            IairBorne i = a;
            Console.WriteLine(i.fly());
            i = h;
            Console.WriteLine(i.fly());
        }

        private static void geTInterfaceMath()
        {
            MathProp mp = new MathProp { A = 4, B = 5 };
            IMathOp i;
            i = new Math();
            i.Add(mp.A, mp.B);
            i.Mul(mp.A, mp.B);
        }

        private static void getBike()
        {
            Bike b = new Bike { A = "DP" };
            BikeDrone bd = new BikeDrone();
            bd.Show(b.A);
            Idrone i;
            i = new BikeDrone();
            i.geTdetails();
            Console.WriteLine();
        }

        private static void geTBasicInterface()
        {
            Dp d = new Dp();
            d.geTdetails();
            Anil a = new Anil();
            a.geTdetails();
        }
    }
}
