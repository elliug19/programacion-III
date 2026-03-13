using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Simulador de Semáforo Inteligente: Pide al usuario que ingrese el color actual del semáforo (Verde, Amarillo, Rojo). 
 * Si es verde, imprime "Sigue adelante"; si es amarillo, "Prepárate para frenar"; y si es rojo, "¡Distensión!".
 */

namespace ejercicios
{
    internal class Semaforo_Inteligente
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el color actual del semáforo: ");
            string color = "amarillo";

            if (color == "verde")
            {

                Console.WriteLine("Sigue adelante");
            }
            else if (color == "amarillo")
            {

                Console.WriteLine("Prepárate para frenar");
            }
            else if (color == "rojo")
            {

                Console.WriteLine("¡Detente!");
            }
            else
            {
                Console.WriteLine("Color no reconocido");
            }

            Console.ReadLine();
            Console.Clear();
        }

    }
}
