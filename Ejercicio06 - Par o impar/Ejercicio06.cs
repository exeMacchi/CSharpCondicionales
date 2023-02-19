using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Par_o_impar
{
    internal class Ejercicio06
    {
        static void Main(string[] args)
        {
            // 6. Diseñe un algoritmo que indique si el número ingresado es par o impar. El n.° ingresado es > 0.

            int N;

            do
            {
                Console.Write("Ingrese un número (mayor a cero): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0);

            if (N % 2 == 0)
            {
                Console.WriteLine("\nEl número es par.");
            }
            else
            {
                Console.WriteLine("\nEl número es impar.");
            }
        }
    }
}
