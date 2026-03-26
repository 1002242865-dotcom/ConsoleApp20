using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            //نوع المؤشر يحدد ماهي العمليات التي نستطيع استدعائها
            //اما نوع الكائن فهو الي يحدد ما هي النسخة من العملية التي سيتم تنفيذها- خاصة عندما تكون العمليات افتراضية وان الابناء يستطيعون اعادة تطبيقها

            //Person p1 = new Person();

            //Teacher t1=new Teacher();
            //t1.P1(); //هنا لا توجد حيرة: سيتم استدعاء العملية بنسختها الاصلية والوحيدة لان العملية ليست افتراضية
            
            //t1.P4();// هنا وقبل تحديد الاجابة، يجب اولا النظر الى نوع الكائن، وخاصة لان العملية افتراضية عند الاب virtual
                    //اولا نذهب الى فئة الابن Teacher ونفحص اذا قام باعادة تطبيقها override
                    //اذا كان كذلك عندها سيتم تنفيذ النسخة التي لدى الابن
                    // خلاف ذلك - الابن لم يقم باعادة تطبيقها- نعود لفئة الاب


            Employee e1 = new Employee();
            e1.P4();



        }
    }
}
