using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;
using ConcesionarioVehiculos.Modelos;

/*Desarrollar un sistema para un concesionario que vende Autos, Motocicletas y Camiones. Cada vehículo tiene características comunes pero precios y comisiones diferentes.
 * Estructura de Carpetas Requerida
 * ConcesionarioVehiculos\
 * ├── Enums\
 * │   ├── TipoCombustible.cs      ← Gasolina, Diesel, Electrico, Hibrido
 * │   └── EstadoVehiculo.cs       ← Nuevo, Usado, Seminuevo
 * ├── Interfaces\
 * │   └── IVendible.cs            ← ContratoVenta
 * ├── Modelos\
 * │   ├── Vehiculo.cs             ← Clase abstracta base
 * │   ├── Auto.cs                 ← Hereda de Vehiculo
 * │   ├── Motocicleta.cs          ← Hereda de Vehiculo
 * │   └── Camion.cs               ← Hereda de Vehiculo
 * └── Program.cs
 * 
 * CLASES HIJAS a crear:
 * Auto: Propiedades → int NumeroPuertas, bool TieneAireAcondicionado
 * Motocicleta: Propiedades → int Cilindraje, bool EsDeportiva
 * Camion: Propiedades → decimal CapacidadCarga, int NumeroEjes
 * 
 * LÓGICA DE NEGOCIO:
 * Auto: Precio final = PrecioBase + (AireAcondicionado ? 2000 : 0)
 * Motocicleta: Precio final = PrecioBase + (EsDeportiva ? Cilindraje * 10 : 0)
 * Camion: Precio final = PrecioBase + (CapacidadCarga * 500)
 */

namespace ConcesionarioVehiculos
{
    internal class Program
    {

        private static List<IVendible> vehiculos = new List<IVendible>();
        private static int siguienteId = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Concesionario de Vehículos");

            int opcion;
            do
            {
                MostrarMenu();
                Console.WriteLine("Ingrese su opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 5);

        }

        public static void MostrarMenu()
        {
            Console.WriteLine("====== MENÚ PRINCIPAL ======");
            Console.WriteLine("1. Agregar Auto");
            Console.WriteLine("2. Agregar Motocicleta");
            Console.WriteLine("3. Agregar Camión");
            Console.WriteLine("4. Mostrar Vehículos Disponibles");
            Console.WriteLine("5. Salir");
            Console.WriteLine("============================");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarAuto();
                    break;
                case 2:
                    AgregarMotocicleta();
                    break;
                case 3:
                    AgregarCamion();
                    break;
                case 4:
                    MostrarVehiculosDisponibles();
                    break;
                case 5:
                    Console.WriteLine("Gracias por visitar el concesionario. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                    break;
            }
        }

        private static void AgregarAuto()
        {
            Console.WriteLine("====== AGREGAR AUTO ======");
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Año: ");
            string año = Console.ReadLine();

            Console.WriteLine("Número de puertas: ");
            int numeroPuertas = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Tiene aire acondicionado? S para Sí y N para No: ");
            bool tieneAireAcondicionado = Console.ReadLine().Trim().ToLower() == "s";

            Console.WriteLine("Precio Base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            TipoCombustible tipoCombustible = SeleccionarCombustible();
            EstadoVehiculo estadoVehiculo = SeleccionarEstado();

            var nuevoAuto = new Auto($"A{++siguienteId}", marca, modelo, año, precioBase, tipoCombustible, estadoVehiculo, numeroPuertas, tieneAireAcondicionado);
            vehiculos.Add(nuevoAuto);
        }

        private static void AgregarMotocicleta()
        {
            Console.WriteLine("====== AGREGAR MOTOCICLETA ======");

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Año: ");
            string año = Console.ReadLine();

            Console.WriteLine("Cilindraje: ");
            int cilindraje = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Es deportiva? S para Sí y N para No: ");
            bool esDeportiva = Console.ReadLine().Trim().ToLower() == "s";

            Console.WriteLine("Precio Base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            TipoCombustible tipoCombustible = SeleccionarCombustible();
            EstadoVehiculo estadoVehiculo = SeleccionarEstado();

            var nuevaMotocicleta = new Motocicleta($"M{++siguienteId}", marca, modelo, año, precioBase, tipoCombustible, estadoVehiculo, cilindraje, esDeportiva);
            vehiculos.Add(nuevaMotocicleta);
        }

        private static void AgregarCamion()
        {
            Console.WriteLine("====== AGREGAR CAMIÓN ======");

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Año: ");
            string año = Console.ReadLine();

            Console.WriteLine("Capacidad de carga (toneladas): ");
            decimal capacidadCarga = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Número de ejes: ");
            int numeroEjes = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio Base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            TipoCombustible tipoCombustible = SeleccionarCombustible();
            EstadoVehiculo estadoVehiculo = SeleccionarEstado();

            var nuevoCamion = new Camion($"C{++siguienteId}", marca, modelo, año, precioBase, tipoCombustible, estadoVehiculo, capacidadCarga, numeroEjes);
            vehiculos.Add(nuevoCamion);
        }

        private static void MostrarVehiculosDisponibles()
        {
            Console.WriteLine("====== VEHÍCULOS DISPONIBLES ======");

            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos disponibles.");
                return;
            }

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo is Vehiculo v)
                {
                    v.MostrarEspecificaciones();
                }

            }
        }

        private static TipoCombustible SeleccionarCombustible()
        {
            Console.WriteLine("Seleccione el tipo de combustible:");
            Console.WriteLine("1. Gasolina");
            Console.WriteLine("2. Diesel");
            Console.WriteLine("3. Eléctrico");
            Console.WriteLine("4. Híbrido");
            int opcionCombustible = int.Parse(Console.ReadLine());

            switch (opcionCombustible)
            {
                case 1:
                    return TipoCombustible.Gasolina;
                case 2:
                    return TipoCombustible.Diesel;
                case 3:
                    return TipoCombustible.Electrico;
                case 4:
                    return TipoCombustible.Hibrido;
                default:
                    Console.WriteLine("Opción no válida. Se asignará Gasolina por defecto.");
                    return TipoCombustible.Gasolina;
            }
        }

        private static EstadoVehiculo SeleccionarEstado()
        {
            Console.WriteLine("Seleccione el estado del vehículo:");
            Console.WriteLine("1. Nuevo");
            Console.WriteLine("2. Usado");
            Console.WriteLine("3. Seminuevo");
            int opcionEstado = int.Parse(Console.ReadLine());
            switch (opcionEstado)
            {
                case 1:
                    return EstadoVehiculo.Nuevo;
                case 2:
                    return EstadoVehiculo.Usado;
                case 3:
                    return EstadoVehiculo.Seminuevo;
                default:
                    Console.WriteLine("Opción no válida. Se asignará Nuevo por defecto.");
                    return EstadoVehiculo.Nuevo;
            }
        }
    }
}
