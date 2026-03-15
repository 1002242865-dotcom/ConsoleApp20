using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
     class Worker :Person
    {
        
        private string Phone;
        private string Address;

        //وكذلك سنقوم باضافة العمليات W1 W2 W3 الى الفئة Worker على النحو التالي
        public void W1()
        {
            Console.WriteLine("Hi From Worker ==> W1");
        }

        private void W2()
        {
            Console.WriteLine("Hi From Worker ==> W2");
        }

        protected void W3()
        {
            Console.WriteLine("Hi From Worker ==> W3");
        }

        public void W4()
        {
            Console.WriteLine("Hi From Worker ==> W4");
        }

//سنقوم باضافة عملية داخلية في الفئة Worker
//على النحو التالي

        public void Test()
        {
            P1();
            base.P1();
            this.P1();

            /* لا يمكن استدعاء العملية لانها معرفة private
            P2();
            base.P2();
            this.P2();
            */

            //نستطيع استدعاء العملية لانها معرفة protected
            P3();
            base.P3();
            this.P3();


            W1();
            W2();
            W3();
            W4();
            this.W1();
            //base.W1(); //غير سليم
            //الفرق بين this و base

        }

        //public Worker(int Id, string Name, string Phone, string Address)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Phone = Phone;
        //    this.Address = Address;
        //}
    }
}
