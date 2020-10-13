using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            while (i < 1000)
            {
            Console.WriteLine(i)
            i = j;      
            
                while(j <= 1000)
                { 
                 Console.WriteLine(j)
                
                
                   
                    j = i + j;
                }
            }
            
               

            }
        Console.Readkey();
        }
    }
}
