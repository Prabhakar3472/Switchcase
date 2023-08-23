using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class area_of_circle
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the radius of circle");
            int r =Convert.ToInt32(Console.ReadLine());
            double area = 0;

            area = 3.14 * r * r;
            Console.WriteLine("area of circle" + area);
        }
    }
}
