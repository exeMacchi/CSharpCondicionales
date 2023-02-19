using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17___Verificar_expresion_logica_1
{
    internal class Ejercicio17
    {
        static void Main(string[] args)
        {
            /* 
                17. Se ingresan tres números (A, B, C) para saber si el resultado de la siguiente expresión lógica
                    es verdadero o falso: (A * 3 > B – C) ^ (C*A = 3). Muestre el resultado (“verdadero” o “falso”). 
            */

            Console.Write("Ingrese el número A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número C: ");
            int C = int.Parse(Console.ReadLine());

            if ((A * 3 > B - C) && (C * A == 3))
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
