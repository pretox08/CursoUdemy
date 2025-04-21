using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operadores Aritméticos
            /*
                int n1 = 10;
                int n2 = 5;
                int soma = n1 + n2;
                int subtracao = n1 - n2;
                int multiplicacao = n1 * n2;
                int divisao = n1 / n2;
                int resto = n1 % n2;

                Console.WriteLine("Soma: " + soma);
                Console.WriteLine("Subtração: " + subtracao);
                Console.WriteLine("Multiplicação: " + multiplicacao);
                Console.WriteLine("Divisão: " + divisao);
                Console.WriteLine("Resto: " + resto);
            */
            #endregion

            #region Ordem de Precedência
            /*
             double num1 = 100;
             double num2 = 10;
             double num3 = 5;

             double resp = (num1 + num2) * (num3 / 2);
             Console.WriteLine(resp);
            */
            #endregion

            #region Incremento e Decremento
            /*
             int n1 = 10;

             Console.WriteLine(++n1); // Pré-incremento
             Console.WriteLine(--n1); // Pré-decremento

             Console.WriteLine(n1++); // Pós-incremento
             Console.WriteLine(n1--); // Pós-decremento
            */
            #endregion

            #region Concatenação

            //string nome = "Pedro " + "Carvalho " + 2006;
            //Console.WriteLine(nome);
            #endregion

            #region Atribuição
            /*
            int a = 70;

            a = a + 20; // Atribuição simples
            a += 20; // Atribuição composta de soma
            a -= 20; // Atribuição composta de subtração
            a *= 20; // Atribuição composta de multiplicação
            a /= 20; // Atribuição composta de divisão
            a %= 20; // Atribuição composta de resto

            Console.WriteLine(a);

            string nome = "Pedro";

            nome = nome + " Carvalho";
            Console.Write(nome);
            */
            #endregion

            #region Operadores de igualdade
            /*
            bool resp = 100 == 50 * 2; // Igualdade

            bool resp2 = 200 != 100 + 100; // Desigualdade

            string nome = "Pedro";
            bool resp3 = nome == "Paulo"; 

            Console.WriteLine(resp3);
            */
            #endregion

            #region Operadores Relacionais
            /*
            bool res = 10 > 5; // Maior que
            bool res2 = 10 < 5; // Menor que
            bool res3 = 10 >= 5; // Maior ou igual
            bool res4 = 10 <= 5; // Menor ou igual
            bool res5 = 10 == 5; // Igual

            Console.WriteLine($"{res}, {res2}, {res3}, {res4}, {res5}");
            */
            #endregion

            #region Operadores Lógicos
            /*
            bool res1 = 100 > 50;
            bool res2 = 50 != 50;

            bool final = res1 && res2; // E lógico
            bool final2 = res1 || res2; // Ou lógico
            */
            #endregion


            Console.ReadKey();
        }
    }
}
