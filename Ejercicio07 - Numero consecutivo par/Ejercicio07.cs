using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Numero_consecutivo_par
{
    internal class Ejercicio07
    {
        static void Main(string[] args)
        {
            // 7. Ingrese un número y luego muestre el número consecutivo siguiente al ingresado que sea par.

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            do
            {
                N++;

            } while (N % 2 != 0);

            Console.WriteLine($"\nEl número consecutivo par es {N}.");
        }
    }
}
