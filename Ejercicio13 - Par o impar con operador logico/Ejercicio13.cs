using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Par_o_impar_con_operador_logico
{
    internal class Ejercicio13
    {
        static void Main(string[] args)
        {
            /* 
                13. Diseñe un algoritmo que imprima “par” si el valor ingresado es 2, 4, o 6; “impar” si es 1, 3, o 5;
                    y en cualquier otro caso, “error”. Utilice el operador lógico O (||).
            */

            byte numero;

            do
            {
                Console.Write("Ingrese un número (1 a 6): ");
                numero = byte.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 6);

            switch (numero)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("\nIMPAR");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("\nPAR");
                    break;
                default:
                    Console.WriteLine("\nERROR");
                    break;
            }
        }
    }
}
