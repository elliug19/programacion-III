using System;
using System.Collections.Generic;

namespace EjerciciosPOO
{
    // --- DEFINICIÓN DE CLASES E INTERFACES ---

    // 1. Herencia
    class Mascota {
        public string Nombre { get; set; }
        public virtual void HacerTruco() => Console.WriteLine($"{Nombre} bosteza...");
    }
    class Loro : Mascota {
        public override void HacerTruco() => Console.WriteLine($"{Nombre} dice: ¡Quiero una galleta! ");
    }
    class Gato : Mascota {
        public override void HacerTruco() => Console.WriteLine($"{Nombre} está amasando pan en la manta. ");
    }

    // 2. Encapsulamiento
    class Producto {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        private int Stock;

        public Producto(string n, double p, int s) { Nombre = n; Precio = p; Stock = s; }
        public void Vender(int cant) {
            if (cant <= Stock) {
                Stock -= cant;
                Console.WriteLine($"Vendido: {cant} {Nombre}. Total: ${cant * Precio}. Stock: {Stock}");
            } else Console.WriteLine("Sin stock suficiente.");
        }
    }

    // 3. Interfaces
    interface IReproductor { void Play(); }
    class Cancion : IReproductor { 
        public string T; 
        public void Play() => Console.WriteLine($" Reproduciendo canción: {T}"); 
    }
    class Podcast : IReproductor { 
        public string T; 
        public void Play() => Console.WriteLine($" Escuchando Podcast: {T}"); 
    }

    // 4. Estado
    class Libro {
        public string Titulo { get; set; }
        public bool Disponible { get; private set; } = true;
        public void Prestar() {
            if (Disponible) { Disponible = false; Console.WriteLine("Libro prestado con éxito."); }
            else Console.WriteLine("El libro no está disponible.");
        }
    }

    // 5. Lógica de Negocio
    class VehiculoElectrico {
        public int Bateria { get; private set; } = 100;
        public void Viajar(int km) {
            if (Bateria >= km) { Bateria -= km; Console.WriteLine($"Viaje de {km}km realizado. Batería: {Bateria}%"); }
            else Console.WriteLine("¡Batería insuficiente! Carga inmediata.");
        }
    }

    // --- PROGRAMA PRINCIPAL ---

    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- MENÚ DE EJERCICIOS POO ---");
                Console.WriteLine("1. Mascotas (Herencia)");
                Console.WriteLine("2. Tienda (Encapsulamiento)");
                Console.WriteLine("3. Streaming (Interfaces)");
                Console.WriteLine("4. Biblioteca (Estados)");
                Console.WriteLine("5. Vehículo (Lógica)");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Mascota m = new Gato { Nombre = "Michi" };
                        m.HacerTruco();
                        break;
                    case "2":
                        Producto p = new Producto("Laptop", 1500, 5);
                        p.Vender(2);
                        break;
                    case "3":
                        IReproductor miMusica = new Cancion { T = "Starboy" };
                        miMusica.Play();
                        break;
                    case "4":
                        Libro l = new Libro { Titulo = "C# para Cracks" };
                        l.Prestar();
                        l.Prestar(); // Intento doble
                        break;
                    case "5":
                        VehiculoElectrico tesla = new VehiculoElectrico();
                        tesla.Viajar(30);
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
