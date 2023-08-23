using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class factorialgivennuber
    {
        static void Main(string[] args) 
        {
           int fact = 1;
           for(int i =1; i <=4; i++) 
            {
              fact = fact * i;  
            }
            Console.WriteLine(fact);

        }
    }
}
