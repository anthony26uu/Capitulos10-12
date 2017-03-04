using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.CAPITULO_10
{
  public  class PoligonosPropiedad
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }
        public PoligonosPropiedad()
        {

        }
        public PoligonosPropiedad(Double perimetro, Double apotema)

        {
            this.Perimetro = perimetro;
            this.Apotema = apotema;
        }

        public double Area
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 15; Apotema = 3.25; }
        }
    }
}
