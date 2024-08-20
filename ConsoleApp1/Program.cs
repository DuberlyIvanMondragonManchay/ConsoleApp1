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

            Console.Read();
        }
    }
}
