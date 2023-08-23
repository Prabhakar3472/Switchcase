using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class tringle_angles
    {
       static void Main(string[] args) 
        {
            Console.WriteLine("Enter the lenght of first angle");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lenght of second angle");
            int b=Convert.ToInt32(Console.ReadLine());
            int c = 0;
            c = a + b;
            Console.WriteLine("the third angle of trangle" + b);
        }
    }
}
