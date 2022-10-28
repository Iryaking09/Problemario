using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, Factorial, Control;
            Console.WriteLine("Ingrese un numero para obtener su factorial: ");
            Numero = int.Parse(Console.ReadLine());
            Factorial = 1;
            for (int i = 1; i < (Numero+1); i++)
            {
                Factorial = Factorial * i;
            }
            Console.WriteLine("El Valor factorial de "+Numero+" es: "+Factorial);
            Console.ReadLine();
        }
    }
}
