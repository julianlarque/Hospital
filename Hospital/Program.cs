using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char seleccion = ' ';
            string ape1 = "";
            Persona p = new Persona();

            Hospital miHospital = new Hospital("Hospital de Barcelona");

            miHospital.CargaInicMedicos();
            miHospital.CargaInicPacientes();
            miHospital.CargaInicAdmin();

            Menu miMenu = new Menu();

            while (true) 
            { 
                seleccion = miMenu.Opcion();
                if (seleccion == 'S')
                {
                    Console.Clear();
                    break;
                }
                    
                switch (seleccion)
                {
                    case '1':
                        // Alta Médico
                        miHospital.PersonaList.Add(Medico.PantallaAlta());
                        break;

                    case '2':
                        // Baja Médico
                        ape1 = Medico.PantallaBaja();
                        p =miHospital.BuscaPersona(ape1, "Medico");
                        if (p != null)
                        {
                            miHospital.PersonaList.Remove(p);
                            Console.WriteLine($"{p} dado de baja correctamente");
                        }
                        else
                        {
                            Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");
                        }
                        Console.ReadKey();
                        break;
                    
                    case '3':
                        miHospital.PersonaList.Add(Paciente.Alta());
                        break;
                    
                    case '4':
                        p = Paciente.Baja(miHospital.PersonaList);
                        if (p != null)
                        {
                            miHospital.PersonaList.Remove(p);
                            // También lo desasignamos de los médicos que lo tengan
                            foreach (Persona med in miHospital.PersonaList)
                                if (med is Medico)
                                        ((Medico)med).BajaPaciente((Paciente)p);
                        }
                        break;

                    case '5':
                        miHospital.AsignacionPaciente();
                        break;

                    case '6':
                        //Modificación Médico
                        Medico.EsqueletoFicha();
                        Console.SetCursorPosition(21,6);
                        ape1 = Console.ReadLine();
                        p = miHospital.BuscaPersona(ape1, "Medico");
                        if (p == null)
                        {
                            Console.SetCursorPosition(1, 15);
                            Console.WriteLine($"Error, médico de apellido {ape1} no encontrado!!!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            ((Medico)p).PantallaModificacion();
                            break;
                        }
                           
                    case 'B':
                        miHospital.ListaMedicos();
                        break;

                    case 'C':
                        miHospital.ListaPacientes();
                        break;

                    case 'D':
                        miHospital.PacsporMedico();
                        break;

                    case 'A':
                        miHospital.ListadoGeneral();
                        break;
                }
            }
        }
    }
}
