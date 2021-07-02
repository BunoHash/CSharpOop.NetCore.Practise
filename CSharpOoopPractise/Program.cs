
using System;
using System.Windows.Forms;

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


            //var sample = new int[20];

            //prob.process(sample);

            EnumPractise.Process();
            

           
            
        }

        
    }
}
