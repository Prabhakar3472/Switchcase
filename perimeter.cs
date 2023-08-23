using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class perimeter
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the lenght of reactangle");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breath of reactangle");
            int b =Convert.ToInt32(Console.ReadLine());
            int perimeter;
            perimeter =2*(l*b);
            Console.WriteLine(perimeter);

        }
    }
}
