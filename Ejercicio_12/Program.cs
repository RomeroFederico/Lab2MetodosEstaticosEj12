using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_12
{

    /*
    12.  Realizar un programa que sume números enteros hasta que el 
    usuario lo determine, por medio de un mensaje ―¿Continua? (S/N).  
    En el método estático ValidaS_N() de la clase ValidarRespuesta, 
    se validará el ingreso de opciones.  
    El método NO recibe parámetros y devuelve un valor de tipo 
    booleano, TRUE si se ingreso una 'S' y FALSE si se ingreso una 
    'N'.  
    El método deberá validar si otro caracter fue ingresado mostrando 
    un mensaje de error y pidiendo el reingreso del mismo. 
    */

    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;

            Console.Title = "Ejercicio Nro. 12";

            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero: ");

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Clear();
                    Console.Write("ERROR!!! No se ha ingresado un numero. Ingrese un numero: ");
                }

                acumulador += numero;

                Console.Clear();
            } while (ValidarRespuesta.ValidaS_N());

            Console.Clear();
            Console.Write("El valor acumulado es {0}. ", acumulador);
            Console.ReadKey();
        }
    }
}