using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempC, tempF, tempK;

            Console.WriteLine("Digite a temperatura em Graus Celsius\n");
            tempC = double.Parse(Console.ReadLine());

            tempF = (tempC * 9 / 5) + 32;
            tempK = tempC + 273.15;

            Console.WriteLine($"\nA temperatura em Graus Fahrenheit é: {tempF}\n");
            Console.WriteLine($"A temperatura em Graus Kelvin é: {tempK}");

            Console.ReadKey();
        }
    }
}
