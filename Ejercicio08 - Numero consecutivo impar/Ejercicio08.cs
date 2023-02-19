using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Numero_consecutivo_impar
{
    internal class Ejercicio08
    {
        static void Main(string[] args)
        {
            // 8. Ingrese un número y luego muestre el número consecutivo siguiente al ingresado que sea impar.

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            do
            {
                N++;

            } while (N % 2 == 0);

            Console.WriteLine($"\nEl número consecutivo impar es {N}.");
        }
    }
}
