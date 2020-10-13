using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i ++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ",");
                }
                
            }

            // Stop until user press a key 
            Console.ReadKey();


        }
    }
}
