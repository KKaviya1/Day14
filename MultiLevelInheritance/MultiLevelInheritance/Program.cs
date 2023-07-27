using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //AppDev appDev = new AppDev();
            //appDev.Register();
            //appDev.Display();

            //Emp emp = new Emp();
            //emp.Register();
            //emp.Display();

            Dev dev = new Dev();
            dev.Register();
            dev.Display();

            Console.ReadKey(); 
        }
    }
}