using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee
            {
                Id = 844918,
                Name = "Durga Prasad",
                D = new Domain
                {
                    DepId = 1,
                    Depname = "DoT NET"
                }
            };
            Console.WriteLine("Name:{0}\nID:{1}\nDeptId:{2}\nDeptName:{3}", e.Id, e.Name, e.D.DepId,e.D.Depname);
            Console.ReadKey();
        }
    }
}

