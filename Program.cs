using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program  // clase program punto de entrada de la app c#
    {
        static void Main(string[] args)
        {
            // declarar e iniicializar variables
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int intento = 0;
            int suposicion;
            // Informar al usuario las condiciones del juego
            Console.WriteLine("¡Bienvenido al juego Adivina el Número!\n");
            Console.WriteLine("");
            Console.WriteLine("He pensado un número entre 1 y 100. Intenta adivinarlo:");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");

            // Hacer  un bucle repetitivo hasta que se adivine el número
            do
            {
                intento++;
                Console.Write("Intento {0}: ", intento); // interpolación de variables con {} en c#,javascript,php, etc
                suposicion = int.Parse(Console.ReadLine()); // convertir a entero el numero ya que se ingresa como texto (string)

                // Condición comparativa entre suposicion con el numeroSecreto establecido por el programa
                if (suposicion < numeroSecreto)
                {
                    Console.WriteLine("Tu suposición es demasiado baja. Inténtalo de nuevo.");
                }
                else if (suposicion > numeroSecreto)
                {
                    Console.WriteLine("Tu suposición es demasiado alta. Inténtalo de nuevo.");
                }
                else // si no es mayor ni menor logicamente quiere decir que es igual
                {
                    Console.WriteLine("");
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("  ¡Felicidades! Has adivinado el número en {0} intentos.", intento);
                    Console.WriteLine("**************************************************************");
                    Console.ReadKey();
                }
            } while (suposicion != numeroSecreto);  // condiicional de repetiicion del bucle Do ... While
        }
    }
}

/*
 ¿Qué es la clase Program?

En C#, cada aplicación debe tener un punto de entrada, que es donde el programa comienza a ejecutarse.
Este punto de entrada se define dentro de una clase llamada Program.
La clase Program actúa como el contenedor principal para el código de tu aplicación.
¿Qué es el método Main?

El método Main es el punto de entrada real de tu programa.
Cuando ejecutas tu aplicación C#, el sistema busca el método Main y comienza a ejecutar el código dentro de él.
El método Main es donde colocas el código que se ejecutará cuando se inicie tu programa.
Estructura básica de la clase Program y el método Main:

Aquí tienes un ejemplo simple de cómo se ve la estructura básica:

using System; // Importa la biblioteca System, que contiene Console.WriteLine

class Program // Define la clase Program
{
    static void Main(string[] args) // Define el método Main
    {
        // Aquí va el código de tu programa
        Console.WriteLine("¡Hola, mundo!"); // Imprime "¡Hola, mundo!" en la consola
    }
}

 
 */