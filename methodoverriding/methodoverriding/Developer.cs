using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    public class Developer:Employee
    {
        string domain;
        string project;
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Project");
            project = Console.ReadLine();
        }

        public override void Display()
        { 
            base.Display();
            Console.WriteLine("Domain:" + domain);
            Console.WriteLine("Project:" + project);
        }
    }
}
