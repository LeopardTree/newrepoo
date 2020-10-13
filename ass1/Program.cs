using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //adds foreground and background color to data
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            //clear console so the color appears on all texts
            Console.Clear();


            string name = "Ludvig Viveland";
            string street = "Vårbruksgatan 81";
            string zip_city = "58332 Linköping";
            string personal_adress;

            //commasign performs a newline between data
            string personal_adress = { name, street, zip_city };

            
            //the length of the strings in integers
            int length_name = name.Length;
            int length_street = street.Length;
            int length_zip_city = zip_city.Length;
            
            int widthtext = Max(length_name, length_street, length_zip_city)

            Console.WriteLine(widthtext);

            //Console.WriteLine(personal_adress);
            */
            /*Console.WriteLine(name);
            
            Console.WriteLine(street);
            Console.WriteLine(zip_city);
            
            /*
                        public BoxGenerator(char*)
                        {
                            _border = new string(*, 8);
                        }
            */

            Console.ReadKey();       
        }
    }
}
