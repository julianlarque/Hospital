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
                        miHospital.PersonaList.Add(Medico.Alta());
                        break;

                    case '2':
                        p = Medico.Baja(miHospital.PersonaList);
                        if (p != null)
                            miHospital.PersonaList.Remove(p);
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
