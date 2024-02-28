using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class FizzBuzz
    {
        int upperLimit = 10;

        public void Check()
        {

            for(int i = 0; i<=upperLimit; i++)
            {
                bool byFive = false;
                bool byThree = false;
                //Console.Write(i);
                if(i%3 == 0)
                {
                    Console.Write("Fizz");
                    byThree = true;
                }
                if(i%5 == 0)
                {
                    Console.Write("Buzz");
                    byFive = true;
                }
                if(!byFive && !byThree)
                {
                    Console.Write(i);
                }
                Console.Write("\n");


            }

        }
        public FizzBuzz(int _upperLimit)
        {
            this.upperLimit = _upperLimit;
        }

    }
}
