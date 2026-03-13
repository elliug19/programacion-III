using System;
using System.Collections.Generic;
using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using BibliotecaDigital.Modelos;

/*
 * Crear un sistema para gestionar una biblioteca digital que maneja diferentes tipos de materiales: Libros, Revistas y AudioLibros. Cada material tiene información común pero también características específicas.
 * 
 * Estructura de Carpetas Requerida
 * BibliotecaDigital\
 * ├── Enums\
 * │   └── TipoCategoria.cs        ← Ficcion, NoFiccion, Ciencia, Historia
 * ├── Interfaces\
 * │   └── IPrestable.cs           ← ContratoPréstamo
 * ├── Modelos\
 * │   ├── MaterialBiblioteca.cs   ← Clase abstracta base
 * │   ├── Libro.cs                ← Hereda de MaterialBiblioteca
 * │   ├── Revista.cs              ← Hereda de MaterialBiblioteca
 * │   └── AudioLibro.cs           ← Hereda de MaterialBiblioteca
 * └── Program.cs
 * 
 *CLASES HIJAS a crear:
 *Libro: Propiedades adicionales → int NumeroPaginas, string ISBN
 *Revista: Propiedades adicionales → int NumeroEdicion, string Periodicidad
 *AudioLibro: Propiedades adicionales → TimeSpan Duracion, string Narrador
 *
 *PROGRAMA PRINCIPAL:
 *Lista de IPrestable
 *Menú para agregar materiales
 *Procesar préstamos y mostrar comprobantes
 */

namespace BibliotecaDigital
{
    internal class Program
    {

        private static List<IPrestable> materiales = new List<IPrestable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Biblioteca Digital");

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 6);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\nMenú Principal:");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Agregar Revista");
            Console.WriteLine("3. Agregar Audiolibro");
            Console.WriteLine("4. Mostrar todos los materiales");
            Console.WriteLine("5. Procesar Préstamo");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    AgregarRevista();
                    break;
                case 3:
                    AgregarAudioLibro();
                    break;
                case 4:
                    MostrarTodosMateriales();
                    break;
                case 5:
                    ProcesarPrestamo();
                    break;
                case 6:
                    Console.WriteLine("Gracias por usar la Biblioteca Digital. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }

        private static void AgregarLibro()
        {
            Console.WriteLine("===== Agregar Libro ===== ");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Año de Publicación: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Número de Páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            TipoCategoria categoria = SeleccionarCategoria();

            var libro = new Libro(siguienteId++, titulo, autor, año, categoria, paginas, isbn);
            materiales.Add(libro);

            Console.WriteLine("Libro agregado exitosamente.");
        }

        private static void AgregarRevista()
        {
            Console.WriteLine("===== Agregar Revista ===== ");

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Año de Publicación: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Número de Edición: ");
            int edicion = int.Parse(Console.ReadLine());

            Console.Write("Periodicidad: ");
            string periodicidad = Console.ReadLine();

            TipoCategoria categoria = SeleccionarCategoria();

            var revista = new Revista(siguienteId++, titulo, autor, año, categoria, edicion, periodicidad);
            materiales.Add(revista);

            Console.WriteLine("Revista agregada exitosamente.");
        }

        private static void AgregarAudioLibro()
        {
            Console.WriteLine("===== Agregar Audiolibro ===== ");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Año de Publicación: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Duración (en minutos): ");
            int duracionMinutos = int.Parse(Console.ReadLine());
            TimeSpan duracion = TimeSpan.FromMinutes(duracionMinutos);

            Console.Write("Narrador: ");
            string narrador = Console.ReadLine();

            TipoCategoria categoria = SeleccionarCategoria();

            var audioLibro = new AudioLibro(siguienteId++, titulo, autor, año, categoria, duracion, narrador);
            materiales.Add(audioLibro);

            Console.WriteLine("Audiolibro agregado exitosamente.");
        }

        private static TipoCategoria SeleccionarCategoria()
        {
            Console.WriteLine("\nSeleccione una categoría:");
            var categorias = Enum.GetValues(typeof(TipoCategoria));

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {categorias.GetValue(i)}");
            }

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine()) - 1;

            return (TipoCategoria)categorias.GetValue(opcion);
        }

        private static void MostrarTodosMateriales()
        {
            Console.WriteLine("\n=== MATERIALES DISPONIBLES ===");

            if (materiales.Count == 0)
            {
                Console.WriteLine("No hay materiales disponibles.");
                return;
            }

            for (int i = 0; i < materiales.Count; i++)
            {
                Console.WriteLine($"\n--- Material {i + 1} ---");
                if (materiales[i] is MaterialBiblioteca material)
                {
                    material.MostrarInformacion();
                }
            }
        }

        private static void ProcesarPrestamo()
        {
            Console.WriteLine("\n=== PROCESAR PRÉSTAMO ===");

            if (materiales.Count == 0)
            {
                Console.WriteLine("No hay materiales disponibles para préstamo.");
                return;
            }

            MostrarTodosMateriales();

            Console.Write("\nSeleccione el número del material a prestar: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion) &&
                seleccion >= 1 && seleccion <= materiales.Count)
            {
                var materialSeleccionado = materiales[seleccion - 1];

                Console.WriteLine("\n");
                materialSeleccionado.GenerarComprobantePrestramo();

                // Simular cálculo de multa por retraso
                Console.Write("\n¿Desea simular días de retraso? (0 para no): ");
                if (int.TryParse(Console.ReadLine(), out int diasRetraso) && diasRetraso > 0)
                {
                    decimal multa = materialSeleccionado.CalcularMultaPorRetraso(diasRetraso);
                    Console.WriteLine($"Multa por {diasRetraso} días de retraso: ${multa:F2}");
                }
            }
            else
            {
                Console.WriteLine("Selección inválida.");
            }
        }
    }
}
