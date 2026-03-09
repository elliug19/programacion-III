using System;

/* Gestión de Inventario de Tienda: Define una clase Productocon nombre, precio y stock. 
 * Crea un método que permita "vender" el producto, restando del stock y mostrando el total de la venta. 
 * Si no hay stock, debe avisar al usuario.
 */
namespace ejercicios
{
    internal class InventarioTiendaPoo
    {
        class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            private int Stock { get; set; } // Encapsulado

            public Producto(string nombre, double precio, int stockInicial)
            {
                Nombre = nombre;
                Precio = precio;
                Stock = stockInicial;
            }

            public void Vender(int cantidad)
            {
                if (cantidad <= Stock)
                {
                    Stock -= cantidad;
                    Console.WriteLine($"Venta exitosa. Total: ${cantidad * Precio}. Stock restante: {Stock}");
                }
                else
                {
                    Console.WriteLine($"Error: Solo quedan {Stock} unidades de {Nombre}.");
                }
            }
        }
    }
}
