using System;
using System.Globalization;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calc = Area(raio);

            Console.WriteLine("Area: " + calc);
        }

        static double Area(double r)
        {
            return Math.PI * (r * r);
        }


    }
}

