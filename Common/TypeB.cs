using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA obj=new TypeA();
            //obj.X = 10; Invalid
            obj.Y=5;// Valid
            obj.Z=10;

        }
    }
}
