using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingPrac
{
    internal class Program
    {

        class Animal
        {
            public virtual void Eat() {
                Console.WriteLine("냠냠 먹습니다");

            }
        }

        class Dog : Animal
        {
            public new void Eat() //하이딩
            {
                Console.WriteLine("촵촵 먹습니다");
            }
        }

        class Cat : Animal
        {
            public override void Eat()//오버라이딩
            {
                Console.WriteLine("뇸뇸 먹습니다");
            }
        }











        class Paraent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void Method2()
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
            public override void Method2() //부모꺼에 virtual을 써야 자식에서 override를 할 수 있음
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

            //하이딩
            child.Method();//부모의 메서드
            p.Method();//자식의 메서드

            //오버라이딩
            child.Method2();//자식의 메서드
            p.Method2();//자식의 메서드

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                 new Dog(), new Cat(), new Cat(), new Dog(),
            };
            foreach (var item in Animals)
            {
                item.Eat();
            }
        }
    }
}
