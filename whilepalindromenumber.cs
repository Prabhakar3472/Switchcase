using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class whilepalindromenumber
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;
            while (num != 0)
            {
                int rem = num % 10;
                rev =( (rev * 10) + rem);
                num = num / 10;
            }
            Console.WriteLine("number after revers"+rev);
            if (temp == rev)  
            {
                Console.WriteLine("number is palidrome");
            }
            else 
            {
                Console.WriteLine("number is not palidrome");
            }

        }
    }
}
