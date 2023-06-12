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
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Paraent {
            public new string variable = "shadowing"; // new를 쓰면 hiding이라는 것을 명시함
            public new void Method() //hiding / overridingX
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            //shadowing - 상속X
            int number = 20;
            Console.WriteLine(number);//20

            //hiding - 상속
            Child child = new Child();
            Console.WriteLine(child.variable);//"shadowing"

            Paraent p = child;
            Console.WriteLine(p.variable);//"273"

            child.Method();
            p.Method();
        }
    }
}
