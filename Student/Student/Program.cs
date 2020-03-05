using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount
            {
                AccNO = 188988,
                Balance = 30000,
                cus = new Customer
                {
                    CustId = "B3111",
                    CustName = "Durga Prasad",
                    Address = "Rajahmundry"
                }
            };
            Console.WriteLine(ba.cus.Display());
            Console.WriteLine(ba.Display());
            Console.WriteLine(ba.IntrestAmount());
            FixedBal fd = new FixedBal(ba);
            Console.WriteLine(fd.IntrestAmount());

            // geTProdCateg();
            // getOverride();
            // geTOperatorLoad();
            // geTsample();
            // geTSales();
            // StaticDemo();
            // StudentObj();
            // TimePeriodObj();
            // Auto();
            // MeasureObj();
            // getArea();

            Console.ReadKey();
        }

        private static void geTProdCateg()
        {
            Product p = new Product
            {
                PId = 121,
                PName = "Mobile",
                Price = 12000,
                cat = new Category
                {
                    C_Id = 12,
                    C_Name = "Gadget"
                }
            };
            Console.WriteLine("Category ID:{0}\n\nCategory Name:{1}\n\nProduct ID:{2}\n\nProduct Name:{3}\n\nProduct Price:{4}", p.PId, p.PName, p.Price, p.cat.C_Id, p.cat.C_Name);
        }

        private static void getOverride()
        {
            Employee emp = new Employee { Id = 844918, Name = "Durga Prasad", Sal = 40000 };
            EmpOverride e = new EmpOverride();
            Console.WriteLine(e.EmpSal(e.Sal));
        }

        private static void geTOperatorLoad()
        {
            Demo d = new Demo();
            Demo d1 = new Demo(10, 20);
            d1.DisplayData();
            Demo d2 = new Demo(30, 40);
            d2.DisplayData();
            d = d1 + d2;
            Console.WriteLine("After + Overloading:");
            d.DisplayData();
            d = d1 * d2;
            Console.WriteLine("After * Overloading:");
            d.DisplayData();
            d = d2 - d1;
            Console.WriteLine("After - Overloading:");
            d.DisplayData();
        }

        private static void geTsample()
        {
            Sample s = new Sample();
            Sample s1 = new Sample();
            Sample s2 = new Sample();
            Sample s3 = new Sample();
            Console.WriteLine();
            Console.WriteLine(Sample.dp());
        }

        private static void geTSales()
        {
            Sales st = new Sales("Mobile", 2, 5000);
            Sales st1 = new Sales("Laptop", 1, 35000);
            Sales st2 = new Sales("Projector", 2, 10000);
            Sales st3 = new Sales("Screen", 5, 6000);
            Console.WriteLine("Total sales:" + st.Show());
        }

        private static void StaticDemo()
        {
            StaticDemo sd = new StaticDemo(844918, "Durga Prasad");
            sd.Show();
            Console.WriteLine();
            StaticDemo sd1 = new StaticDemo(844920, "Anil");
            sd1.Show();
        }

        private static void getArea()
        {
            Calculate c = new Calculate();
            Console.WriteLine(c.area(16));
            Console.WriteLine(c.area(14, 12));
            Console.WriteLine(c.area(14.0));
            Console.WriteLine(c.area(12.0, 5.0));
        }

        private static void MeasureObj()
        {
            Measure m = new Measure();
            m.Inch = 12;
            Console.WriteLine("Given Inches:" + m.Inch);
            m.CmShow();
            Console.WriteLine();
            m.Cm = 165;
            Console.WriteLine("Given Cm:" + m.Cm);
            m.InchShow();
        }

        private static void Auto()
        {
            Auto a = new Auto
            {
                Id = 1,
                Pname = "Choclate",
                Price = 1000
            };
            Console.WriteLine("ID:{0}\nProduct Name:{1}\nPrice:{2}", a.Id, a.Pname, a.Price);
        }

        private static void TimePeriodObj()
        {
            TimePeriod tp = new TimePeriod();
            tp.Hours = 15;
            Console.WriteLine("Hours:" + tp.Hours);
            tp.Show();
        }

        private static void StudentObj()
        {
            Student st = new Student("Durga", "Prasad");
            st.Idno = 844918;
            st.Course = "DOT NET";
            st.Joindate = DateTime.Parse("12-28-2019");
            Console.WriteLine("Name:" + st.Name);
            Console.WriteLine("ID No:" + st.Idno);
            Console.WriteLine("Training Course:" + st.Course);
            Console.WriteLine("Joining date:" + st.Joindate);
            Console.ReadKey();
        }
    }
}
