﻿using ConAppVirtualProp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine(emp.Id);
            Dev dev = new Dev();
            Console.WriteLine(emp.Id);
            Console.ReadKey();
        }
    }
}
