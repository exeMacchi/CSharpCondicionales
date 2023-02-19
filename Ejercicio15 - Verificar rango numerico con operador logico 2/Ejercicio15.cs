using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15___Verificar_rango_numerico_con_operador_logico_2
{
    internal class Ejercicio15
    {
        static void Main(string[] args)
        {
            // 15. Resuelva el ejercicio anterior con el operador lógico O (||).

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 10 || numero < 0)
            {
                Console.WriteLine("\nFALSO");
            }
            else
            {
                Console.WriteLine("\nVERDADERO");
            }
        }
    }
}
