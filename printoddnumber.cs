using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class printoddnumber
    {
        static void Main(string[] args) 
        {                                        //print odd number from 1-50 (if)
         for (int i=1; i<=50;i=i+2) 
            {
                if (i%2!=0) 
                {

                    Console.WriteLine(i);
                }
            
            
            }
        }
    }
}
