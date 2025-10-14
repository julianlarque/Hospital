using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Hospital
    {
        Public string Nombre;
        public List<Medico> MedicoList;
        public List<Administrativo> AdminList;
        public List<Paciente> PacList;

        public Hospital (string nombre)
        {
            Nombre = nombre;

            MedicoList = new List<Medico> ();
            AdminList = new List<Administrativo> ();
            PacList = new List<Paciente> ();
        }

    }



}
