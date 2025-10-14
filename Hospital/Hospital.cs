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
        public string Nombre;
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

        public void AltaMedico()
        {
            string nom1;
            string ape1;
            string ape2;
            string espec;

            while (true) 
            {
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
                espec = Console.ReadLine();

                Medico medic = new Medico(nom1, ape1, ape2, espec);

                MedicoList.Add(medic);

                Console.WriteLine();
                Console.WriteLine($"Médico creado correctamente con los siguientes datos: \n{medic}");

                Console.WriteLine();
                Console.WriteLine("Pulsa cualquier tecla para continuar (S para salir)");

                char seleccion = char.ToUpper(Console.ReadKey().KeyChar);
                if (seleccion == 'S')
                    break;
            }
        }

        public void BajaMedico()
        {
            bool existe = false;

            Console.Clear();
            Console.WriteLine("### BAJA DE MÉDICOS ####");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            
            Console.Write("Primer Apellido : ");
            string ape1 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el médico en la lista de médicos
            foreach (Medico med in MedicoList) 
            {
                if (med.Apellido1 == ape1)
                {
                    MedicoList.Remove(med);
                    Console.WriteLine($"Damos de baja a {med}");
                    existe = true;
                    break;
                }
            }

            if (!existe)
                Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");

            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();


        }

        public void AsignacionPaciente()
        {

            bool existe = false;
            Medico especialista = new Medico();

            Console.Clear();
            Console.WriteLine("### ASIGNACIÓN DE PACIENTES A MÉDICOS ####");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.Write("Primer Apellido del Médico: ");
            string ape1 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el médico en la lista de médicos
            foreach (Medico med in MedicoList)
            {
                if (med.Apellido1 == ape1)
                {
                    //MedicoList.Remove(med);
                    especialista = med;
                    Console.WriteLine($"Nuevo paciente para {med}");
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");
                Console.ReadKey();
                return;
            }
            
            existe = false;

            Console.Write("Primer Apellido del Paciente: ");
            string ape2 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el paciente en la lista de pacientes

            foreach (Paciente pac1 in PacList)
            {
                if (pac1.Apellido1 == ape2)
                {
                    //PacList.Remove(pac1);
                    Console.WriteLine($"Asignamos el paciente {pac1} a {especialista}");
                    existe = true;
                    break;
                }
            }

            if (!existe)
                Console.WriteLine($"Error, paciente de apellido {ape1} no encontrado!!!");






            foreach (Medico med in MedicoList)
            {
                if (med.Apellido1 == ape1)
                {
                    //MedicoList.Remove(med);
                    Console.WriteLine($"Nuevo paciente para {med}");
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");
                Console.ReadKey();
                return;
            }







            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();




        }

        public void AltaPaciente()
        {
            string nom1;
            string ape1;
            string ape2;

            while (true)
            {
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

                PacList.Add(pacien1);

                Console.WriteLine();
                Console.WriteLine($"Paciente creado correctamente con los siguientes datos: \n{pacien1}");

                Console.WriteLine();
                Console.WriteLine("Pulsa cualquier tecla para continuar (S para salir)");

                char seleccion = char.ToUpper(Console.ReadKey().KeyChar);
                if (seleccion == 'S')
                    break;
            }

            //Console.ReadKey();
        }
        public void BajaPaciente()
        {
            bool existe = false;

            Console.Clear();
            Console.WriteLine("### BAJA DE PACIENTES ####");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("Primer Apellido : ");
            string ape1 = Console.ReadLine();

            Console.WriteLine();

            //Buscamos el paciente en la lista de pacientes
            foreach (Paciente pac1 in PacList)
            {
                if (pac1.Apellido1 == ape1)
                {
                    PacList.Remove(pac1);
                    Console.WriteLine($"Damos de baja a {pac1}");
                    existe = true;
                    break;
                }
            }

            if (!existe)
                Console.WriteLine($"Error, paciente de apellido {ape1} no encontrado!!!");

            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();


        }

        public void CargaInicMedicos()
        {
            MedicoList.Add(new Medico("Manuel","López","Carrasco","Ginecología"));
            MedicoList.Add(new Medico("Pedro", "De la Cruz", "Sánchez", "Pediatría"));
            MedicoList.Add(new Medico("Laura", "Martínez", "Gómez", "Cardiología"));
            MedicoList.Add(new Medico("Andrés", "Ruiz", "Fernández", "Neurología"));
            MedicoList.Add(new Medico("Elena", "Torres", "Domínguez", "Dermatología"));
            MedicoList.Add(new Medico("Carlos", "Morales", "Vega", "Traumatología"));
            MedicoList.Add(new Medico("Lucía", "Castro", "Jiménez", "Oftalmología"));
            MedicoList.Add(new Medico("Javier", "Serrano", "Muñoz", "Psiquiatría"));
            MedicoList.Add(new Medico("María", "Ramos", "Pérez", "Oncología"));
            MedicoList.Add(new Medico("Sofía", "Navarro", "Luna", "Endocrinología"));
        }

        public void CargaInicPacientes()
        {
            PacList.Add(new Paciente("Eduardo", "Herrera", "Costa"));
            PacList.Add(new Paciente("Sebastián", "Ribera", "Lara"));
            PacList.Add(new Paciente("María", "González", "Ruiz"));
            PacList.Add(new Paciente("Andrés", "López", "Morales"));
            PacList.Add(new Paciente("Lucía", "Martínez", "Santos"));
            PacList.Add(new Paciente("Javier", "Torres", "Pérez"));
            PacList.Add(new Paciente("Elena", "Jiménez", "Castro"));
            PacList.Add(new Paciente("Carlos", "Navarro", "Vega"));
            PacList.Add(new Paciente("Sofía", "Domínguez", "Luna"));
            PacList.Add(new Paciente("Alejandro", "Ramos", "García"));
            PacList.Add(new Paciente("Paula", "Serrano", "Fernández"));
            PacList.Add(new Paciente("Diego", "Núñez", "Martín"));
            PacList.Add(new Paciente("Claudia", "Moreno", "Ibáñez"));
            PacList.Add(new Paciente("Fernando", "Cano", "Delgado"));
            PacList.Add(new Paciente("Isabel", "Vidal", "Romero"));
            PacList.Add(new Paciente("Miguel", "Crespo", "León"));
            PacList.Add(new Paciente("Patricia", "Suárez", "Molina"));
            PacList.Add(new Paciente("Raúl", "Reyes", "Ortega"));
            PacList.Add(new Paciente("Nuria", "Flores", "Campos"));
            PacList.Add(new Paciente("Daniel", "Cruz", "Santiago"));
        }

        public void ListaMedicos()
        {
            Console.Clear ();
            Console.WriteLine("Listado de Médicos");
            Console.WriteLine("------------------");

            foreach (Medico med in MedicoList)
                Console.WriteLine(med);

            Console.ReadKey();

        }
        public void ListaPacientes()
        {
            Console.Clear();
            Console.WriteLine("Listado de Pacientes");
            Console.WriteLine("--------------------");

            foreach (Paciente pac in PacList)
                Console.WriteLine(pac);

            Console.ReadKey();

        }
    }



}
