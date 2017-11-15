using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double TriangleArea(double aTriangle, double h)
        {
            double sTriangle = (aTriangle * h) / 2;

            return sTriangle;
        }

        static double SquareArea(double aSquare)
        {
            double sSquare = aSquare * aSquare;

            return sSquare;
        }

        static double Radians(double angleDeg)
        {
            double angleRadians = Math.PI / 180 * angleDeg;

            return angleRadians;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose and option (triangle,square or radians):");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "triangle":
                    Console.Write("Enter a side:");
                    double aTriang = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height to that side:");
                    double h = double.Parse(Console.ReadLine());

                    Console.WriteLine("The area of this triangle is:"+TriangleArea(aTriang,h));
                    break;
                case "square":
                    Console.Write("Enter a side:");
                    double aSquare = double.Parse(Console.ReadLine());

                    Console.WriteLine("The area of this square is:"+SquareArea(aSquare));
                    break;
                case "radians":
                    Console.Write("Enter an angle in degrees:");
                    double degrees = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{degrees} degrees in radians is:"+Radians(degrees));
                    break;
                default:
                    Console.WriteLine("Incorrect data.");
                    break;
            }
        }
    }
}
