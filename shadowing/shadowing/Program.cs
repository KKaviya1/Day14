using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowing
{
    internal class Program
    {
        static int myVar = 15;
        static void Main(string[] args)
        {
            int myVar = 10;
            Console.WriteLine("Inner myVar is " + myVar);
            Console.WriteLine("outer MyVar value is " + Program.myVar);
            Display();
            Console.ReadKey();
        }
        public static void Display()
        {
            int myVar = 25;
            Console.WriteLine("Value of local myVar in Display " + myVar);
            Console.WriteLine("Global variable values is " + Program.myVar);

        }
    }
}
