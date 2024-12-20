using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_oop
{
    internal struct Person
    {
        public string Name;
        public int Age;

        public Person(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
    }
}
