using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetor Array unidimensional
            //int numero = 0;
            //int[] numeros = new int[5];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //numeros[2] = 55;

            //string[] nomes = new string[3];

            //string[] nomes = { "Jardel", "Mandel", "Cardoso" };

            //nomes[0] = "Jardel";
            //nomes[1] = "Mandel";
            //nomes[2] = "cardoso";

            //Console.WriteLine(numeros[2]);
            #endregion

            #region Matriz Array bidimensional
            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            #endregion

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.WriteLine("[" + numeros[0, 2] + "]");

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]");

            string[,] nomes =
            {
                {"jardel", "Mandel", "Cardoso" },
                {"Jardel", "Mandel", "Cardoso" }
            };
            Console.Write("[" + nomes[0, 0] + "]");
            Console.Write("[" + nomes[0, 1] + "]");
            Console.WriteLine("[" + nomes[0, 2] + "]");

            Console.Write("[" + nomes[1, 0] + "]");
            Console.Write("[" + nomes[1, 1] + "]");
            Console.WriteLine("[" + nomes[1, 2] + "]");

            Console.ReadKey();
        }
    }
}
