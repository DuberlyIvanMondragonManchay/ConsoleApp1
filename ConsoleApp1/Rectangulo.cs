using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangulo
    {
        public int Base{ get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return Base * Altura;
        }

        public int CalcularPerimetro()
        {
            return 2*(Base + Altura);
        }
    }
}
