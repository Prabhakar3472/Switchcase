using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class findoutodd1to10
    {
        static void Main(string[] args) 
        {
            int sum = 0;
            for (int i = 1; i <=10; i++) 
            {
              if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                    sum++;
                
                } 
            }       Console.WriteLine("total odd"+sum);
        
        }
    }
}
