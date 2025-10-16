using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Medico : Empleado
    {
        public string Especialidad { get; set; }

        // Lista de pacientes asignados al médico
        public List<Paciente> Pacs { get; set; }

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
        public static Medico Alta()
        {
            string nom1;
            string ape1;
            string ape2;
            string especialidad;

            Console.Clear();
            Console.WriteLine("### ALTA DE MÉDICOS ####");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.Write("Nombre          : ");
            nom1 = Console.ReadLine();
            Console.Write("Primer Apellido : ");
            ape1 = Console.ReadLine();
            Console.Write("Segundo Apellido: ");
            ape2 = Console.ReadLine();
            Console.Write("Especialidad    : ");
            especialidad = Console.ReadLine();

            Medico medico1 = new Medico(nom1, ape1, ape2, especialidad);

            Console.WriteLine();
            Console.WriteLine($"Médico creado correctamente con los siguientes datos: \n{medico1}");
            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla");

            Console.ReadKey();
            return medico1;
        }

        public static Persona Baja(List<Persona> pList)
        {
            // A partir del primer apellido buscamos el objeto médico que retornamos 
            // para poder dar de baja

            bool existe = false;
            Persona med = new Persona();

            Console.Clear();
            Console.WriteLine("### BAJA DE MÉDICOS ####");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.Write("Primer Apellido : ");
            string ape1 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el médico en la lista de médicos
            foreach (Persona per in pList)
            {
                if ((per.Apellido1 == ape1) && (per is Medico))
                {
                    //PersonaList.Remove(per);
                    Console.WriteLine($"Damos de baja a {per}");
                    med = per;
                    existe = true;
                    break;
                }
            }

            if (!existe)
                Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");

            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();

            if (existe)
                return med;
            else
                return null;
        }


    }

}
