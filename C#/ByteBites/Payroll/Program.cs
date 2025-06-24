using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Social Security number: ");
            string ssn = Console.ReadLine();

            Console.Write("Enter your hourly pay rate (e.g., 20.50): ");
            double hourlyPayRate;
            while (!double.TryParse(Console.ReadLine(), out hourlyPayRate) || hourlyPayRate <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number for hourly pay rate: ");
            }

            Console.Write("Enter the number of hours worked: ");
            double hoursWorked;
            while (!double.TryParse(Console.ReadLine(), out hoursWorked) || hoursWorked < 0)
            {
                Console.Write("Invalid input. Please enter a non-negative number for hours worked: ");
            }

            double grossPay = hourlyPayRate * hoursWorked;
            double federalWithholdingTax = 0.15 * grossPay;
            double stateWithholdingTax = 0.05 * grossPay;
            double netPay = grossPay - federalWithholdingTax - stateWithholdingTax;

            Console.WriteLine();
            Console.WriteLine($"Payroll Summary for: {name}");
            Console.WriteLine($"Social Security Number: {ssn}");
            Console.WriteLine($"Hourly Pay Rate: ${hourlyPayRate:F2}");
            Console.WriteLine($"Hours Worked: {hoursWorked:F2}");
            Console.WriteLine();
            Console.WriteLine($"Gross Pay: ${grossPay:F2}");
            Console.WriteLine($"Federal Withholding Tax (15%): ${federalWithholdingTax:F2}");
            Console.WriteLine($"State Withholding Tax (5%): ${stateWithholdingTax:F2}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Net Pay: ${netPay:F2}");

            Console.ReadLine();
        }
    }
}
