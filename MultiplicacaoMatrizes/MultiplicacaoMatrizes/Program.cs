using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacaoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];

            int[,] matrizresul = new int[2, 2];

            Console.WriteLine("Preencha a primeira matriz");
            
            for(int linha = 0; linha < 2; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Insira um número para a posição [{linha},{coluna}] da primeira matriz:");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha a segunda matriz");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write($"Insira um número para a posição [{linha},{coluna}] da segunda matriz:");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Resultado da multiplicação das matrizes:");
            matrizresul[0,0] = (matriz1[0,0]) * (matriz2[0,0]) + (matriz1[0,1]) * (matriz2[1, 0]) + (matriz1[0, 2]) * (matriz2[2, 0]);
            matrizresul[1,0] = (matriz1[1, 0]) * (matriz2[0, 0]) + (matriz1[1, 1]) * (matriz2[1, 0]) + (matriz1[1, 2]) * (matriz2[2, 0]);
            matrizresul[0,1] = (matriz1[0, 0]) * (matriz2[0, 1]) + (matriz1[0, 1]) * (matriz2[1, 1]) + (matriz1[0, 2]) * (matriz2[2, 1]);
            matrizresul[1,1] = (matriz1[1, 0]) * (matriz2[0, 1]) + (matriz1[1, 1]) * (matriz2[1, 1]) + (matriz1[1, 2]) * (matriz2[2, 1]);

            Console.WriteLine("[" + matrizresul[0,0] + " " + matrizresul[0, 1] + "]");
            Console.WriteLine("[" + matrizresul[1, 0] + " " + matrizresul[1, 1] + "]");

            Console.ReadKey();
        }
    }
}
