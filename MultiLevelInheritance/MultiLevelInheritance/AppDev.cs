using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    //public class AppDev:Dev,Emp //error multiple base classes are not allowed
    //public sealed class AppDev:Dev
    //if we use keyword sealed with class
    //that means we can not further drive from that class
    public class AppDev : Dev
    {
        string osType;
        public AppDev()
        {
            Console.WriteLine("App developer Constructor");
            osType = "unknown";
        }
        public sealed override void Display()
        {
            //you can not override this method further
            base.Display();
            Console.WriteLine("OS type:" +  osType);
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter OS Type:");
            osType=Console.ReadLine();
        }

    }
    
}

