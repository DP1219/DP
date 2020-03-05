using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class EmpOverride :Employee
    {
        public override string EmpSal(double Sal)
        {
            double incentive = 5000;
            Sal = Sal + incentive;
            return Sal.ToString();
        }
    }
}
