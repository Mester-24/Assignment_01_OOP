using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01OOP
{
    internal struct Point
    {
        //Attributs
        public int X;
        public int Y;
        //----------------------
        //Constructor : Is Special Funcation
        //1- Named Always With The Same Name Of Class Or Struct
        //2-Has No Return




        //By Default At Struct ,Compiler Will Alwayes Generate Paramterless Constructor
        public Point ()
        {
            X = 0;
            Y = 0;
        }

        public Point(int _X,int _Y)
        {
            X = _X;
            Y = _Y;

        }

        //Method
        public override string ToString()
        {
            return $"The X is={X} , Y is={Y}";
        }

    }
}
