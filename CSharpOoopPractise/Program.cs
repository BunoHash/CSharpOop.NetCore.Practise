using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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


            ValueAndRefType.RunTypePractise();

           



            
        }

        
    }
}
