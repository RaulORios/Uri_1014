using System;
using System.Globalization;

namespace Uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            decimal consumo = x / y;

            Console.WriteLine($"{consumo.ToString("F3",CultureInfo.InvariantCulture)} km/l");           

        }
    }
}
