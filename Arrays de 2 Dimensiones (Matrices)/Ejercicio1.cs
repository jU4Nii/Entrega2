using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_2_Dimensiones__Matrices_
{
    class Ejercicio1
    {
        //1- Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.
        public static void Ejecutar()
        {

            int[][] matriz = new int[3][];

            int[] fila1 = new int[3];

            int sumaFila1 = 0;

            int[] fila2 = new int[3];

            int sumaFila2 = 0;

            int[] fila3 = new int[3];

            int sumaFila3 = 0;

            for (int i = 0; i < fila1.Length; i++)
            {

                Console.WriteLine($"Ingrese el elemento [1][{i + 1}]");

                fila1[i] = int.Parse(Console.ReadLine());

            }

            matriz[0] = fila1;

            for (int i = 0; i < fila2.Length; i++)
            {

                Console.WriteLine($"Ingrese el elemento [2][{i + 1}]");

                fila2[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < fila3.Length; i++)
            {

                Console.WriteLine($"Ingrese el elemento [3][{i + 1}]");

                fila3[i] = int.Parse(Console.ReadLine());

            }

        }

    }
}
