using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
     class Employee : Person
    {

        //قررت الفئة اعادة تطبيق العملية
        //بحيث لا تستغني تماما عن النسخة الاصلية،
        //بل تقوم اولا باستدعاءها ثم تقوم بطباعة جملة اضافية
        public override void P4()
        {
            base.P4();
            Console.WriteLine("I'm Employee ==> P4");
            //سؤال: ماذا سيحدث اذا استبدلنا الامر
            ////base.P4();
            //this.P4();
            //هكذا ستصبح لدينا عملية تراجعية لا نهائية لانه لا يوجد شرط توقف
            //وبالتالي سيحدث خطأ زمن تشغيل
        }
    }
}
