using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class whilefactorialnumber
    {
        static void Main(string[] args) 
        {
            int i = 5;
            int fact = 1;
            while (i >=1) 
            {
              fact=fact*i;
                i--;
            }
            Console.WriteLine(fact);
        }
    }
}
