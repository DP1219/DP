using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class BankAccount
    {
        public double AccNO
        {
            get;set;
        }
        public double Balance
        {
            get; set;
        }
        public Customer cus
        {
            get;set;
        }
        public string Display()
        {
            return string.Format("Account No:{0}\n\nBalance:{1}\n\n", AccNO, Balance);
        }
        public virtual string IntrestAmount()
        {
            double r, y,t;
            Console.Write("Enter rate of interest:");
            r = double.Parse(Console.ReadLine());
            Console.Write("\nEnter how years :");
            y = double.Parse(Console.ReadLine());
            t = (Balance * r * y) / 100;
            return string.Format("\nInterest As of Now From 2 years @10% is:"+t);
        }
    }
}
