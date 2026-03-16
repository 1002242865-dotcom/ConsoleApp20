using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Person
    {
        private int Id;
        protected string Name;

        public Person(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Console.WriteLine("Person");

        }

        public Person(string Name)
        {
            this.Name = Name;
            this.Id = 777;
            Console.WriteLine("Person2");
        }

        public Person()
        {
            this.Id = 777;
            this.Name = "AAA";
            Console.WriteLine("Person3");
        }

        public int GetId()
        {
            return this.Id;
        }

        //سنقوم باضافة العمليات  P1 P2 P3 الى الفئة Person 
        //على النحو التالي
        public void P1()
        {
            Console.WriteLine("Hi From Person ==> P1");
        }
        private void P2()
        {
            Console.WriteLine("Hi From Person ==> P2");
        }
        protected void P3()
        {
            Console.WriteLine("Hi From Person ==> P3");
        }

        public virtual void P4()
        {             
            Console.WriteLine("Hi From Person ==> P4");
        }

        public override string ToString()
        {
            return "the Id:" + this.Id + ", the Name:" + Name;
        }

    

    }
}
