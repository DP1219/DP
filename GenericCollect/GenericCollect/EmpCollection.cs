using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollect
{
    class EmpCollection
    {
        List<Employee> emp = new List<Employee>();
        public void add()
        {
            int id;
            string name, desig;
            double sal;
            Console.WriteLine("Enter the employeee Details:");
            Console.Write("ID:");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Designation:");
            desig =Console.ReadLine();
            Console.Write("Salary:");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Details Entered");
            emp.Add(new Employee
            {
                Id = id,
                Name =name ,
                Designation = desig,
                Salary = sal
            });
        }
        public void remove()
        {
            int index;
            Console.WriteLine("Enter index to remove Employee:\n");
            index = int.Parse(Console.ReadLine());
            emp.RemoveAt(index);
        }
        public void show()
        {
            Console.WriteLine("\nId\tName\t\tDesignation\tSalary\n");
            foreach (Employee e in emp)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\n", e.Id, e.Name, e.Designation, e.Salary);
            }
        }
    }
}
