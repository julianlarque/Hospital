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

            Menu miMenu = new Menu();

            while (true) 
            { 
            
                seleccion = miMenu.Opcion();
                if (seleccion == 'S')
                    break;

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

                    case '6':
                        miHospital.ListaMedicos();
                        break;

                    case '7':
                        miHospital.ListaPacientes();
                        break;

                }
            }

            /*        

            miHospital.AltaPaciente();
            miHospital.ListaPacientes();
            */

            /*
            Menu miMenu = new Menu();
            miMenu.Opcion();

            */

            //Console.ReadKey();


        }
    }
}
