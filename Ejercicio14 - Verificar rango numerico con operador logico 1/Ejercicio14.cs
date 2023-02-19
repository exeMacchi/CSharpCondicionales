using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Verificar_rango_numerico_con_operador_logico_1
{
    internal class Ejercicio14
    {
        static void Main(string[] args)
        {
            /* 
                14. Diseñe un algoritmo que, dado un número, imprima “Verdadero” si está entre 0 y 10, y “Falso” si
                    es mayor a 10 o menor a cero. 
            */

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
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
