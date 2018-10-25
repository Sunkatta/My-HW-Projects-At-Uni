using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The4thDigitInANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 7-digit number: ");
            int number = int.Parse(Console.ReadLine());
            int digit4 = number % 1000000 % 100000 % 10000 / 1000;

            Console.WriteLine($"The 4th digit of {number} is {digit4}");
        }
    }
}
