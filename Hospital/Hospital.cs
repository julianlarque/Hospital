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
        public string Nombre { get; set; }
        public List<Persona> PersonaList { get; set; }  

        public Hospital (string nombre)
        {
            Nombre = nombre;
            PersonaList = new List<Persona>();
        }
        public void AsignacionPaciente()
        {
            bool existe = false;
            Persona pacien = new Persona();
            Console.Clear();
            Console.WriteLine("### ASIGNACIÓN DE PACIENTES A MÉDICOS ####");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.Write("Primer Apellido del Paciente: ");
            string apePac = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el paciente en la lista de pacientes
            foreach (Persona pac1 in PersonaList)
            {
                if ((pac1.Apellido1 == apePac) && (pac1 is Paciente))
                {
                    pacien = pac1;  
                    Console.WriteLine($"Asignamos el paciente {pac1}");
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine($"Error, paciente de apellido {apePac} no encontrado!!!");
                Console.ReadKey();
                return;
            }
            // Mostramos los médicos disponibles
            //Console.WriteLine();    
            //Console.WriteLine("Médicos disponibles:");
            //foreach (Medico med in MedicoList)
            //    Console.WriteLine(med);

            Console.WriteLine();    
            Console.Write("Primer Apellido del Médico a asignar: ");
            string ape1 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el médico en la lista de médicos
            existe = false;
            foreach (Persona per in PersonaList)
            {
                if ((per.Apellido1 == ape1) && (per is Medico))
                {
                    Console.WriteLine($"Nuevo paciente para {per}");
                    ((Medico)per).AddPaciente((Paciente)pacien);
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");
                Console.WriteLine($"Imposible la asignación");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();
        }
        public void PacsporMedico()
        {
            bool existe = false;
            
            Console.Clear();
            Console.WriteLine("### PACIENTES ASIGNADOS A UN MÉDICO ####");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Primer Apellido del Médico: ");
            string apeMed = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el médico en la lista de médicos
            existe = false;
            foreach (Persona med in PersonaList)
            {
                if ((med.Apellido1 == apeMed) && (med is Medico))
                {
                    Console.WriteLine($"Pacientes asignados a {med}");
                    foreach (Paciente pac in ((Medico)med).Pacs)
                        Console.WriteLine(pac);
                    Console.ReadKey();
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine($"Error, médico de apellido {apeMed} no encontrado!!!");
                Console.ReadKey();
                return;
            }
        }
        
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Persona per in PersonaList)
                Console.WriteLine(per);

            Console.ReadKey();

        }
        public void CargaInicMedicos()
        {
            PersonaList.Add(new Medico("Manuel","López","Carrasco","Ginecología"));
            PersonaList.Add(new Medico("Pedro", "De la Cruz", "Sánchez", "Pediatría"));
            PersonaList.Add(new Medico("Laura", "Martínez", "Gómez", "Cardiología"));
            PersonaList.Add(new Medico("Andrés", "Ruiz", "Fernández", "Neurología"));
            PersonaList.Add(new Medico("Carlos", "Morales", "Vega", "Traumatología"));
            PersonaList.Add(new Medico("Lucía", "Castro", "Jiménez", "Oftalmología"));
            PersonaList.Add(new Medico("Javier", "Serrano", "Muñoz", "Psiquiatría"));
            PersonaList.Add(new Medico("María", "Ramos", "Pérez", "Oncología"));
            PersonaList.Add(new Medico("Sofía", "Navarro", "Luna", "Endocrinología"));
        }
        public void CargaInicPacientes()
        {
            PersonaList.Add(new Paciente("Eduardo", "Herrera", "Costa"));
            PersonaList.Add(new Paciente("Sebastián", "Ribera", "Lara"));
            PersonaList.Add(new Paciente("María", "González", "Ruiz"));
            PersonaList.Add(new Paciente("Andrés", "López", "Morales"));
            PersonaList.Add(new Paciente("Lucía", "Martínez", "Santos"));
            PersonaList.Add(new Paciente("Javier", "Torres", "Pérez"));
            PersonaList.Add(new Paciente("Elena", "Jiménez", "Castro"));
            PersonaList.Add(new Paciente("Carlos", "Navarro", "Vega"));
            PersonaList.Add(new Paciente("Sofía", "Domínguez", "Luna"));
            PersonaList.Add(new Paciente("Alejandro", "Ramos", "García"));
            PersonaList.Add(new Paciente("Paula", "Serrano", "Fernández"));
            PersonaList.Add(new Paciente("Diego", "Núñez", "Martín"));
            PersonaList.Add(new Paciente("Claudia", "Moreno", "Ibáñez"));
            PersonaList.Add(new Paciente("Fernando", "Cano", "Delgado"));
            PersonaList.Add(new Paciente("Isabel", "Vidal", "Romero"));
            PersonaList.Add(new Paciente("Miguel", "Crespo", "León"));
            PersonaList.Add(new Paciente("Patricia", "Suárez", "Molina"));
            PersonaList.Add(new Paciente("Raúl", "Reyes", "Ortega"));
            PersonaList.Add(new Paciente("Nuria", "Flores", "Campos"));
            PersonaList.Add(new Paciente("Daniel", "Cruz", "Santiago"));
        }

        public void CargaInicAdmin()
        {
            PersonaList.Add(new Administrativo("Manuel", "Crespo", "Martí", "Informática"));
            PersonaList.Add(new Administrativo("Pedro", "Luna", "Mas", "Contabilidad"));
            PersonaList.Add(new Administrativo("Laura", "Sánchez", "Ruiz", "Recursos Humanos"));
            PersonaList.Add(new Administrativo("Carlos", "Moreno", "Díaz", "Finanzas"));
            PersonaList.Add(new Administrativo("María", "Gómez", "Navarro", "Recursos Humanos"));
            PersonaList.Add(new Administrativo("Javier", "Torres", "Pérez", "Compras"));
            PersonaList.Add(new Administrativo("Lucía", "Romero", "Castillo", "Logística"));
            PersonaList.Add(new Administrativo("Andrés", "Fernández", "Gil", "Atención al Paciente"));
            PersonaList.Add(new Administrativo("Sofía", "Vega", "Ortega", "Legal"));
            PersonaList.Add(new Administrativo("Elena", "Martínez", "Ramos", "Informática"));
        }
        public void ListaMedicos()
        {
            Console.Clear ();
            Console.WriteLine("Listado de Médicos");
            Console.WriteLine("------------------");

            foreach (Persona per in PersonaList)
                if (per is Medico)
                    Console.WriteLine(per);

            Console.ReadKey();
        }
        public void ListaPacientes()
        {
            Console.Clear();
            Console.WriteLine("Listado de Pacientes");
            Console.WriteLine("--------------------");

            foreach (Persona per in PersonaList)
                if (per is Paciente)
                    Console.WriteLine(per);

            Console.ReadKey();
        }

        public bool Existe(string ape1,string tipo)
        {
            foreach (Persona per in PersonaList)
            {
                if ((per.Apellido1 == ape1) && (per.GetType().Name == tipo))
                    return true;
            }
            return false;
        }

        public Persona BuscaPersona(string ape1, string tipo)
        {
            foreach (Persona per in PersonaList)
            {
                if ((per.Apellido1 == ape1) && (per.GetType().Name == tipo))
                    return per;
            }
            return null;
        }
    }
}
