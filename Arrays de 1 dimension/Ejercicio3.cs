using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_1_dimension
{
    class Ejercicio3
    {
        //3- Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.
        public static void Ejecutar()
        {

            int contadorPos = 0;

            int contadorNeg = 0;

            int contadorCeros = 0;

            int[] arreglo = new int[10];

            for (int i = 0; i < arreglo.Length; i++)
            {

                Console.WriteLine($"Ingrese el número {i+1}");

                arreglo[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arreglo.Length; i++)
            {

                if (arreglo[i] > 0) contadorPos++;
                else if (arreglo[i] < 0) contadorNeg++;
                else contadorCeros++;

            }

            Console.WriteLine($"El arreglo contiene {contadorPos} números positivos, {contadorNeg} números negativos y {contadorCeros} ceros");

        }

    }
}
