using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static int GetMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            } else return c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers.");
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is:"+ GetMax(a, b, c));
        }
    }
}
