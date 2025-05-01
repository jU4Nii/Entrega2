using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_de_1_dimension
{
    class Ejercicio4
    {
        //4- Crear un array con los días de la semana y mostrar solo los días laborales.
        public static void Ejecutar()
        {

            string[] dias = new string[7] { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

            Console.WriteLine("Días laborales:");

            for (int i = 1; i < 6; i++)
            {

                Console.WriteLine(dias[i]);

            }

            
 
        }

    }
}
