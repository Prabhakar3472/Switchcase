using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class whilefactor
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the number you want print");
            int num=Convert.ToInt32(Console.ReadLine());
            int i = 2;
            for (i = 2; i<num; i++) 
            {
               if (num % i == 0) 
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
