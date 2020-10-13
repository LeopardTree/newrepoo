using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int number = 0;
            onsole.WriteLine("mata in ett tal")
            string userInput = "";
            //get value from user
            userInput = Console.ReadLine();
            //convert input to integer
            number = int.Parse(userInput);
            If (number > 18)
            { 
                Console.WriteLine ("talet är över 18")
            }
            else 
            { 
                Console.WriteLine ("talet är under 18")
            }
               
            Console.ReadKey
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
