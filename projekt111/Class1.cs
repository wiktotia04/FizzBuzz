using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt111
{
    internal class FizzBuzz
    {
        private int upper;
        public FizzBuzz(int upper)
        {
            this.upper = upper;
        }
    

        public void Display()
        {
            for(int i = 1; i < upper; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
                
               
               
            }
        }
    }
}
