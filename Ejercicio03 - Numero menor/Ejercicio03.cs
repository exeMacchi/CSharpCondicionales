using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Numero_menor
{
    internal class Ejercicio03
    {
        static void Main(string[] args)
        {
            // 3. Ingrese dos números naturales y muestre el menor suponiendo que son distintos.

            Console.Write("Ingrese un número: ");
            int N1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese otro número: ");
            int N2 = int.Parse(Console.ReadLine());

            int menor;

            if (N1 < N2)
            {
                menor = N1;
            }
            else
            {
                menor = N2;
            }

            Console.WriteLine($"\nEl menor es {menor}");
        }
    }
}
