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
        public static Medico PantallaAlta()
        {
            string nom1;
            string ape1;
            string ape2;
            string especialidad;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("       ### ALTA DE MÉDICOS ####");
            Console.WriteLine("       ------------------------");
            Console.WriteLine();

            Console.Write("   Nombre          : ");
            nom1 = Console.ReadLine();
            Console.Write("   Primer Apellido : ");
            ape1 = Console.ReadLine();
            Console.Write("   Segundo Apellido: ");
            ape2 = Console.ReadLine();
            Console.Write("   Especialidad    : ");
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

        public static string PantallaBaja()
        {
            Console.Clear();
            Console.WriteLine("### BAJA DE MÉDICOS ####");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.Write("Primer Apellido : ");
            string ape1 = Console.ReadLine();
            return ape1;
        }

        public void PantallaModificacion()
        {
            string entrada = "";

            EsqueletoFicha();

            Console.SetCursorPosition(21,5);
            Console.Write(this.Nombre);
            Console.SetCursorPosition(21,6);
            Console.Write(this.Apellido1);
            Console.SetCursorPosition(21,7);
            Console.Write(this.Apellido2);
            Console.SetCursorPosition(21,8);
            Console.Write(this.Especialidad);
            Console.SetCursorPosition(21,10);
            Console.Write(this.Sueldo);
            Console.SetCursorPosition(21,11);
            Console.Write(this.Telefono);
            Console.SetCursorPosition(21,12);
            Console.Write(this.Direccion);

            Console.SetCursorPosition(1,14);
            Console.WriteLine("Introduzca los nuevos datos (Intro para no modificar)");

            // Modificamos los datos
            Console.SetCursorPosition(21,5);
            entrada = Console.ReadLine();   
            if(entrada != "")
                this.Nombre = entrada;

            Console.SetCursorPosition(21, 6);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Apellido1 = entrada;

            Console.SetCursorPosition(21, 7);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Apellido2 = entrada;

            Console.SetCursorPosition(21, 8);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Especialidad = entrada;

            // Campos adicionales
            Console.SetCursorPosition(21, 10);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Sueldo = double.Parse(entrada);

            Console.SetCursorPosition(21, 11);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Telefono = entrada;

            Console.SetCursorPosition(21, 12);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Direccion = entrada;

            // Finalizamos
            Console.SetCursorPosition(0,14);
            Console.WriteLine($"{this} modificado correctamente");

            Console.ReadKey();
        }
        public static void EsqueletoFicha()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("        ### FICHA DE MÉDICO ####");
            Console.WriteLine("        ------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   Nombre          : " );
            Console.WriteLine("   Primer Apellido : " );
            Console.WriteLine("   Segundo Apellido: " );
            Console.WriteLine("   Especialidad    : " );
            Console.WriteLine();
            Console.WriteLine("   Sueldo          : " );
            Console.WriteLine("   Teléfono        : " );
            Console.WriteLine("   Dirección       : " );
            Console.WriteLine();

        }
    }
}
