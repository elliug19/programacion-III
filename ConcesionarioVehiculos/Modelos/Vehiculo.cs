using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;

namespace ConcesionarioVehiculos.Modelos
{
    public abstract class Vehiculo
    {
        // Propiedades: Id, Marca, Modelo, Año, PrecioBase, Combustible, Estado
        string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        // Constructor protegido

        protected Vehiculo(string id, string marca, string modelo, string año, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado) 
        { 
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Combustible = combustible;
            Estado = estado;

        }

        // Método virtual: MostrarEspecificaciones()
        public virtual void MostrarEspecificaciones() 
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Combustible: {Combustible}");
            Console.WriteLine($"Estado: {Estado}");
        }
        
    }
}
