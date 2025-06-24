using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderReceipt
{
    class Program
    {

        const decimal PRICE_PER_BLENDER = 39.95m;
        const decimal TAX_RATE = 0.07m;

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your street address: ");
            string streetAddress = Console.ReadLine();

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.Write("Enter your state: ");
            string state = Console.ReadLine();

            Console.Write("Enter your zip code: ");
            string zipCode = Console.ReadLine();

            Console.Write("Enter the quantity of blenders ordered: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid quantity entered. Please enter a non-negative integer.");
                return;
            }

            decimal amountDueBeforeTax = quantity * PRICE_PER_BLENDER;
            decimal salesTax = amountDueBeforeTax * TAX_RATE;
            decimal netDue = amountDueBeforeTax + salesTax;

            Console.WriteLine("\n--- Magic Blender Company ---");
            Console.WriteLine($"{name}");
            Console.WriteLine($"{streetAddress}");
            Console.WriteLine($"{city}");
            Console.WriteLine($"{state}");
            Console.WriteLine($"{zipCode}");

            Console.WriteLine($"\n {quantity} blenders ordered @${PRICE_PER_BLENDER:F2} each ");

            Console.WriteLine($"\n Amount Due Before Tax: ${amountDueBeforeTax:F2}");
            Console.WriteLine($"Sales Tax: ${salesTax:F2}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Net Due: ${netDue:F2}");

            Console.ReadLine();
        }
    }
}
