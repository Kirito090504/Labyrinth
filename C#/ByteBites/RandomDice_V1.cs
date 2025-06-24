using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int totalScore = 0;
            int previousRoll = 0;
            int consecutiveRolls = 1;

            for (int i = 0; i < 3; i++)
            {
                int roll = random.Next(1, 7);
                Console.WriteLine($"Roll {i + 1}: {roll}");
                totalScore += roll;

                if (roll == previousRoll)
                {
                    consecutiveRolls++;
                    if (consecutiveRolls == 2)
                    {
                        totalScore += 2;
                        Console.WriteLine("Double roll! +2 points");
                    }
                    else if (consecutiveRolls == 3)
                    {
                        totalScore += 6;
                        Console.WriteLine("Triple roll! +6 points");
                    }
                }
                else
                {
                    consecutiveRolls = 1;
                }

                previousRoll = roll;
            }

            Console.WriteLine($"Total score: {totalScore}");

            if (totalScore > 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadLine();
        }
    }
}
