using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class forpower
    {
        static void Main(string[] args) 
        {
            int num = 2;
            int exp = 3;
            int power = 1;
            int i = 1;
            while (i<=exp) 
            {
                power = power * num;
                i++;
            }
            Console.WriteLine(power);
        }

    }
}
