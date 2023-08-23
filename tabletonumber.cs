using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class tabletonumber
    {                                             //print the table to a number
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a number");
           int table = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <=10; i++)
            {
                int res = table = i;
                Console.WriteLine(res);
            }
        
        }
    }
}
