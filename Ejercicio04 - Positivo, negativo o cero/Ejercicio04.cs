using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Positivo__negativo_o_cero
{
    internal class Ejercicio04
    {
        static void Main(string[] args)
        {
            // 4. Diseñe un algoritmo que indique con carteles si el número ingresado es negativo, positivo o nulo.

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("\nEl número es cero.");
            }
            else if (N > 0)
            {
                Console.WriteLine("\nEl número es mayor a cero.");
            }
            else
            {
                Console.WriteLine("\nEl número es menor a cero.");
            }
        }
    }
}
