using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                answer = Console.ReadLine();

                if (answer == "no")
                {
                    Environment.Exit(0);
                }

            } while (answer != "yes");

            Console.Write("Enter a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b=");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a character for mathematic operation: '+','-','*','/'");
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    double sum = (a + b) + (a + b) * 0.1;
                    Console.WriteLine("The sum plus 10% is: {0:F2}", Math.Round(sum, 2));
                    break;
                case '-':
                    double div = Math.Max(a, b) * Math.Max(a, b) - Math.Min(a, b);
                    Console.WriteLine("The max*max-min of a and b is: {0:F2}", Math.Round(div, 2));
                    break;
                case '*':
                    double mult = a * Math.Sqrt(b);
                    Console.WriteLine("a*Sqrt(b)= {0:F2}", Math.Round(mult, 2));
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("ERROR! Dividing by 0 is forbidden!");
                    }
                    break;
                default: Console.WriteLine("Incorrect character."); break;
            }
        }
    }
}
