using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int br = 0;

            do
            {
                Console.Write("Enter a number between 1 and 255 (when you are ready enter 0):");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0 && number >= 1 && number <= 255)
                {
                    sum += number;
                    br++;
                }

            } while (number != 0);

            if (sum == 0)
            {
                Console.WriteLine("There are no even numbers between 1 and 255!");
            }
            else
            {
                Console.WriteLine("The average sum of the even numbers is: " + (double)sum / br) ;
            }
        }
    }
}
