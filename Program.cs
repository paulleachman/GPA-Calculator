using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { double WTTRAIN = 4.0;
            double SPANISH2 = 4.0;
            double HEALTH = 4.0;
            double ALGEBRA2 = 3.0;
            double ENGLISH10 = 4.0;
            double APUSH = 4.0;
            double CHEMISTRY = 4.0;
            double GPA = (WTTRAIN + SPANISH2 + HEALTH + ALGEBRA2 + ENGLISH10 + APUSH + CHEMISTRY) / 7;

            Console.WriteLine("GPA:");
            Console.WriteLine(GPA);

        }
    }
}
