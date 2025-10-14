using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Menu
    {

        public Menu()
        {
        }

        public char Opcion()
        {
            // Pintamos el menú y devolvemos la opción seleccionada
            Console.Clear();
            Console.Write(@"

                    GESTIÓN DE UN HOSPITAL

                    1 - Alta Médico
                    2 - Baja Médico
                    3 - Alta Paciente
                    4 - Baja Paciente
                    5 - Asignar Médico a Paciente
                    6 - Lista Médicos
                    7 - Lista Pacientes
                    8 - Lista Pacientes por Médico
                    9 - 

                    S - Salir

                    Selecciona la opción ");

            //Leemos la tecla como pulsación
            char seleccion = char.ToUpper(Console.ReadKey().KeyChar);
            return seleccion;
        }
    }
}
