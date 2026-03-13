using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; }
        public bool IncluyeGuarnicion { get; }

        public PlatoPrincipal(int id, string nombre, string descripcion, decimal precioBase,
                              TipoComida tipoComida, NivelDificultad dificultad,
                              string proteinaPrincipal, bool incluyeGuarnicion)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            ProteinaPrincipal = proteinaPrincipal;
            IncluyeGuarnicion = incluyeGuarnicion;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int dificultadExtra = (int)Dificultad * 15;
            return TimeSpan.FromMinutes(30 + dificultadExtra);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"Orden generada: Plato Principal {Nombre} con {ProteinaPrincipal}.");
        }
        public decimal CalcularCostoTotal()
        {
            return IncluyeGuarnicion ? PrecioBase * 1.2m : PrecioBase;
        }
    }
}

