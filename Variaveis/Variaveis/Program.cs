using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            Minima = 8,
            Media,
            Maxima
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            #region Numericas Integrais
            //Integral assinado
            /*sbyte num1 = 10; // 8 Bits de -128 a 127
            short num2 = 20; // 16 Bits de -32.768 a 32.767
            int num3 = 30; // 32 Bits de -2.147.483.648 a 2.147.483.647
            long num4 = 40L; // 64 Bits de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //Integral sem sinal
            byte num5 = 10; // 8 Bits de 0 a 255
            ushort num6 = 20; // 16 Bits de 0 a 65.535
            uint num7 = 30; // 32 Bits de 0 a 4.294.967.295
            ulong num8 = 40L; // 64 Bits de 0 a 18.446.744.073.709.551.615

            sbyte numero;
            numero = 100;
            numero = num1; */
            #endregion

            #region Numericas Reais
            /*float real1 = 100.5f; // 32 Bits de 1,5 x 10^-45 a 3,4 x 10^38
            double real2 = 150.98;  // 64 Bits de 5,0 x 10^-324 a 1,7 x 10^308
            decimal real3 = 50.2m; // 128 Bits de 1,0 x 10^-28 a 7,9 x 10^28

            double valor;
            valor = real2;
            */
            #endregion

            #region Caracteres
            //Código do caractere
            /*  char letra = '\u0041'; // 16 Bits de 0 a 65.535, representando um caractere único
              char escape = '\n'; // Caractere de escape para nova linha
              char literal = 'A'; // Caractere literal
            */
            #endregion

            #region Booleanas

            /* bool verificar = false;
             verificar = true;
            */
            #endregion

            #region String

            // string word = "Salve\n Oi";
            // string word2 = null;
            #endregion

            #region Var

            /*var nome = "Pedro";
            var idade = 18;
            var estudando = true;
            */
            #endregion

            #region Object

            /*object obj = "Eu";
            obj = 18;
            obj = true;
            */
            #endregion

            #region Constantes

            //const double pi = 3.1415;
            //const string nome = "Pedro";
            #endregion

            #region Enumeração

            //Notas notasAlunos = Notas.Media;

            #endregion

            #region Struct
           /* Pessoa p1 = new Pessoa();
            p1.nome = "Pedro";
            p1.idade = 18;
            p1.altura = 1.73;

            Pessoa p2 = new Pessoa()
            {
                nome = "Pedro",
                idade = 18,
                altura = 1.73
            };
           */
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
