using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            const double pi = Math.PI;
            int radius = rand.Next(33, 188);

            double S = pi * radius * radius;

            Console.WriteLine("The radius of the circle is:"+radius);
            Console.WriteLine("The area of the circle is:"+Math.Round(S,2));
        }
    }
}
