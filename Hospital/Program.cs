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
                        miHospital.AltaMedico();
                        break;

                    case '2':
                        miHospital.BajaMedico();
                        break;

                    case '3':
                        miHospital.AltaPaciente(); 
                        break;
                    
                    case '4':
                        miHospital.BajaPaciente();
                        break;

                    case '5':
                        miHospital.AsignacionPaciente();
                        break;

                    case '6':
                        miHospital.ListaMedicos();
                        break;

                    case '7':
                        miHospital.ListaPacientes();
                        break;

                    case '8':
                        miHospital.PacsporMedico();
                        break;

                    case '9':
                        miHospital.ListadoGeneral();
                        break;
                }
            }
        }
    }
}
