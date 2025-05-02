using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_2_Dimensiones__Matrices_
{
    class Ejercicio1
    {
        //1- Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.
        public static void Ejecutar()
        {

            Console.WriteLine("Cargar los elementos de una matriz de 3x3");

            int[][] matriz = new int[3][];

            int[] sumaFilas = new int[3];

            for (int i = 0; i < matriz.Length; i++)
            {

                matriz[i] = new int[3];

                for(int j = 0; j < matriz[i].Length; j++)
                {

                    Console.WriteLine($"Ingrese el elemento [{i+1}][{j+1}]");

                    matriz[i][j] = int.Parse(Console.ReadLine());

                    sumaFilas[i] += matriz[i][j];

                }

            }

           for(int i = 0; i < 3; i++)
            {

                Console.WriteLine($"La suma de la fila N°{i+1} es {sumaFilas[i]}");

            }

        }

    }
}
