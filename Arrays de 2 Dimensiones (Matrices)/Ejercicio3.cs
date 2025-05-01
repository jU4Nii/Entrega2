using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_2_Dimensiones__Matrices_
{
    class Ejercicio3
    {
        //3- Crear una matriz de 3x3. Reemplazar todos los elementos negativos por cero.
        public static void Ejecutar()
        {

            int[,] matriz = new int[3,3]
            {
                {1,2,3},
                {4,-5,6},
                {7,-8,9}
            };

            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {

                    if (matriz[i,j] < 0)
                    {

                        matriz[i, j] = 0;

                    }

                }

                
            }

            foreach(int num in matriz)
            {

                Console.WriteLine(num);

            }

        }

    }
}
