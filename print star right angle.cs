using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class print_star_right_angle
    {
        static void Main(string[] args)
        {
            for (int i = 8; i >=1;  i--) //row
            {
              for (int j = 1; j <=i; j++) //colume
                {
                    Console.Write("*");
                }
              Console.WriteLine();
            }
        }
    }
}
