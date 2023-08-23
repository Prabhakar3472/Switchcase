using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class right_angle_trangle_pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=8; i++) //row
            {
              for (int j = 1; j <=i; j++) //column
                {
                    Console.Write("*");
                }
              Console.WriteLine();
            }
        }
    }
}
