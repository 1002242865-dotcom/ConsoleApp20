using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Student : Person
    {
        private double Avg;
        private bool IsSport;

        public Student(int Id, string Name, double Avg, bool IsSport)  //عدم كتابة اي استدعاء هي نفسها :base()
        {
            this.Avg = Avg;
            this.IsSport = IsSport;
            Console.WriteLine("Student");
        }
        //العملية البنائية اعلاه هي مثال على استدعاء غير صريح للعملية البنائية الفارغة لدى الاب
        //ونستطيع جعلها صريحة من خلال اضافة الامر التالي
        //:base()

        ////private static int c = 0;
        //public const int MAX= 100;

        //public Student(int Id, string Name, double Avg, bool IsSport)
        //{
        //   this.Id = Id;
        //    this.Name = Name;
        //    this.Avg = Avg;
        //    this.IsSport = IsSport;
        //    //c++;
        //    Student.c++;

        //}

        //public static int GetC()
        //{ 
        //    //Avg+=10;
        //    //this.Avg += 9;
        //    return c;
        //    //return Student.c;
        //}

        //public  int GetC2()
        //{
        //    Console.WriteLine(this.Avg);
        //    return  c;
        //}

        ////public void SetId(int Id)
        ////{
        ////    this.Id = Id;
        ////}

        ////public int GetId()
        ////{
        ////    return Id;
        ////}

        ////public void SetName(string Name)
        ////{
        ////    this.Name = Name;
        ////}

        ////public string GetName()
        ////{
        ////    return Name;
        ////}

        //public void SetAvg(double Avg)
        //{
        //    this.Avg = Avg;
        //}

        //public double GetAvg()
        //{
        //    return Avg;
        //}

        //public void SetIsSport(bool IsSport)
        //{
        //    this.IsSport = IsSport;
        //}

        //public bool GetIsSport()
        //{
        //    return IsSport;
        //}

    }
}
