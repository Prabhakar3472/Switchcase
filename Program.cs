using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class Program
    {                                         //accept 2 number from user
                                              //place menu to the user
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A number:-");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter A number:-");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter A number:-");
            int Choice=Convert.ToInt32(Console.ReadLine());

            switch (Choice) 
            {
                case 1:
                    Choice = num1 + num2;
                    Console.WriteLine("Addition two number"+Choice);
                    break;
                case 2:
                    Choice = num2 - num1;

                    Console.WriteLine("Substraction two number" + Choice);
                    break;
                case 3:
                    Choice = num1 + num2;
                    Console.WriteLine("Multiplication two number" + Choice);
                    break;
                case 4:
                    Choice = num1 / num2;
                    Console.WriteLine("Division two number" + Choice);
                    break;
                case 5:
                    Choice = num2 % num1;
                    Console.WriteLine("mod" + Choice);

                    break;

                Default:
                    Console.WriteLine("you enter wrong number");
                        break;  
                    

            }
        }
    }
}
