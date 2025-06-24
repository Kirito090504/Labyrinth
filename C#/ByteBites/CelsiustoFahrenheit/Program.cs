using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("---------------------");

            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter your choice (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter temperature value: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{temperature}°C is equal to {CelsiusToFahrenheit(temperature)}°F");
                    break;
                case 2:
                    Console.WriteLine($"{temperature}°F is equal to {FahrenheitToCelsius(temperature)}°C");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.ReadLine();
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
