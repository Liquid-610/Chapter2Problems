using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            double gross;
            double fed;
            double state;



            String input;
            Console.Write("Enter your name:"); input = Console.ReadLine();

            Console.Write("Social Security number:"); input = Console.ReadLine();

            Console.Write("Hourly pay rate:"); input = Console.ReadLine();

            Console.Write("Hours worked:"); input = Console.ReadLine();


            Console.Write("Payroll Summary for:"); input = Console.ReadLine();
            Console.Write("SSN:"); input = Console.ReadLine();
            Console.Write("You earned {0} at {1} per hour"); input = Console.ReadLine();

            Console.Write("Gross pay:"); input = Console.ReadLine();
            Console.Write("Federal withholding:"); input = Console.ReadLine();
            Console.Write("State withholding:"); input = Console.ReadLine();

        }
    }
}
