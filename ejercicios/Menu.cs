using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Menu
    {
        static void Main(string[] args)
        {

            int PuestosOcupados = 0; // Esto es para el ejercicio 3
            while (true)
            {
                Console.WriteLine("===== EJERCICIOS TEMA 1 ===== " +
                    "\n1. Perfil de Usuario Gamer. " +
                    "\n2. Calculadora de Propina Solidaria. " +
                    "\n3. Control de Aforo en Eventos. " +
                    "\n4. Generador de Correos Corporativos. " +
                    "\n5. Simulador de Semáforo Inteligente.\n ");

                Console.Write("Elija una opción (1-5): ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese su Nickname: ");
                        string nickname = Console.ReadLine();
                        Console.Write("Ingrese su nivel de experiencia (1 - 100): ");
                        int xp = int.Parse(Console.ReadLine());
                        Console.Write("Si tienes premium ingresa (1), de lo contrario ingrese (2): ");
                        int UserPremium = int.Parse(Console.ReadLine());

                        if (UserPremium == 1)
                            Console.WriteLine($"\n¡Bienvenido, {nickname}! Tu nivel de experiencia es {xp} y tu suscripción premium está activa.");
                        else
                            Console.WriteLine($"\n¡Bienvenido, {nickname}! Tu nivel de experiencia es {xp} y tu suscripción premium no está activa.");

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        float TotalPagar = 0.0f;
                        Console.Write("Ingrese el total de la cuenta: $ ");
                        float totalCuenta = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el porcentaje de propina (10 - 15 - 20): ");
                        float porcentajePropina = float.Parse(Console.ReadLine());

                        if (porcentajePropina == 10) TotalPagar = totalCuenta * 1.10f;
                        else if (porcentajePropina == 15) TotalPagar = totalCuenta * 1.15f;
                        else if (porcentajePropina == 20) TotalPagar = totalCuenta * 1.20f;

                        Console.WriteLine($"\nEl total a pagar con propina es: ${TotalPagar}");
                        Console.WriteLine(TotalPagar > 1000 ? "¡Gracias por tu generosidad!" : "¡Gracias por tu propina!");

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        int PuestosMaximos = 50;
                        int EspaciosDisponibles = PuestosMaximos - PuestosOcupados;

                        Console.WriteLine("¿Cuántas personas quieren entrar a la discoteca?: ");
                        int PersonasEntrando = int.Parse(Console.ReadLine());

                        if (PersonasEntrando <= EspaciosDisponibles)
                        {
                            PuestosOcupados += PersonasEntrando;
                            Console.WriteLine("¡Bienvenidos a la discoteca!");
                            Console.WriteLine("Espacios ocupados: " + PuestosOcupados + "/50");
                        }
                        else
                        {
                            int debenSalir = PersonasEntrando - EspaciosDisponibles;
                            Console.WriteLine("Lo siento, no hay suficiente espacio para todos.");
                            Console.WriteLine("Para que puedan entrar, deben salir " + debenSalir + " personas.");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Write("Ingrese su nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Ingrese su apellido: ");
                        string ape = Console.ReadLine();
                        Console.Write("Ingrese el nombre de la empresa: ");
                        string emp = Console.ReadLine();

                        string correo = (nom + "." + ape + "@" + emp + ".com").ToLower();
                        Console.WriteLine("Su correo generado es: " + correo);

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Write("Ingrese el color actual del semáforo: ");
                        string color = Console.ReadLine().ToLower();

                        if (color == "verde") Console.WriteLine("Sigue adelante");
                        else if (color == "amarillo") Console.WriteLine("Prepárate para frenar");
                        else if (color == "rojo") Console.WriteLine("¡Detente!");
                        else Console.WriteLine("Color no reconocido");

                        Console.ReadLine();
                        Console.Clear();
                        break;

                }

            }
        }
    }
}
