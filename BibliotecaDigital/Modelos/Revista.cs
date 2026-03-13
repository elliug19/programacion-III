using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;

namespace BibliotecaDigital.Modelos
{
    public class Revista : MaterialBiblioteca, IPrestable
    {
        int NumeroEdicion { get; set; }
        string Periodicidad { get; set; }

        public Revista(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria, int numeroEdicion, string periodicidad) : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroEdicion = numeroEdicion;
            Periodicidad = periodicidad;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.75m;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Edición: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine("Tipo: Revista");

        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Comprobante de Préstamo - Revista");
            Console.WriteLine($"Revista: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Edición: {NumeroEdicion}");
            Console.WriteLine($"Periodicidad: {Periodicidad}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
            Console.WriteLine("------------------------------");
        }
    }
}
