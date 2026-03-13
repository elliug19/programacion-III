using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;

namespace BibliotecaDigital.Modelos
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        TimeSpan Duracion { get; set; }
        string Narrador { get; set; }
        public AudioLibro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria, TimeSpan duracion, string narrador) : base(id, titulo, autor, añoPublicacion, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(14);
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.50m;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion.Hours:D2}:{Duracion.Minutes:D2}:{Duracion.Seconds:D2}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine("Tipo: Audiolibro");

        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Comprobante de Préstamo - Audiolibro");
            Console.WriteLine($"Audiolibro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Narrador: {Narrador}");
            Console.WriteLine($"Duración: {Duracion.Hours:D2}:{Duracion.Minutes:D2}:{Duracion.Seconds:D2}");
            Console.WriteLine($"Fecha de Préstamo: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
            Console.WriteLine("------------------------------");
        }
    }
}
