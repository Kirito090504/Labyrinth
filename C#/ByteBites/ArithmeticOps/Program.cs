using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Arithmetic Operations");
            Console.WriteLine("---------------------------");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1/2/3/4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number 1: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double total;

            switch (choice)
            {
                case 1:
                    total = num1 + num2;
                    Console.WriteLine($"The total is: {total}");
                    break;
                case 2:
                    total = num1 - num2;
                    Console.WriteLine($"The total is: {total}");
                    break;
                case 3:
                    total = num1 * num2;
                    Console.WriteLine($"The total is: {total}");
                    break;
                case 4:
                    total = num1 / num2;
                    Console.WriteLine($"The total is: {total}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
 
