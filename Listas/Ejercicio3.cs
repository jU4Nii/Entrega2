using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Listas
{
    class Ejercicio3
    {
        //3- Generar una lista con 10 números aleatorios entre 1 y 100. Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor. Mostrar la lista resultante.
        public static void Ejecutar()
        {

            Random numAleatorio = new Random();

            List<int> listaRandoms = new List<int>();

            Console.WriteLine("Arreglo aleatorio generado:");

            for (int i = 0; i < 10; i++)
            {

                listaRandoms.Add(numAleatorio.Next(1, 101));

                Console.WriteLine(listaRandoms[i]);
            }

            Console.WriteLine("Ingrese un valor límite para eliminar todo número menor a dicho valor en la lista:");

            int valorLimite = int.Parse(Console.ReadLine());

            for (int i = listaRandoms.Count - 1; i >= 0; i--)
            {

                if (listaRandoms[i] < valorLimite) listaRandoms.RemoveAt(i);

            }

            Console.WriteLine("Arreglo con valores ya quitados:");

            foreach(int num in listaRandoms)
            {

                Console.WriteLine(num);

            }

        }



    }
}
