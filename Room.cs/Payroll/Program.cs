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

            String name, ssn, hpr, hw, input;
            int hourspay, hoursworked;

            double gross = hourspay * hoursworked;
            double fed = gross * 0.15;
            double state = gross * 0.05;

            
            Console.Write("Enter your name:"); name = Console.ReadLine();

            Console.Write("Social Security number:"); ssn = Console.ReadLine();

            Console.Write("Hourly pay rate:"); hpr = Console.ReadLine();

            Console.Write("Hours worked:"); hw = Console.ReadLine();


            Console.Write("Payroll Summary for:"); name = Console.ReadLine();
            Console.Write("SSN:"); ssn = Console.ReadLine();
            Console.Write("You earned {0} at {1} per hour"); hpr = Console.ReadLine();

            Console.Write("Gross pay:"); input = Console.ReadLine();
            Console.Write("Federal withholding:"); input = Console.ReadLine();
            Console.Write("State withholding:"); input = Console.ReadLine();

        }
    }
}
