using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        public Persona(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public Persona()
        {

        }

        public string Name{ get; set; }
        public string LastName{ get; set; }
        public string NombresCompletos { get; set; }

        public void AsignarNombresCompletos()
        {
            NombresCompletos = Name + " " + LastName;
        }
    }
}
