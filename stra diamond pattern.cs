using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class stra_diamond_pattern
    {
        static void Main(string[] args)
        {
            int num = 8, count = 1;
            count = num - 1; 
            for (int i = 1; i <=num; i++) 
            {
                for (int j = 1; j <= count; j++)
                {

                    Console.Write(" ");
                }
                count--;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }
            count = 1;
            for (int i = 1; i <= num - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int j = 1; j <= 2 * (num - i) - 1; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            
            
            
            
            //Console.WriteLine();
        }
    }
}
