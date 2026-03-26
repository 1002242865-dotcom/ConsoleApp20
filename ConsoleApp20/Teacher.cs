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


        //بامكان الابن ايضا، اعادة تطبيق العمليات التي قام الاب بدهسها- الاب عملها override
        //على سبيل المثال نستطيع في الفئة Teacher
        //اعادة تطبيق العملية ToString

        public override string ToString()
        {
            return "I'M Teacher ToString ..mr7ba";
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
