using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperatura;
            int numero;
            bool comprueba;
            do  {
                Console.Clear();
                Console.Write("Ingrese un valor de temperatura: ");
                temperatura = (Console.ReadLine());
                comprueba = int.TryParse(temperatura, out numero);
                //Console.WriteLine(comprueba);
                if (numero <= 15)
                {
                    Console.WriteLine("Hace mucho frio");
                }else if(numero >= 16 && numero  <= 28)
                {
                    Console.WriteLine("Hace un clima agradable");
                }
                else
                {
                    Console.WriteLine("Hace mucho calor"); 
                }

                Console.WriteLine("\nEnter continuar, Ctr + C Terminar\n");
                Console.ReadKey();
            } while (true);
            
        }
    }
}
