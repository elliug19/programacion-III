using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;
using SistemaRestaurante.Modelos;
using SistemaRestaurante.Modelos.SistemaRestaurante.Modelos;

namespace SistemaRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            List<IPreparable> pedidos = new List<IPreparable>();

            while (!salir)
            {
                Console.WriteLine("\n=== MENÚ DEL RESTAURANTE ===");
                Console.WriteLine("1. Ordenar Entrada");
                Console.WriteLine("2. Ordenar Plato Principal");
                Console.WriteLine("3. Ordenar Postre");
                Console.WriteLine("4. Ver todos los pedidos");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        var entrada = new Entrada(1, "Bruschetta", "Pan con tomate", 5m,
                                                  TipoComida.Vegetariana, NivelDificultad.Facil,
                                                  esFria: true, porciones: 3);

                        entrada.GenerarOrdenCocina();
                        Console.WriteLine($"Tiempo: {entrada.CalcularTiempoPreparacion()} | Costo: {entrada.CalcularCostoTotal()}");
                        pedidos.Add(entrada);
                        break;

                    case "2":
                        var principal = new PlatoPrincipal(2, "Filete de Res", "Carne jugosa", 20m,
                                                           TipoComida.Carnivora, NivelDificultad.Intermedio,
                                                           "Res", incluyeGuarnicion: true);

                        principal.GenerarOrdenCocina();
                        Console.WriteLine($"Tiempo: {principal.CalcularTiempoPreparacion()} | Costo: {principal.CalcularCostoTotal()}");
                        pedidos.Add(principal);
                        break;

                    case "3":
                        var postre = new Postre(3, "Cheesecake", "Pastel de queso", 8m,
                                                TipoComida.Mixta, NivelDificultad.Avanzado,
                                                contieneLactosa: true, caloriasPorPorcion: 350);

                        postre.GenerarOrdenCocina();
                        Console.WriteLine($"Tiempo: {postre.CalcularTiempoPreparacion()} | Costo: {postre.CalcularCostoTotal()}");
                        pedidos.Add(postre);
                        break;

                    case "4":
                        Console.WriteLine("\n=== LISTA DE PEDIDOS ===");
                        if (pedidos.Count == 0)
                        {
                            Console.WriteLine("No hay pedidos registrados.");
                        }
                        else
                        {
                            int contador = 1;
                            foreach (var pedido in pedidos)
                            {
                                Console.WriteLine($"Pedido {contador}:");
                                pedido.GenerarOrdenCocina();
                                Console.WriteLine($"Tiempo: {pedido.CalcularTiempoPreparacion()} | Costo: {pedido.CalcularCostoTotal()}");
                                contador++;
                            }
                        }
                        break;

                    case "5":
                        salir = true;
                        Console.WriteLine("Gracias por visitar nuestro restaurante. ¡Hasta pronto!");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, intente nuevamente.");
                        break;
                }
            }
        }

    }
}

