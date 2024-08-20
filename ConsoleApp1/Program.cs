using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();

            Persona persona = new Persona{
                Name = "Duberly",
                LastName = "Dubery",
            };
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            persona.Name = "Duberly";
            persona.LastName = "Mondragón";

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

            //Clase profesor
            Profesor profesor = new Profesor();
            profesor.Name = "Hugo";
            profesor.LastName = "Torrico";
            profesor.Sueldo = 1500;
            profesor.AsignarNombresCompletos();

            Console.WriteLine(profesor.NombresCompletos);

            //Clase estudiante
            Estudiante estudiante = new Estudiante();
            estudiante.Name = "Duberly";
            estudiante.LastName = "Mondragón";
            estudiante.Codigo = "115108";
            estudiante.AsignarNombresCompletos();

            Console.WriteLine(estudiante.NombresCompletos);



            Console.Read();
        }
    }
}
