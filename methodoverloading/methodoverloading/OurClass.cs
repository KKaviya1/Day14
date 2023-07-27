using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading
{
    //example - 01

    //methods are different based on method parameters
    //public class OurClass
    //{
    //    //number of parameters

    //    public void Display()
    //    {
    //        Console.WriteLine("Display of our class");
    //    }
    //    public void Display(string name)
    //    {
    //        Console.WriteLine("Welcome to Display:" + name);
    //    }
    //    public void Display(string fname,string lname)
    //    {
    //        Console.WriteLine("Welcome to display Mr.\\Ms." + fname + "" + lname);
    //    }

    //    //types of parameters

    //    public double Add(double num1, double num2)
    //    {
    //        Console.WriteLine("Double method call");
    //        return num1 + num2; 
    //    }
    //    public int Add(int num1, int num2) 
    //    {
    //        Console.WriteLine("Int method call");
    //        return num1 + num2; 
    //    }
    //    public string Add(string fname, string lname)
    //    {
    //        Console.WriteLine("String method call");
    //        return fname + "," + lname;
    //    }


    //example - 02
    public class OurClass
    {
        public void Increment(int num1)
        {
            num1 += 2;
            Console.WriteLine("number after increment \t" + num1);
        }
        public void Increment(ref int num1)
        {
            num1 += 5;
            Console.WriteLine("number after increment \t" + num1);
        }
        //public void Increment(out int num1)
        //{
        //    num1 = 155;
        //    Console.WriteLine("number after increment \t" + num1);
        //}

    }
    
}
