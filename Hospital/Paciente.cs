using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente : Persona
    {
        public List<string> Enfermedades { get; set; }

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
            Console.WriteLine();    
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

        public static void EsqueletoFicha()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(@"
                             ### FICHA DE PACIENTE ####
                             --------------------------

   Nombre          :
   Primer Apellido : 
   Segundo Apellido:

   Teléfono        : 
   Dirección       :
                                                                          ");
            Console.ResetColor();

        }
        public void PantallaModificacion()
        {
            string entrada = "";

            EsqueletoFicha();

            Console.SetCursorPosition(21, 5);
            Console.Write(this.Nombre);
            Console.SetCursorPosition(21, 6);
            Console.Write(this.Apellido1);
            Console.SetCursorPosition(21, 7);
            Console.Write(this.Apellido2);
            
            Console.SetCursorPosition(21, 9);
            Console.Write(this.Telefono);
            Console.SetCursorPosition(21, 10);
            Console.Write(this.Direccion);

            Console.SetCursorPosition(1, 14);
            Console.WriteLine("Introduzca los nuevos datos (Intro para no modificar)");

            // Modificamos los datos
            Console.SetCursorPosition(21, 5);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Nombre = entrada;

            Console.SetCursorPosition(21, 6);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Apellido1 = entrada;

            Console.SetCursorPosition(21, 7);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Apellido2 = entrada;

            Console.SetCursorPosition(21, 9);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Telefono = entrada;

            Console.SetCursorPosition(21, 10);
            entrada = Console.ReadLine();
            if (entrada != "")
                this.Direccion = entrada;

            // Finalizamos
            Console.SetCursorPosition(0, 14);
            Console.WriteLine($"{this} modificado correctamente                 ");

            Console.ReadKey();
        }
        public static Paciente PantallaAlta2()
        {
            string entrada = "";
            Paciente pac = new Paciente();

            EsqueletoFicha();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(36, 4);
            Console.WriteLine("--- ALTA ---");
            Console.ResetColor();

            Console.SetCursorPosition(1, 14);
            Console.WriteLine("Introduzca los datos del nuevo Paciente");

            // Modificamos los datos
            Console.SetCursorPosition(21, 5);
            entrada = Console.ReadLine();
            pac.Nombre = entrada;

            Console.SetCursorPosition(21, 6);
            entrada = Console.ReadLine();
            pac.Apellido1 = entrada;

            Console.SetCursorPosition(21, 7);
            entrada = Console.ReadLine();
            pac.Apellido2 = entrada;


            // Campos adicionales

            Console.SetCursorPosition(21, 9);
            entrada = Console.ReadLine();
            pac.Telefono = entrada;

            Console.SetCursorPosition(21, 10);
            entrada = Console.ReadLine();
            pac.Direccion = entrada;

            // Finalizamos
            Console.SetCursorPosition(0, 14);
            Console.WriteLine($"{pac} creado correctamente");

            Console.ReadKey();

            return pac;

        }
        public static string PantallaBaja()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("### BAJA DE UN PACIENTE ####");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.Write("Primer Apellido : ");
            string ape1 = Console.ReadLine();
            return ape1;
        }
    }
}
