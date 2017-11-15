using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSomeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Random rng = new Random();

            Console.WriteLine("Here are 100 randomly generated numbers in the interval between 0 and 132.");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rng.Next(132);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Choose what you want to do with them (type in the letter): ");
            Console.WriteLine("a) Display the numbers that have even indexes.");
            Console.WriteLine("b) Display the numbers that are odd and have odd indexes.");
            Console.WriteLine("c) Display the numbers that are divided by 3 without a remainder.");
            Console.WriteLine("d) Display the numbers that are divided by 7 and have 1 as remainder.");
            Console.WriteLine("e) Display the numbers that are in the interval between 26 and 100.");
            Console.WriteLine("f) Display the numbers that are not in the interval between 26 and 100.");
            Console.WriteLine("----------------------------------------------------------");

            char letter = char.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------");

            switch (letter)
            {
                case 'a':
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine($"{arr[i]} has index {i}.");
                    }
                    break;
                case 'b':
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] % 2) != 0 && (i % 2 != 0))
                            Console.WriteLine($"{arr[i]} is odd and has index {i}.");
                    }
                    break;
                case 'c':
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 3 == 0)
                            Console.WriteLine($"{arr[i]} is divided by 3 without a remainder.");
                    }
                    break;
                case 'd':
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 7 == 1)
                            Console.WriteLine($"{arr[i]} is divided by 7 with a remainder of 1.");
                    }
                    break;
                case 'e':
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] >= 26) && (arr[i] <= 100))
                            Console.WriteLine($"{arr[i]} is between 26 and 100.");
                    }
                    break;
                case 'f':
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] < 26) || (arr[i] > 100))
                            Console.WriteLine($"{arr[i]} is not between 26 and 100.");
                    }
                    break;
                default:
                    Console.Write("Enter correct letter: ");
                    letter = char.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
