using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fecha;
            Console.WriteLine("Introduzca un año: ");
            fecha = int.Parse(Console.ReadLine());
            if ((fecha % 4) != 0) {
                Console.WriteLine("El año: "+fecha+" no es año bisiesto");
            }
            else if ((fecha % 4) == 0 && (fecha % 100) != 0)
            {
                Console.WriteLine("El año: " + fecha + " no es año bisiesto");
            }
            else if ((fecha % 4) == 0 && (fecha % 100) == 0)
            {
                Console.WriteLine("El año: "+fecha+" es año bisiesto");
            }
            Console.ReadLine();
        }
    }
}
