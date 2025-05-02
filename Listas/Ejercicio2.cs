using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Ejercicio2
    {
        //2- Pedir al usuario que ingrese 7 números y guardarlos en una lista. Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.
        public static void Ejecutar()
        {

            Console.WriteLine("Ingresar siete números");

            List<int> nums = new List<int>();

            for (int i = 0; i < 7; i++)
            {

                Console.WriteLine($"{i + 1}° número:");

                nums.Add(int.Parse(Console.ReadLine()));

            }

            Console.WriteLine("Ingrese un número para buscarlo en la lista:");

            int numBuscado = int.Parse(Console.ReadLine());

            if (nums.Contains(numBuscado)) Console.WriteLine("El número se encuentra en la lista");
            else Console.WriteLine("El número no está en la lista");

        }

    }
}
