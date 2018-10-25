using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSomeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] str = new string[100];
            Random rng = new Random();

            Console.WriteLine("Даден е низ от 100 случайни букви на кирилица. Програмата показва кои гласни са широки, тесни и съставни, както и кои съгласни са звучни, беззвучни и сонорни.");
            Console.WriteLine("-------------------------------------------------------");

            for (int i = 0; i < 100; i++)
            {
                str[i] = ((char)rng.Next(1072, 1103)).ToString();
                Console.Write(str[i]);
            }

            Console.WriteLine("\n-------------------------------------------------------");

            for (int i = 0; i < 100; i++)
            {
                if ((str[i] == "а") || (str[i] == "o") || (str[i] == "е")) 
                    Console.WriteLine($"Буквата ({str[i]}) е широка гласна и се намира под номер {i}.");
                if ((str[i] == "и") || (str[i] == "у") || (str[i] == "ъ")) 
                    Console.WriteLine($"Буквата ({str[i]}) e тясна гласна и се намира под номер {i}.");
                if ((str[i] == "ю") || (str[i] == "я")) 
                    Console.WriteLine($"Буквата ({str[i]}) е съставна гласна и се намира под номер {i}.");
                if ((str[i] == "п") || (str[i] == "ф") || (str[i] == "к") || (str[i] == "т") || (str[i] == "ш") || (str[i] == "с") || (str[i] == "x") || (str[i] == "ц"))
                    Console.WriteLine($"Буквата ({str[i]}) е беззвучна съгласна и се намира под номер {i}.");
                if ((str[i] == "л") || (str[i] == "м") || (str[i] == "н") || (str[i] == "р"))
                    Console.WriteLine($"Буквата ({str[i]}) е сонорна съгласна и се намира под номер {i}.");
                if ((str[i] == "б") || (str[i] == "в") || (str[i] == "г") || (str[i] == "д") || (str[i] == "ж") || (str[i] == "з") || (str[i] == "ч"))
                    Console.WriteLine($"Буквата ({str[i]}) е звучна съгласна и се намира под номер {i}.");
            }
        }
    }
}
