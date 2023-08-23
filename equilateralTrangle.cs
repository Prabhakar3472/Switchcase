using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class equilateralTrangle
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter side");
            int a=Convert.ToInt32(Console.ReadLine());
            double res = 0;
            res = (1.5 / 4) * (a * a);
            Console.WriteLine("Area of equalateral triangle:"+res);
        }
    }
}
