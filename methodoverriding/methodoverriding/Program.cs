using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Employee**");
            Employee employee = new Employee();
            employee.Register();
            Console.WriteLine();
            employee.Display();

            Console.WriteLine("\n");
            Console.WriteLine("**Developer**");
            Developer developer = new Developer();
            developer.Register();
            Console.WriteLine();
            developer.Display();
            Console.ReadKey();

        }
    }
}
