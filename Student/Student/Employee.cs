using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Employee
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double Sal
        {
            get;set;
        }
        public virtual string EmpSal(double Sal)
        {
            return Sal.ToString();
        }
    }

}
