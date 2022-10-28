using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Numero;
            Console.WriteLine("Ingrese un numero para : ");
            Numero = int.Parse(Console.ReadLine());
            if ((Numero%2)==0)
            {
                Console.WriteLine("El numero "+Numero+". No es primo");
            }
            if(Numero%2==1)
            {
                Console.WriteLine("El numero " + Numero+". Es primo");
            }
            Console.ReadLine();
            
        }
    }
}
