
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using WindowsForms_async_await.book_practise.chap_03;
using WindowsForms_async_await.book_practise.chap_05;
using WindowsForms_async_await.book_practise.chap_06;
using WindowsForms_async_await.misc;

namespace CSharpOopPractise
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            //Application.Run(new AsyncAwaitThread());

            // var reflection = new Reflection();
            // reflection.UseReflection();
            // Console.ReadKey();


            // ValueAndRefType.RunTypePractise();
            //Chapter 2 :
            //Operator.Logical();
            //chap 05:
            //ValueRefOut.TestParamsType();
            // chap 06:
            //delegate

            //Delegates.Process();


            var sample = new int[20];

            prob.process(sample);
            

           
            
        }

        
    }
}
