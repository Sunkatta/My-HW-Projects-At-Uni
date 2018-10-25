using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint ticket;
            uint br_lucky = 0;
            uint br_unlucky = 0;

            for (ticket=0; ticket < 1000000; ticket++)
            {
                if ((ticket / 100000 + ticket % 100000 / 10000 + ticket % 100000 % 10000 / 1000) == (ticket % 100000 % 10000 % 1000 / 100 + ticket % 100000 % 10000 % 1000 % 100 / 10 + ticket % 10))
                {
                    Console.WriteLine(ticket);
                    br_lucky++;
                }
                else br_unlucky++;
            }

            Console.WriteLine("The number of lucky tickets is: " + br_lucky);
            Console.WriteLine("The number of unlucky tickets is: " + br_unlucky);
            Console.WriteLine($"Total tickets: {br_lucky+br_unlucky}");
        }
    }
}
