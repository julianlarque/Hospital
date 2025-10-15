using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Administrativo : Empleado
    {
        public string Departamento = ""; //Informática, Administración, Información

        public Administrativo()
        {
        }

        public Administrativo(string nom, string ape1, string ape2, string depar) : base(nom, ape1, ape2, "Laboral")
        {
            Departamento = depar;
        }
        public override string ToString()
        {
            return $"Personal Administrativo {Nombre} {Apellido1} {Apellido2} del departamento {Departamento}";
        }
    }
}
