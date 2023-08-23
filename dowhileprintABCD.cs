using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class dowhileprintABCD
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4;  i++) 
            {
                char c = 'A';
               for (int j = 1; j <=i; j++) 
                {
                    Console.Write(c++);
                }
                  Console.WriteLine();
            }
        }
    }
}
