using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Generador de Correos Corporativos: Pide al usuario su nombre y apellido. 
 * El programa debe generar un correo con el formato nombre.apellido@empresa.com(todo en minúsculas).
 */

namespace ejercicios
{
    internal class Generador_Correo
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = "kall";
            Console.Write("Ingrese su apellido: ");
            string apellido = "Ortega";
            Console.Write("Ingrese el dominio de correo (ejemplo: gmail.com): ");
            string dominio = "gmail.com";
            string correoGenerado = $"{nombre.ToLower()}.{apellido.ToLower()}@{dominio.ToLower()}";
            Console.WriteLine($"\nEl correo generado es: {correoGenerado}");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
