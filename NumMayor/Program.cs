using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Introduzca el primer numero a analizar: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero a analizar: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero a analizar: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1>num2) 
            {
                if (num1 > num3) 
                {
                    Console.WriteLine("El mayor es: "+num1);
                }
                else
                {
                    Console.WriteLine("El mayor es: "+num3);
                }
            }
            else
            {
                if (num2 > num3) 
                {
                    Console.WriteLine("El mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("El mayor es: " + num3);
                }
            }
            Console.ReadLine();
        }
    }
}
