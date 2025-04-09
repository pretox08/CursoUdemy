using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            byte num1 = 100;
            ushort num2;

            num2 = num1; // Conversão implícita de byte para ushort


            float num3 = 1250.45f;
            double num4 = num3; // Conversão implícita de float para double

            num3 = num1; // Conversão implícita de float para byte

            char letra = 'C';
            int numero = letra; // Conversão implícita de char para int
            #endregion

            #region Conversão Explícita

            ushort exnum1 = 500;
            byte exnum2 = (byte)exnum1; // Conversão explícita de ushort para byte

            float exnum3 = 2500.896f;
            int exnum4 = (int)exnum3; // Conversão explícita de float para int


            char exletra = (char)97;
            #endregion

            #region Método Parse

            string mptexto = "2006";
            int mpnumero = int.Parse(mptexto); // Conversão de string para int

            byte mpnum1 = byte.Parse("120"); // Conversão de string para byte

            double mpnum2 = double.Parse("125623,57");

            float mpnum3 = float.Parse("457,75"); // Conversão de string para float
            #endregion

            #region Convert

            string convTexto = Convert.ToString(2500); // Conversão de int para string

            double convNum1 = Convert.ToDouble(false); // Conversão de bool para double

            int convNum2 = Convert.ToInt32('C'); // Conversão de char para int

            #endregion



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
