using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingPrac
{
    internal class Program
    {
        class Paraent
        {
            public int variable = 273;
        }
        class Child : Paraent {
            public new string variable = "shadowing";
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            //shadowing
            int number = 20;
            Console.WriteLine(number);//20

            //hiding
            Child child = new Child();
            Console.WriteLine(child.variable);//"shadowing"

            Paraent p = child;
            Console.WriteLine(p.variable);//"273"
        }
    }
}
