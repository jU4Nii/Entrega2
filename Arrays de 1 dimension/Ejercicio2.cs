using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays_de_1_dimension
{
    class Ejercicio2
    {
        //2- Solicitar al usuario 8 nombres y almacenarlos en un array.Mostrar cuántos empiezan con la letra 'A'.

        public static void Ejecutar()
        {

            Console.WriteLine("Ingrese 8 nombres:");

            string[] nombres = new string[8];

            for (int i = 0; i < nombres.Length; i++)
            {

                Console.WriteLine($"Ingrese el nombre N°{i+1}");

                nombres[i] = Console.ReadLine();

            }

            int contadorNombresConA = 0;

            for (int i = 0; i < nombres.Length; i++)
            {

                string nombreAnalizado = nombres[i];

                for (int j = 0; j < 2; i++)
                {

                    if (nombreAnalizado[0] == 'A' || nombreAnalizado[0] == 'a') contadorNombresConA++;

                }

            }

            Console.WriteLine($"La cantidad de nombres que empiezan con la letra 'A' es igual a {contadorNombresConA}");


        }

    }
}
