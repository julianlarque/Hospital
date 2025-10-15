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

        public void BajaPaciente(Paciente pac1) 
        {
            if (EsPaciente(pac1))
            {
                Pacs.Remove(pac1);
                Console.WriteLine($"{pac1} desasignado de {this}");
            }
                
        }

        public bool EsPaciente(Paciente pac1)
        {
            foreach (Paciente p in Pacs)
            {
                if (p == pac1)
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Doctor/a {Nombre} {Apellido1} {Apellido2} de especialidad {Especialidad}";
        }
    }
}
