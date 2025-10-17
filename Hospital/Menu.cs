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


                                     ---- GESTIÓN DE UN HOSPITAL ----



                    1 - Alta Médico                        A - Listado completo de Personas
                    2 - Baja Médico                        B - Listado de Médicos                     
                    3 - Alta Paciente                      C - Listado de Pacientes
                    4 - Baja Paciente
                    5 - Asignar Médico a Paciente          D - Listado de Pacientes por Médico
                    6 - Modificar Médico
                    7 - 
                    8 - 
                    9 - 

                    S - Salir

                    Selecciona la opción ");

            //Leemos la tecla como pulsación
            char seleccion = char.ToUpper(Console.ReadKey().KeyChar);
            return seleccion;
        }
    }
}
