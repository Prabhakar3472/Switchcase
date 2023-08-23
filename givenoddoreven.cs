using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class givenoddoreven
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a number you want to print");
            int num=Convert.ToInt32(Console.ReadLine());
            switch(num%2)  
            {
             case 0:
                    Console.WriteLine("its even no");
                    break;
             default:
                    Console.WriteLine("its odd no");
                    break;
            
            }
        
        }
    }
}
