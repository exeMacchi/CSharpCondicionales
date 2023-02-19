using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Nota_examen
{
    internal class Ejercicio01
    {
        static void Main(string[] args)
        {
            /*
                1. Un profesor corrige un examen y según el puntaje de 1 a 100 (números naturales) debe calificar
                   al alumno respetando la siguiente tabla:
                      1 = 0-29
                      2 = 30-47
                      3 = 48-59
                      4 = 60-65
                      5 = 66-71
                      6 = 72-77
                      7 = 78-83
                      8 = 84-89
                      9 = 90-95
                      10 = 96-100 
            */

            Console.Write("Ingrese el puntaje del alumno: ");
            byte puntaje = byte.Parse(Console.ReadLine());

            byte notaFinal = 0;

            if (puntaje <= 100 && puntaje >= 96)
            {
                notaFinal = 10;
            }
            else if (puntaje <= 95 && puntaje >= 90)
            {
                notaFinal = 9;
            }
            else if (puntaje <= 89 && puntaje >= 84)
            {
                notaFinal = 8;
            }
            else if (puntaje <= 83 && puntaje >= 78)
            {
                notaFinal = 7;
            }
            else if (puntaje <= 77 && puntaje >= 72)
            {
                notaFinal = 6;
            }
            else if (puntaje <= 71 && puntaje >= 66)
            {
                notaFinal = 5;
            }
            else if (puntaje <= 65 && puntaje >= 60)
            {
                notaFinal = 4;
            }
            else if (puntaje <= 59 && puntaje >= 48)
            {
                notaFinal = 3;
            }
            else if (puntaje <= 47 && puntaje >= 30)
            {
                notaFinal = 2;
            }
            else
            {
                notaFinal = 1;
            }

            Console.WriteLine($"\nLa nota final es {notaFinal}");
        }
    }
}
