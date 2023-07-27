using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    public class Employee
    {
        int id;
        string name;
        double sal;
        public virtual void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name= Console.ReadLine();
            Console.WriteLine("Enter Salary");
            sal = double.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Salary:" + sal);
        }
    }
}
