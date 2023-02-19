using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18___Verificar_expresion_logica_2
{
    internal class Ejercicio18
    {
        static void Main(string[] args)
        {
            // 18. Ídem al anterior, pero con la siguiente expresión lógica: (A > 8 - B) U

            Console.Write("Ingrese el número A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número C: ");
            int C = int.Parse(Console.ReadLine());

            if ((A > 8 - B) || (A * 3 > B - C) && (C * A == 3))
            {
                Console.WriteLine("\nVERDADERO");
            }
            else
            {
                Console.WriteLine("\nFALSO");
            }
        }
    }
}
