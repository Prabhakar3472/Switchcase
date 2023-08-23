using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class calculater
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a number you want to print");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number you want to print");
            int b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator(+,-,*,/)");
            char choice=Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
               case '+':
                    int add = a + b;
                    Console.WriteLine("addition two number" + add);
                    break;
                case '-':
                    int sub = a - b;
                    Console.WriteLine("subtraction two number" + sub);
                    break;
                    case '*':
                    int mul = a * b;
                    Console.WriteLine("multiplication two number" + mul);
                    break;
                    case '/':
                    int div = a / b;
                    Console.WriteLine("division two number" + div);
                    break;
                    default
                    : Console.WriteLine("you enter wrong number");
                    break;


            }
        
        
        }
    }
}
