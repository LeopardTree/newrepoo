using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over18
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int number = 0;
                Console.WriteLine("mata in ett tal");
                string userInput = "";
                //get value from user
                userInput = Console.ReadLine();
                //convert input to integer
                number = int.Parse(userInput);
                If(number > 18)
                {
                    Console.WriteLine("talet är över 18")
                }
                else
                {
                    Console.WriteLine("talet är under 18")
                }

                Console.ReadKey
            
    }
}
