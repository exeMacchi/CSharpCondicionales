using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Equipos_de_rescate
{
    internal class Ejercicio02
    {
        static void Main(string[] args)
        {
            /*
                2. Para que una persona prepare tres equipos de rescate A, B y C. Se sabe que se tarda 15 minutos
                   en preparar el equipo A, 20 con el equipo B, y 23 con el equipo C. La cantidad de rescatistas según
                   el equipamiento se ingresa por teclado (cantidad de A, de B y de C). ¿Cuántos minutos tardará dicha
                   persona en preparar los equipos de todos los rescatistas?
            */

            Console.Write("Ingrese la cantidad de rescatistas del grupo A: ");
            int grupoA = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de rescatistas del grupo B: ");
            int grupoB = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de rescatistas del grupo C: ");
            int grupoC = int.Parse(Console.ReadLine());

            int minutosGrupoA = grupoA * 15, horasGrupoA = 0;
            int minutosGrupoB = grupoB * 20, horasGrupoB = 0;
            int minutosGrupoC = grupoC * 23, horasGrupoC = 0;

            if (minutosGrupoA >= 60)
            {
                horasGrupoA = minutosGrupoA / 60;
                minutosGrupoA = minutosGrupoA % 60;
            }
            if (minutosGrupoB >= 60)
            {
                horasGrupoB = minutosGrupoB / 60;
                minutosGrupoB = minutosGrupoB % 60;
            }
            if (minutosGrupoC >= 60)
            {
                horasGrupoC = minutosGrupoC / 60;
                minutosGrupoC = minutosGrupoC % 60;
            }

            Console.WriteLine($"\nTiempo total para preparar al grupo A: {horasGrupoA} horas, {minutosGrupoA} minutos.");
            Console.WriteLine($"Tiempo total para preparar al grupo B: {horasGrupoB} horas, {minutosGrupoB} minutos.");
            Console.WriteLine($"Tiempo total para preparar al grupo C: {horasGrupoC} horas, {minutosGrupoC} minutos.");
        }
    }
}
