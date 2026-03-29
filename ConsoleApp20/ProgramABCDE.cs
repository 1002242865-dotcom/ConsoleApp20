using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class ProgramABCDE
    {
        static void Main(string[] args)
        {
            //A a1 = new A();
            //A a2 = a1;

            //int x = 10;
            //int y = x;

            //int m = 100;
            //double n = m;

            A a1 = new A();
            A a2 = new B();
            A a3= new C();
             A a4 = new D();
             A a5 = new E();

           // B b1 = new A();


            ////D d1=new D();
            ////d1.F1();
            ////d1.F2();
            ////d1.H1();

            ////B b1= new B();
            ////b1.G1();
            ////b1.F1();
            ////b1.F2();
            ////Console.WriteLine(b1.ToString()); 

            //E e1= new E();
            //e1.M1();
            //e1.F2();
            //e1.G1();
            //e1.F1();
            //Console.WriteLine(e1.ToString());

        }
    }

    class A
    {
        public void F1()
        {
            Console.WriteLine("A => F1");
        }

        public virtual void F2()
        {
            Console.WriteLine("A => F2");
        }

        public override string ToString()
        {
            return "A => ToString";
        }
    }

    class B : A
    {
        public void G1()
        {
            Console.WriteLine("B => G1");
        }
        public override void F2()
        {
            Console.WriteLine("B => F2");
        }

       
       
    }

    class C : A
    {

    }

    class D : A
    {
        public void H1()
        {             
            Console.WriteLine("D => H1");
        }

        public override void F2()
        {
            Console.WriteLine("D => F2");
        }

        public override string ToString()
            {
                return "D => ToString";
        }
    }

     class E : B
    {
        public void M1()
        {      
            Console.WriteLine("E => M1");
        }

        public override void F2()
            {
                Console.WriteLine("E => F2");
            }
    
           
    }
}
