using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDice_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if(roll1 == roll2 && roll1 == roll3)
            {
                total += 6;
                Console.WriteLine("Triple! +6 points!");
            }

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                total += 2;
                Console.WriteLine("Double! +2 points!");
            }

            if (total > 15)
            {
                Console.WriteLine($"You Lose!: {total}");
            }
            else
            {
                Console.WriteLine($"You Win!: {total}");
            }
            
            Console.ReadLine();
        }
    }
}
