using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 15; 
            int width = 25; 

            int area = length * width;

            Console.WriteLine("The floor space is " + area + " square feet.");

            Console.ReadLine();
        }
    }
}
