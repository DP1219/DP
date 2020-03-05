using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StaticDemo
    {
        int id;
        string name;
        static string Company = "Cognizant";
        public StaticDemo(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine("Employee Name:"+name);
            Console.WriteLine("Employee Id:"+id);
            Console.WriteLine("Company:"+Company);
        }
    }
}
