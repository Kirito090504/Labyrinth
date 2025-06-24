using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tenchie M. Adolfo
namespace Online_Store_Discount_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Online Store Discount Calculator\n");
            Console.Write("---------------------------------\n");
            Console.Write("Enter your membership status (Premium/Regular/None): ");
            string memStat = Console.ReadLine();

            Console.Write("Enter your total purchase amount: $");
            decimal purchaseAmount = Convert.ToDecimal(Console.ReadLine());

            decimal discount = CalculateDiscount(memStat, purchaseAmount);
            decimal finalAmount = purchaseAmount - discount;

            Console.WriteLine($"Discount: ${discount:F2}");
            Console.WriteLine($"Final Amount to be Paid: ${finalAmount:F2}");

            Console.ReadLine();
        }

        static decimal CalculateDiscount(string memStat, decimal purchaseAmount)
        {
            decimal discount = 0;

            switch (memStat.ToLower())
            {
                case "premium":
                    discount = purchaseAmount * 0.20m;
                    break;
                case "regular":
                    discount = purchaseAmount * 0.10m;
                    break;
                case "none":
                    discount = 0;
                    break;
                default:
                    Console.WriteLine("Invalid membership status. No discount applied.");
                    return 0;
            }

            if (purchaseAmount > 500)
            {
                discount += (purchaseAmount - discount) * 0.05m;
            }
            else if (purchaseAmount >= 300 && purchaseAmount <= 500)
            {
                discount += (purchaseAmount - discount) * 0.03m;
            }

            return discount;

            Console.ReadLine();
        }
    }
}
