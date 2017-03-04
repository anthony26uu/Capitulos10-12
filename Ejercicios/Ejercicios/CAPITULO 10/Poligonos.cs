using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.CAPITULO_10
{
 public   class Poligonos
    {
        public Double Apotema { get; set;}
        public double Perimetro { get; set; }
        public Poligonos()
        {

        }

        public Poligonos(Double perimetro, Double apotema)

        {
            Perimetro = perimetro;
            Apotema = apotema;
        }
    }
}
