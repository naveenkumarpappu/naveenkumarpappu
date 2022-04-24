using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            assign2 arr = new assign2();
            arr.array();
            //for marks
            Tenmarks a = new Tenmarks3();
            a.marks();
            //display
            Display b = new Display();
            b.StringProgram();
        }
    }
}

