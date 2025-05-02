using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Ejercicio1
    {
        //1- Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos.
        public static void Ejecutar()
        {

            Console.WriteLine("Ingresar cinco números enteros");

            List<int> nums = new List<int>();

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"{i+1}° número:");

                nums.Add(int.Parse(Console.ReadLine()));

            }

            int sumaNums = 0;

            for (int i = 0; i < nums.Count; i++)
            {

                sumaNums += nums[i];

            }

            Console.WriteLine($"La suma total de los elementos ingresados es {sumaNums}");

        }

    }
}
