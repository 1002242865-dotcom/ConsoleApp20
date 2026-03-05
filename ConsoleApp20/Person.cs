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
        private string Name;

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









    }
}
