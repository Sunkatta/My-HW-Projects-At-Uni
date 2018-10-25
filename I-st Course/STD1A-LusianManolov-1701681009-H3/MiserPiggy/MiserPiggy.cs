using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort sum1 = 0;
            ushort sum2 = 0;
            ushort sum3 = 0;

            Console.WriteLine("Hey, piggies! Enter your names:");
            Console.Write("Piggy 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Piggy 2: ");
            string name2 = Console.ReadLine();
            Console.Write("Piggy 3: ");
            string name3 = Console.ReadLine();

            foreach(char a in name1)
            {
                System.Convert.ToInt32(a);
                sum1 += a;
            }

            foreach (char b in name2)
            {
                System.Convert.ToInt32(b);
                sum2 += b;
            }

            foreach (char c in name3)
            {
                System.Convert.ToInt32(c);
                sum3 += c;
            }

            if (sum1 > sum2 && sum1 > sum3)
            {
                if (sum2 > sum3)
                    Console.WriteLine($"The name-wealthiest pig is {name1} ({sum1}) followed by {name2} ({sum2}) and last is {name3} ({sum3}).");
                else Console.WriteLine($"The name-wealthiest pig is {name1} ({sum1}) followed by {name3} ({sum3}) and last is {name2} ({sum2}).");
            }
            else if (sum2 > sum1 && sum2 > sum3)
            {
                if(sum1>sum3)
                    Console.WriteLine($"The name-wealthiest pig is {name2} ({sum2}) followed by {name1} ({sum1}) and last is {name3} ({sum3}).");
                else Console.WriteLine($"The name-wealthiest pig is {name2} ({sum2}) followed by {name3} ({sum3}) and last is {name1} ({sum1}).");
            }
            else if(sum1>sum2)
                Console.WriteLine($"The name-wealthiest pig is {name3} ({sum3}) followed by {name1} ({sum1}) and last is {name2} ({sum2}).");
            else Console.WriteLine($"The name-wealthiest pig is {name3} ({sum3}) followed by {name2} ({sum2}) and last is {name1} ({sum1}).");
        }
    }
}
