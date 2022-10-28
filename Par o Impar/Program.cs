using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_o_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                String Text;
                int Validar;
                Console.WriteLine("Introduzca el numero a analizar: ");
                Text = Console.ReadLine();
                bool Numero = int.TryParse(Text, out Validar);
                if (Numero) { 
                    if (Validar % 2 == 0)
                    {
                        Console.WriteLine("El numero es par");                        
                    }
                    else
                    {
                        Console.WriteLine("El numero es impar");                        
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un numero");
                }



                Console.WriteLine("\nPresiones enter para continuar o Ctr + C para finalizar\n");
                Console.ReadKey();
            } while (true);
            //int num;
            //Console.WriteLine("Introduzca el numero a analizar: ");
            //num = int.Parse(Console.ReadLine());
            //if((num%2)==0){
            //    Console.WriteLine("El numero es par");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("El numero es impar");
            //    Console.ReadLine();
            //}
        }
    }
}
