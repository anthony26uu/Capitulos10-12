using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.CAPITULO_10
{
  public  class ToString
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }
        public ToString()
        {

        }
        public ToString(Double Perimetro, Double Apotema)

        {
            this.Perimetro = Perimetro;
            this.Apotema = Apotema;
        }

        public double Area
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 15; Apotema = 3.25; }
        }


        public static void main()
        {
            ToString stringt = new ToString();
            Console.WriteLine(stringt.ToString());
        }
    }
}
