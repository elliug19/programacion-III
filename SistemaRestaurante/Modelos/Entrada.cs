using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; }
        public int Porciones { get; }

        public Entrada(int id, string nombre, string descripcion, decimal precioBase,
                       TipoComida tipoComida, NivelDificultad dificultad,
                       bool esFria, int porciones)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            EsFria = esFria;
            Porciones = porciones;
        }

        public TimeSpan CalcularTiempoPreparacion() 
        {
            return TimeSpan.FromMinutes(EsFria ? 10 : 20);
        }
        public void GenerarOrdenCocina() 
        {
            Console.WriteLine($"Orden generada: Entrada {Nombre}, {Porciones} porciones.");
        }
        public decimal CalcularCostoTotal()
        {
            return PrecioBase * Porciones;
        }
    }
}

