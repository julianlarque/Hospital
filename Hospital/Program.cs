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
            Hospital miHospital = new Hospital("Hospital de Barcelona");

            miHospital.CargaInicMedicos();
            miHospital.CargaInicPacientes();

            //miHospital.AltaMedico();
            //miHospital.ListaMedicos();

            miHospital.AltaPaciente();
            miHospital.ListaPacientes();


            /*
            Menu miMenu = new Menu();
            miMenu.Opcion();

            */

            Console.ReadKey();


        }
    }
}
