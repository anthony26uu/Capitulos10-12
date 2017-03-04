using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.CAPITULO_12
{
  public  class FACTORIAl
    {
        public static void Main(string[] args)
        {

            factorial(5);

        }

        public static void factorial(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
                Console.WriteLine(resultado);
            }
            Console.WriteLine(" El Factorial de " + n + " es: " + resultado);
            Console.ReadKey();

        }
    }
}
