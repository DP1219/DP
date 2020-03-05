using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class FixedBal :BankAccount
    {
        public FixedBal(BankAccount b)
        {
            this.Balance = b.Balance;
        }
        public override string IntrestAmount()
        {
            return string.Format("\n\nUpdated Balance After adding 3% Additional Interest:" + (((Balance*2*(10+3))/100)));
        }
    }
       
    
}
