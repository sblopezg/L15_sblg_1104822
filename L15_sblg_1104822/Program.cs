using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_SBL_1104822
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar la matriz 
            int[,] matriz = new int[40, 50];
            int sumatotal = 0;

            //para generar numero random
            Random r = new Random();

            //para llenar matriz 
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    matriz[i, j] = r.Next(-10, 10);
                }
            }

            //para recorrer la matriz 
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    //para ir imprimiendo la matriz 
                    Console.Write(" " + matriz[i, j]);
                    //para ir sumando los valores
                    sumatotal += matriz[i, j];
                }
                Console.WriteLine();
            }

            //para ir imprimiendo la matriz
            Console.WriteLine("\n\nEl resultado de toda la matriz es: " + sumatotal);
            Console.ReadKey();

        }
    }
}
