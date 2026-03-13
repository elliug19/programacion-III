using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    internal class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }
        public Camion(string id, string marca, string modelo, string año, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado, decimal capacidadCarga, int numeroEjes) : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }

        public decimal CalcularComisionVendedor()
        {
            return PrecioBase * 0.07m; // Ejemplo: comisión del 7% sobre el precio base para camiones
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} toneladas");
            Console.WriteLine($"Número de Ejes: {NumeroEjes}");
            Console.WriteLine("Tipo: Camión");
            Console.WriteLine($"======================");
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("Factura de Venta");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} toneladas");
            Console.WriteLine($"Número de Ejes: {NumeroEjes}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal():C}");
            Console.WriteLine($"Comisión Vendedor: {CalcularComisionVendedor():C}");
            Console.WriteLine($"======================");
        }
    }
}
