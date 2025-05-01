using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Arrays_de_1_dimension
{
    class Ejercicio1
    {
        //1- Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.
        public static void Ejecutar()
        {

            Random numsAleatorios = new Random();

            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {

                numeros[i] = numsAleatorios.Next(1, 101);

            }

            int max = numeros[0];

            int min = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] > max) max = numeros[i];

                if (numeros[i] < min) min = numeros[i];

            }

            Console.WriteLine("Arreglo:");

            foreach(int num in numeros)
            {

                Console.WriteLine(num);

            }

            Console.WriteLine($"El número mayor es {max} y el menor {min}");

            
        }

    }
}
