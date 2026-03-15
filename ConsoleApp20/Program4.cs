using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            //Worker w1 = new Worker();
            //w1.P1();
            ////w1.P2(); //private ترجمة وتحويل
            ////w1.P3(); //protected ترجمة وتحويل
            ///


            //Person p = new Person();
            //p.P1();
            //p.P2();
            //p.P3();
            //p.W1();
            //p.W2();
            //p.W3();

            Worker w = new Worker();
            w.P1();
            //w.P2();/// غير سليم، خطأ ترجمة وتحويل ، لانها private
            //w.P3(); // غير سليم، خطأ ترجمة وتحويل، لانها protected
            w.W1();
            //w.W2();// غير سليم، خطأ ترجمة وتحويل، لانها private
            //w.W3(); // غير سليم، خطأ ترجمة وتحويل، لانها protected
            //w.W4(10);// غير سليم، خطأترجمة وتحويل،
            //على الرغم من ان العملية موجودة ومعرفة public  ولكن العملية لا تتلقى عدد صحيح
            //Console.WriteLine(w.W4()); //غير سليم، خطأ ترجمة وتحويل، لان العملية void ولا تعيد قيمة وبالتالي لا يمكن طباعتها

        }
    }
}
