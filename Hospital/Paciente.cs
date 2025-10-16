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

        public Paciente()
        {
        }

        public Paciente(string nom, string ape1, string ape2) : base(nom, ape1, ape2) 
        { 
            Enfermedades = new List<string>();
        }

        public override string ToString()
        {
            return $"Paciente {Nombre} {Apellido1} {Apellido2}";
        }

        public static Paciente Alta()
        {
            string nom1;
            string ape1;
            string ape2;

            Console.Clear();
            Console.WriteLine("### ALTA DE PACIENTES ####");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            
            Console.Write("Nombre          : ");
            nom1 = Console.ReadLine();
            Console.Write("Primer Apellido : ");
            ape1 = Console.ReadLine();
            Console.Write("Segundo Apellido: ");
            ape2 = Console.ReadLine();

            Paciente pacien1 = new Paciente(nom1, ape1, ape2);

            Console.WriteLine();
            Console.WriteLine($"Paciente creado correctamente con los siguientes datos: \n{pacien1}");
            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla");

            Console.ReadKey();
            return pacien1;
        }

        public static Persona Baja(List<Persona> pList)
        {
            bool existe = false;
            Persona p = new Persona();

            Console.Clear();
            Console.WriteLine("### BAJA DE PACIENTES ####");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("Primer Apellido : ");
            string ape1 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el paciente en la lista de pacientes
            foreach (Persona per in pList)
            {
                if ((per.Apellido1 == ape1) && (per is Paciente))
                {
                    //PersonaList.Remove(per
                    
                    Console.WriteLine($"Damos de baja a {per}");
                    p = per;
                    existe = true;

                    // Lo damos de baja de todos los médicos que lo teangan
                    //foreach (Persona med in PersonaList)
                    //    if (med is Medico)
                    //        ((Medico)med).BajaPaciente((Paciente)per);
                    //break;
                }
            }

            if (!existe)
                Console.WriteLine($"Error, paciente de apellido {ape1} no encontrado!!!");

            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();

            if (existe)
                return p;
            else
                return null;

        }
    }
}
