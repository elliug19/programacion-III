using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioVehiculos.Interfaces
{
    public interface IVendible
    {
        decimal CalcularPrecioFinal();
        void GenerarFacturaVenta();
        decimal CalcularComisionVendedor();
    }
}
