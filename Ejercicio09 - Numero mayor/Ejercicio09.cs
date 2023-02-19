using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Numero_mayor
{
    internal class Ejercicio09
    {
        static void Main(string[] args)
        {
            // 9. Ingrese tres números y muestre el mayor (asuma que los números son distintos).

            Console.Write("Ingrese el primer número: ");
            int N1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int N2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int N3 = int.Parse(Console.ReadLine());

            int maximo = N1;
            if (N2 > maximo)
            {
                maximo = N2;
            }
            if (N3 > maximo)
            {
                maximo = N3;
            }

            Console.WriteLine($"\nEl máximo es {maximo}.");
        }
    }
}
