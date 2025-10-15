using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Persona
    {
        public string Nombre;
        public string Apellido1;
        public string Apellido2;

        public string Telefono = "";
        public string Direccion = "";

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
