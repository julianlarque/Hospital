using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Util
    {

        public static double LeerDouble(string mensaje, int x, int y)
        {
            double valor;
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                    return 0;

                if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.GetCultureInfo("es-ES"), out valor))
                {
                    Console.SetCursorPosition(x + 10, y);
                    Console.Write("                  ");
                    return valor;
                }
        
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x+10,y);
                Console.Write("Valor no válido");
                Console.ResetColor();
            }
        }
        public static double LeerDouble(int x, int y, string mensaje)
        {
             return LeerDouble(mensaje, x, y);
        }
    }
}