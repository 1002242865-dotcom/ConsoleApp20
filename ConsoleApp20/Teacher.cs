using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
     class Teacher :Person
    {
        
        private bool IsSport;
        private double Salary;
        private string Degree;

        //عندما تقرر فئة الابن اعادة تطبيق- Override
        // دهس عملية افتراضية-virtual موجودة لدى فئة الاب
        //فانها ملزمة بالمحافظة على نفس العنوان مع استبدال كلمة virtual ب overrride
        public override void P4()
        {
            Console.WriteLine("Hey Man from Teacher ==>P4");
        }



        //the deafult construcgtor will call/recall the up constructor of the parent class


        // public Teacher(int Id, string Name, bool IsSport, double Salary, string Degree)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.IsSport = IsSport;
        //    this.Salary = Salary;
        //    this.Degree = Degree;
        //}
    }
}
