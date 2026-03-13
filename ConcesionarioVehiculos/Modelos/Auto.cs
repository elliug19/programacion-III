using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }
        public Auto(string id, string marca, string modelo, string año, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado, int numeroPuertas, bool tieneAireAcondicionado) : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            NumeroPuertas = numeroPuertas;
            TieneAireAcondicionado = tieneAireAcondicionado;
        }

        public decimal CalcularComisionVendedor()
        {
            return PrecioBase * 0.05m; // Ejemplo: comisión del 5% sobre el precio base
        }
        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (TieneAireAcondicionado ? 2000 : 0);
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Número de Puertas: {NumeroPuertas}");
            Console.WriteLine($"Tiene Aire Acondicionado: {(TieneAireAcondicionado ? "Sí" : "No")}");
            Console.WriteLine("Tipo: Auto");
            Console.WriteLine($"======================");
        }
        public void GenerarFacturaVenta()
        {
            Console.WriteLine("Factura de Venta");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal():C}");
            Console.WriteLine($"Comisión Vendedor: {CalcularComisionVendedor():C}");
            Console.WriteLine($"======================");
        }
    }
}
