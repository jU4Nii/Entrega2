using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_1_dimension
{
    class Ejercicio5
    {
        //5- Cargar un array de 5 números. Crear un segundo array con los mismos valores pero 
        public static void Ejecutar()
        {

            int[] arreglo = new int[5];

            Console.WriteLine("Cargar arreglo para luego invertirlo");

            for (int i = 0; i < arreglo.Length ; i++)
            {

                arreglo[i] = int.Parse(Console.ReadLine());

            }

            int[] arregloInvertido = new int[5];

            int posicionArreglo1 = arreglo.Length - 1;

            for (int i = 0; i < arreglo.Length; i++)
            {

                arregloInvertido[i] = arreglo[posicionArreglo1];

                posicionArreglo1--;

            }

            Console.WriteLine("Arreglo invertido");

            foreach(int nums in arregloInvertido)
            {

                Console.WriteLine(nums);

            }

        }

    }
}
