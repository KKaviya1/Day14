using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example - 01

            //OurClass obj = new OurClass();
            //obj.Display("Shalini");
            //obj.Display();
            //Console.WriteLine(obj.Add("Prakash","Viya"));
            //Console.ReadKey();

            //example - 02

            OurClass obj = new OurClass();
            int num = 34;
            obj.Increment(num);
            obj.Increment(ref num);
            Console.ReadKey();


        }

    }
}
