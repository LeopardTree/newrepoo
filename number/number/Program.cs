using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace number
{
    class Program
    {
       
            static void Main(string[]args)

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int number = 0;
            string userInput = "";
                //get value from user
            userInput = Console.ReadLine();
            //convert input to integer
            number = int.Parse(userInput);
            //is number even?
            if (number % 2 == 0)
            {
                Console.WriteLine("Talet {0} är jämnt", number);


            }
            else
            {
                Console.WriteLine("Talet {0} är udda", number);


            }

            // Stop until user press a key 
            Console.ReadKey();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
          
        }
    }
}
