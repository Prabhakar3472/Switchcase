using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class whilesum
    {
        static void Main(string[] args) 
        {
            int i = 1;
            int sum = 0;
            while (i <= 10) 
            {
                Console.WriteLine(i);
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
