using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente : Persona
    {
        public List<string> Enfermedades;

        public Paciente(string nom, string ape1, string ape2) : base(nom, ape1, ape2) 
        { 
            Enfermedades = new List<string>();
        }

        public override string ToString()
        {
            return $"Paciente {Nombre} {Apellido1} {Apellido2}";
        }

    }
}
