using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Trainee
    {
        string name, id, city;
        int age;
        public void GetDetails(string n,string i,string ad,int a)
        {
            name = n;
            id = i;
            city = ad;
            age = a;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Name:"+name);
            Console.WriteLine("ID:"+id);
            Console.WriteLine("Age:"+ age);
            Console.WriteLine("City:" + city);
        }
    }
}
