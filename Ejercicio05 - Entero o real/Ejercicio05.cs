using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Entero_o_real
{
    internal class Ejercicio05
    {
        static void Main(string[] args)
        {
            // 5. Ingrese un número y muestre un cartel que indique si el primero es entero o real.

            Console.Write("Ingrese un número entero o real: ");
            var Numero = Console.ReadLine();

            try
            {
                int entero = int.Parse(Numero);

                Console.WriteLine("\nEl número es entero.");
            }
            catch (FormatException)
            {
                try
                {
                    float real = float.Parse(Numero);

                    Console.WriteLine("\nEl número es real.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNo se ha ingresado un valor numérico.");
                }
            }
        }
    }
}
