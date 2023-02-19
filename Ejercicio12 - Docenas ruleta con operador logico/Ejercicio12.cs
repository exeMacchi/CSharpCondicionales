using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Docenas_ruleta_con_operador_logico
{
    internal class Ejercicio12
    {
        static void Main(string[] args)
        {
            /*
                12. Diseñe un algoritmo que imprima el número de docena («primera», «segunda» o «tercera») dado el
                    resultado de una jugada de ruleta. Utilice el operador lógico Y (&&).
            */

            Random random = new Random();
            int jugada = random.Next(0, 37);

            if (jugada == 0)
            {
                Console.WriteLine($"La bola cayó en el cero ({jugada}).");
            }
            else if (jugada > 0 && jugada <= 12)
            {
                Console.WriteLine($"La bola cayó en la primera docena ({jugada}).");
            }
            else if (jugada > 12 && jugada <= 24)
            {
                Console.WriteLine($"La bola cayó en la segunda docena ({jugada}).");
            }
            else
            {
                Console.WriteLine($"La bola cayó en la tercera docena ({jugada})");
            }
        }
    }
}
