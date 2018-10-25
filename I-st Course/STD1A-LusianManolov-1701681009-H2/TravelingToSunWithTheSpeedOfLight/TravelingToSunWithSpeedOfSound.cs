using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingToSunWithTheSpeedOfLight
{
    class Program
    {
        static void Main(string[] args)
        {
            const double speedOfSound = 1225.044; //km/h
            const long distToSun = 149600000; //km
            double timeNeeded = Math.Round(distToSun / speedOfSound); //h

            Console.WriteLine($"The time needed to travel from the Earth to the Sun is {timeNeeded} hours, or {Math.Floor(timeNeeded/8760)} years and {Math.Floor(((timeNeeded/8760)-(Math.Floor(timeNeeded/8760)))*365)} days.");
        }
    }
}
