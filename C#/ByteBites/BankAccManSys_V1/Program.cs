using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tenchie M. Adolfo
namespace BankAccManSys
{
    class Program
    {
        static void Main(string[] args)
        {
            double Balance = 1000;
            double total_balance =0;
            double withdrawn;


            Console.WriteLine("Bank Account Management System");
            Console.WriteLine("---------------------------");

            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Funds");
            Console.WriteLine("3. Withdraw Funds");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1/2/3/4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write($"Total Balance: {Balance}");
                        break;
                    case 2:
                        Console.Write($"How much would you like to deposit?");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        total_balance = Balance + deposit;

                        Console.Write($"Total Balance: {total_balance}"); 

                        break;
                    case 3:
                        Console.Write($"How much would you like to withdraw?");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw < Balance)
                        {
                            withdrawn = withdraw - total_balance;
                            Console.Write($"Succesfully Withdrawn: {withdrawn}");

                        }
                        else
                        {
                            Console.Write("Your withdrawal request exceeds your balance!");
                        }

                        break;
                    case 4:
                        Console.Write($"Closing..");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            Console.ReadLine();
            
        }
    }
}