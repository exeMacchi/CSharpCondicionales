using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Sueldo_final
{
    internal class Ejercicio16
    {
        static void Main(string[] args)
        {
            /* 
                16. Un empleado cobra según la categoría (A - $ 7.500, B - $ 9.500, C - $ 11.500) y según su antigüedad
                    se le aumenta (<5 años 5 %, ≥5 y <10 años 12 % y el resto, un 20 %). Entonces el programa debe 
                    permitir ingresar la antigüedad y la categoría del empleado para mostrar su sueldo definitivo.
            */

            Console.Write("Ingrese categoría de salario (A, B, o C): ");
            char categoria = char.Parse(Console.ReadLine());

            Console.Write("Ingrese los años de antiguedad: ");
            int antiguedad = int.Parse(Console.ReadLine());

            double sueldoFinal = 0;

            if (categoria == 'A')
            {
                sueldoFinal = 7500;

                if (antiguedad < 5)
                {
                    sueldoFinal *= 1.05;
                }
                else if (antiguedad >= 5 && antiguedad < 10)
                {
                    sueldoFinal *= 1.12;
                }
                else if (antiguedad >= 10)
                {
                    sueldoFinal *= 1.20;
                }
            }

            if (categoria == 'B')
            {
                sueldoFinal = 9500;

                if (antiguedad < 5)
                {
                    sueldoFinal *= 1.05;
                }
                else if (antiguedad >= 5 && antiguedad < 10)
                {
                    sueldoFinal *= 1.12;
                }
                else if (antiguedad >= 10)
                {
                    sueldoFinal *= 1.20;
                }
            }

            if (categoria == 'C')
            {
                sueldoFinal = 11500;

                if (antiguedad < 5)
                {
                    sueldoFinal *= 1.05;
                }
                else if (antiguedad >= 5 && antiguedad < 10)
                {
                    sueldoFinal *= 1.12;
                }
                else if (antiguedad >= 10)
                {
                    sueldoFinal *= 1.20;
                }
            }

            Console.WriteLine($"\nSalario final: ${sueldoFinal}");
        }
    }
}
