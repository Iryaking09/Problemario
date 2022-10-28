using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            bool multiplo;
            Console.WriteLine("Introduzca el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1;
            //while (result != 0)
            //{
            //}
            do
            {
                result = result - num2;
                multiplo = true;
                if (result<0)
                {
                    multiplo = false;
                    result = 0;
                }
            } while (result != 0);
            if (multiplo == true)
            {
                Console.WriteLine("El numero "+ num2 + " es multiplo de : "+num1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El numero " + num2 + " no es multiplo de : " + num1);
                Console.ReadLine();
            }
            
        }
    }
}
