using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = Math.PI;
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter last 4 digit of your faculty number");
            int facultyNumber = int.Parse(Console.ReadLine());
            double uniqueNumber = ((age + 10) * facultyNumber) / PI;
            Console.WriteLine($"You will be {age + 10} years old after 10 years. And your unique number is {Math.Round(uniqueNumber,4)}.");
        }
    }
}
