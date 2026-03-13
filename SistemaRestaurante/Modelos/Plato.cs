using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;

namespace SistemaRestaurante.Modelos
{
    public abstract class Plato
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
        public decimal PrecioBase { get; }
        public TipoComida TipoComida { get; }
        public NivelDificultad Dificultad { get; }

        protected Plato(int id, string nombre, string descripcion, decimal precioBase,
                        TipoComida tipoComida, NivelDificultad dificultad)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioBase = precioBase;
            TipoComida = tipoComida;
            Dificultad = dificultad;
        }

        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine($"Plato: {Nombre} ({TipoComida}) - Dificultad: {Dificultad}");
        }
    }
}

