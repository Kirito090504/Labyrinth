using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Tenchie M. Adolfo
namespace Quiz_Generator
{
    class Program
    {

        static void Main(string[] args)
        {
            int total_score = 0;


            Console.Write("Quiz Generator\n");
            Console.Write("-------------------\n");
            Console.Write("1. What is the largest plane in our solar system? \n");
            Console.Write("a) Earth \nb) Saturn\nc) Jupiter\n");
            Console.Write("Enter you choice for number 1:");
            string num1 = Console.ReadLine().ToUpper();
            if (num1 == "C")
            {
                total_score++;
            }

            Console.Write("2. Which of the following authors wrote the book 'To Kill a Mockingbid'\n");
            Console.Write("a) F. Scott Fitzgerald \nb) Harper Lee \nc) Jane Austen \n");
            Console.Write("Enter you choice for number 2:");
            string num2 = Console.ReadLine().ToUpper();
            if (num2 == "B")
            {
                total_score++;
            }

            Console.Write("3. What is the chemical symbol for gold?\n");
            Console.Write("a) Ag \nb) Au \nc) Hg \n");
            Console.Write("Enter you choice for number 3:");
            string num3 = Console.ReadLine().ToUpper();
            if (num3 == "B")
            {
                total_score++;
            }

            Console.Write("4. Which of the following musicians was known as the King of Rock and Roll?\n");
            Console.Write("a) Chuck Berry \nb) Elvis Presley \nc) Little Richard \n");
            Console.Write("Enter you choice for number 4:");
            string num4 = Console.ReadLine().ToUpper();
            if (num4 == "B")
            {
                total_score++;
            }

            Console.Write("5. What is the capital of France?\n");
            Console.Write("a) Berlin \nb) Paris \nc) Rome \n");
            Console.Write("Enter you choice for number 5:");
            string num5 = Console.ReadLine().ToUpper();
            if (num5 == "B")
            {
                total_score++;
            }

            Console.Write("6. Which of the following ancient civilizations built the Great Pyramid of Giza?\n");
            Console.Write("a) Egyptians \nb) Greeks \nc) Romans \n");
            Console.Write("Enter you choice for number 6:");
            string num6 = Console.ReadLine().ToUpper();
            if (num6 == "A")
            {
                total_score++;
            }

            Console.Write("7. What is the largest mammal on Earth?\n");
            Console.Write("a) Blue Whale \nb) African Elephant \nc) Hippopotamus \n");
            Console.Write("Enter you choice for number 7:");
            string num7 = Console.ReadLine().ToUpper();
            if (num7 == "A")
            {
                total_score++;
            }

            Console.Write("8. Who painted the famous painting The Starry Night?\n");
            Console.Write("a) Leonardo Da Vinci \nb) Vincent Van Gogh \nc) Claude Monet \n");
            Console.Write("Enter you choice for number 8:");
            string num8 = Console.ReadLine().ToUpper();
            if (num8 == "B")
            {
                total_score++;
            }

            Console.Write("9. What is the smallest country in the world, both in terms of population and land area?\n");
            Console.Write("a) Vatican City \nb) Monaco \nc) Nauru\n");
            Console.Write("Enter you choice for number 9:");
            string num9 = Console.ReadLine().ToUpper();
            if (num9 == "A")
            {
                total_score++;
            }

            Console.Write("10. Which of the following elements is a noble gas?\n");
            Console.Write("a) Oxygen \nb) Nitrogen \nc) Neon \n");
            Console.Write("Enter you choice for number 10:");
            string num10 = Console.ReadLine().ToUpper();
            if (num10 == "C")
            {
                total_score++;
            }

            Console.WriteLine($"Final Score:{total_score}");

            Console.ReadLine();
        }
    }
}
