using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Calculadora de Propina Solidaria: Pide el total de una cuenta en un restaurante. 
 * Pregunta qué porcentaje de propina desea dejar (10%, 15% o 20%). 
 * Si el total con propina supera los $100.000, muestra un mensaje agradeciendo su generosidad
 */

namespace ejercicios
{
    internal class Calculadora_propinas
    {
        static void Main(string[] args)
        {
            float TotalPagar = 0.0f;
            Console.Write("Ingrese el total de la cuenta: $ ");
            float totalCuenta = 20000;
            Console.Write("Ingrese el porcentaje de propina (10 - 15 - 20): ");
            float porcentajePropina = 10;
            if (porcentajePropina == 10) TotalPagar = totalCuenta * 1.10f;
            else if (porcentajePropina == 15) TotalPagar = totalCuenta * 1.15f;
            else if (porcentajePropina == 20) TotalPagar = totalCuenta * 1.20f;
            Console.WriteLine($"\nEl total a pagar con propina es: ${TotalPagar}");
            Console.WriteLine(TotalPagar > 1000 ? "¡Gracias por tu generosidad!" : "¡Gracias por tu propina!");
            Console.ReadLine();
        }
    }
}
