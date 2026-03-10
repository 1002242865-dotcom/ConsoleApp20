using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            //Worker w1 = new Worker();
            //Student st1=new Student(123,"Ali",99,true);
            //st1.Name

            //Person p1=new Person(123,"Ali");
            //Console.WriteLine(p1.GetId());
           
            Student st2 = new Student(222, "Mona", 96, true);
            Console.WriteLine(st2.GetId());
            
            
            //Console.WriteLine(st2.ToString());

            Teacher t1 = new Teacher();
            //Console.WriteLine(t1.GetId());

            
            //فكرة لسؤال عكسي: يعطى الكود ويطلب كتابة الفئة
            //امامك مقطع كود سليم
            //بناء عليه قم بنناء الفئة Student
            
        }
    }
}
