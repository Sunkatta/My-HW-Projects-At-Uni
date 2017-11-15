using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You will be {age+10} years old after 10 years.");
        }
    }
}
