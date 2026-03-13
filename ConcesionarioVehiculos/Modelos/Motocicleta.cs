using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }
        public Motocicleta(string id, string marca, string modelo, string año, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado, int cilindraje, bool esDeportiva) : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = esDeportiva;
        }

        public decimal CalcularComisionVendedor()
        {
            return PrecioBase * 0.06m; // Ejemplo: comisión del 6% sobre el precio base para motocicletas
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (EsDeportiva ? Cilindraje * 10 : 0);
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
            Console.WriteLine($"Es Deportiva: {(EsDeportiva ? "Sí" : "No")}");
            Console.WriteLine("Tipo: Motocicleta");
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("Factura de Venta");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
            Console.WriteLine($"Es Deportiva: {(EsDeportiva ? "Sí" : "No")}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal():C}");
            Console.WriteLine($"Comisión Vendedor: {CalcularComisionVendedor():C}");
            Console.WriteLine($"======================");
        }
    }
}
