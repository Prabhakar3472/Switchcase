using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class sum
    {
            //print 1-10 & its sum

        static void Main(string[] args) 
        {
            int sum = 0;
            for (int i = 1; i <=10; i++) 
            
            {
             Console.WriteLine(i);
                
               sum = sum + i;
            }
            Console.WriteLine(sum);
        }


    }
}
