using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class displaydaynumber
    {
        static void Main(string[] args) 


        {
            Console.WriteLine("Enter a first day sunday");
            Console.WriteLine("Enter a second day monday");
            Console.WriteLine("Enter a third day tuseday");
            Console.WriteLine("Enter a forth day wensday");
            Console.WriteLine("Enter a fifth day thursday");
            Console.WriteLine("Enter a sixth day friday");
            Console.WriteLine("Enter a seventh day saturday");
            int day= Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("you selected sunday");
                    break;  
                    case 2:
                    Console.WriteLine("you selected monday");
                    break;  
                    case 3:
                    Console.WriteLine("you selected tuseday");
                    break;  
                    case 4:
                    Console.WriteLine("you selected wensday");
                    break;  
                    case 5:
                    Console.WriteLine("you selected thursday");
                    break;  
                    case 6:
                    Console.WriteLine("you selected friday");
                    break;
                default:
                    Console.WriteLine("you selected wrong input");
                    break;  
            
            }



        }
    }
}
