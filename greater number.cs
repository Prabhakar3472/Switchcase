using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class greater_number
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the first number you want to print");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to print");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b) 
            {
                Console.WriteLine("the value of a is greater");
            }
            else 
            {
                Console.WriteLine("the value of b is greater");
            }
        }
    }
}
