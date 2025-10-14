using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Medico : Empleado
    {
        public string Especialidad;
        
        // Lista de pacientes asignados al médico
        public List<Paciente> Pacs;

        public Medico()
        {

        }

        public Medico(string nom, string ape1, string ape2, string especialidad) : base(nom, ape1, ape2, "Médico")
        {

            Especialidad = especialidad;
            Pacs = new List<Paciente>();

        }

        public void AddPaciente(Paciente pac1)
        {
            Pacs.Add(pac1);
        }


        public override string ToString()
        {
            return $"Doctor {Nombre} {Apellido1} {Apellido2} de especialidad {Especialidad}";
        }



    }
}
