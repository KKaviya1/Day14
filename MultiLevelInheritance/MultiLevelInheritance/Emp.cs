using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Emp
    {
        int id;
        string name;
        public Emp()
        {
            Console.WriteLine("employee class constructor");
            id = -1;
            name = "not given";
        }
        public virtual void Display()
            {
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Name:" + name);

        }
        public virtual void Register()
        {
            Console.WriteLine("Enter ID");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public virtual void show()
        {
            Console.WriteLine("Enter Grade");
        }
    }
}
