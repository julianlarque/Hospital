using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Persona
    {
        public string Nombre { get; set; } 
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido1, string apellido2)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;    
        }
    }
}
