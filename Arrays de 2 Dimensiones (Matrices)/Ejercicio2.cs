using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_2_Dimensiones__Matrices_
{
    class Ejercicio2
    {
        //2- Cargar una matriz de 3x3. Mostrar la fila con mayor suma.
        public static void Ejecutar()
        {

            Console.WriteLine("Cargar los elementos de una matriz de 3x3");

            int[][] matriz = new int[3][];

            int[] sumas = new int[3];

            int max = int.MinValue;

            int[] filaMax = new int[3];

            for (int i = 0; i < matriz.Length; i++)
            {

                matriz[i] = new int[3];

                for (int j = 0; j < matriz[i].Length; j++)
                {

                    Console.WriteLine($"Ingrese el elemento [{i + 1}][{j + 1}]");

                    matriz[i][j] = int.Parse(Console.ReadLine());

                    sumas[i] += matriz[i][j];

                }

                if (sumas[i] > max)
                {

                    max = sumas[i];

                    filaMax = matriz[i];

                }

            }

            Console.WriteLine("La fila con mayor suma es:");

            foreach(int num in filaMax)
            {

                Console.WriteLine(num);

            }
            
        }

    }
}
