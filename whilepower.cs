using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class whilepower
    {
        static void Main(string[] args) 
        {
            int num = 2;
            int expo = 3;
            int power = 1;
            for(int i=1; i<=expo; i++) 
            {
                power = power * num;
            }
            Console.WriteLine(power);
        }
    }
}
