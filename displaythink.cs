using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class displaythink
    {
        static void Main(string[] args) 
        {
            int i = 1;
            for(i=1; i<=20;  i++) 
            {
              if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Think Quotient");
                }
              else if (i % 3 == 0)
                {
                    Console.WriteLine("Think");
                }
              else if (i % 5 == 0) 
                {
                    Console.WriteLine("Quotient");
                }
              

          


            }
        }
    }
}
