using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, primero, segundo, tercero;
            Console.WriteLine("Introduzca el primer numero a analizar: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero a analizar: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer numero a analizar: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                primero = num1;
                if (primero > num3)
                {
                    if (num2>num3)
                    {
                        segundo = num2;
                        tercero = num3;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                    else
                    {
                        segundo = num3;
                        tercero = num2;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                }
                else
                {
                    primero = num3;
                    if (num2 > num3)
                    {
                        segundo = num2;
                        tercero = num1;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                    else
                    {
                        segundo = num1;
                        tercero = num2;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                }
            }
            else if (num2>num1)
            {
                primero = num2;
                if (primero > num3)
                {
                    if (num1>num3)
                    {
                        segundo = num1;
                        tercero = num3;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                    else
                    {
                        segundo = num3;
                        tercero = num1;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                }
                else
                {
                    primero = num3;
                    if (num1 > num3)
                    {
                        segundo = num1;
                        tercero = num2;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                    else
                    {
                        segundo = num2;
                        tercero = num1;
                        Console.WriteLine("El mayor es: " + primero);
                        Console.WriteLine("El medio es: " + segundo);
                        Console.WriteLine(" y el menor es: " + tercero);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
