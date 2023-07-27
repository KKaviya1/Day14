using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultiLevelInheritance
{
   public class Dev: Emp
    {
        string project;
        string domain;
        public Dev()
        {
            Console.WriteLine("Developer Constructor");
            project = "not assign";
            domain = "not given";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain:" + domain);
            Console.WriteLine("Projects:" + project);

            }
        public override void Register()
        {
            Console.WriteLine("Enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Projects");
            project = Console.ReadLine();
        }
        public override void show()
        {
            Console.WriteLine("Enter score");
        }

    }

}
    

