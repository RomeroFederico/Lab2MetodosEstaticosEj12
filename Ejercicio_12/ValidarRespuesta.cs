using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            string respuesta;

            Console.Write("¿Continua? (S/N) ");
            respuesta = Console.ReadLine().ToUpper();

            while (respuesta.Equals("S") || respuesta.Equals("N"))
            {
                Console.Clear();
                Console.Write("ERROR!!! Respuesta invalida. ¿Continua? (S/N) ");
                respuesta = Console.ReadLine().ToUpper();
            }

            if (respuesta == "S")
                return true;
            return false;
        }
    }
}