using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.CAPITULO_10
{
    class InventarioTienda
    {
        public string Productos { get; set; }
        public int CantidadUnidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float CostoUnidad { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public float Ganancia { get; set; }
        public float TotalGanancia { get; set; }
    }
  
}
