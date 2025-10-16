using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Empleado : Persona
    {
        public double Sueldo { get; set; }
        public string Departamento { get; set; }

        public Empleado()
        {
        }

        public Empleado(string nom, string ape1, string ape2, string dept) : base (nom,ape1,ape2) 
        {
            Departamento = dept;
        }       
    }
}
