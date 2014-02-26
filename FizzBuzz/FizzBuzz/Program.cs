using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 5 == 0)
                {
                    Console.Write("{0}Fizz", i);

                }

                if (i % 10 == 0)
                {
                    Console.Write("{0}Buzz", i);

                }

                if (i % 10 == 0 & i % 5 == 0)
                {
                    Console.Write("{0}FizzBuzz");

                }


            }    

            
        }
    }
}
