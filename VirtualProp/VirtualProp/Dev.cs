
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualProp;

namespace ConAppVirtualProp
{
    public class Dev:Emp 
    {
        int did;

        public Dev() { did = 0; }

        public override int Id { get => did; set => did = value; }
    }
}