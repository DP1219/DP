using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Customer
    {
        public string CustId
        {
            get;set;
        }
        public string CustName
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string Display()
        {
            return string.Format("Customer Id:{0}\n\nCustomer Name:{1}\n\nCustomer Address:{2}\n", CustId, CustName, Address);
        }
    }
}
