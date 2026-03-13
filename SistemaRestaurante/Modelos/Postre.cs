using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    namespace SistemaRestaurante.Modelos
    {
        public class Postre : Plato, IPreparable
        {
            public bool ContieneLactosa { get; }
            public int CaloriasPorPorcion { get; }

            public Postre(int id, string nombre, string descripcion, decimal precioBase,
                          TipoComida tipoComida, NivelDificultad dificultad,
                          bool contieneLactosa, int caloriasPorPorcion)
                : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
            {
                ContieneLactosa = contieneLactosa;
                CaloriasPorPorcion = caloriasPorPorcion;
            }

            public TimeSpan CalcularTiempoPreparacion()
            {
                return TimeSpan.FromMinutes(25 + (ContieneLactosa ? 5 : 0));
            }
            public void GenerarOrdenCocina() {
                Console.WriteLine($"Orden generada: Postre {Nombre}, {CaloriasPorPorcion} cal/porción.");
            }
            public decimal CalcularCostoTotal()
            {
                return PrecioBase;
            }
        }
    }

}
