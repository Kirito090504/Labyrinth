using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tenchie M. Adolfo
namespace BankAccSystem
{
    class Program
    {
        static decimal balance = 1000;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bank Account Management System");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Funds");
                Console.WriteLine("3. Withdraw Funds");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        DepositFunds();
                        break;
                    case "3":
                        WithdrawFunds();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance:F2}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void DepositFunds()
        {
            Console.Write("Enter the amount to deposit: $");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal amount))
            {
                balance += amount;
                Console.WriteLine($"Deposit successful. Your new balance is: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void WithdrawFunds()
        {
            Console.Write("Enter the amount to withdraw: $");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal amount))
            {
                if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds. Please try again.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance:F2}");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
