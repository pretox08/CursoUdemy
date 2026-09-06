using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array Unidimensional
            //declarando um array
            int[] numeros = new int[5];

            //posiçoes
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;

            string[] nomes = new string[3];

            nomes[0] = "Peh";
            nomes[1] = "Tuh";
            nomes[2] = "Bia";

            //array sem numero exato de posicoes
            string[] nomes2 = { "Peh", "Tuh", "Bia", "Dudao" };
            #endregion

            #region Array Bidimensional

            int[,] numbers = new int[2, 3];

            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[0, 2] = 3;

            numbers[1, 0] = 3;
            numbers[1, 1] = 2;
            numbers[1, 2] = 1;

            Console.Write("[" + numbers[0, 0] + "]");
            Console.Write("[" + numbers[0, 1] + "]");
            Console.WriteLine("[" + numbers[0, 2] + "]");

            Console.Write("[" + numbers[1, 0] + "]");
            Console.Write("[" + numbers[1, 1] + "]");
            Console.WriteLine("[" + numbers[1, 2] + "]");

            string[,] pessoas =
            {
                {"Pedro", "Artur", "Duda", "Bia" },
                {"Guina", "Vitor", "Ale", "Davi" }
            };

            Console.WriteLine(pessoas[0, 0]);

            #endregion



            Console.ReadKey();
        }
    }
}
