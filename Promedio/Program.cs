using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desicion;
            float Calificacion, Acumulado, Promedio, Materias;
            desicion = "";
            Materias = 0;
            Acumulado = 0;
            Promedio = 0;
            while (desicion != "fin")
            {
                Console.Write("Ingrese una Calificacion: ");
                Calificacion = int.Parse(Console.ReadLine());
                Materias++;
                Acumulado = Acumulado + Calificacion;
                Promedio = Acumulado / Materias;
                Console.Write("Desea finalizar [fin] sino Enter: ");
                desicion  hub= (Console.ReadLine());
            }
            //do
                //{
                //    Console.WriteLine("Ingrese una Calificacion: ");
                //    Calificacion = int.Parse(Console.ReadLine());
                //    Materias++;
                //    Acumulado = Acumulado + Calificacion;
                //    Promedio = Acumulado / Materias;
                //} while (true);
                //string calificacion;
                //int numero;
                //bool validacion;
                //do
                //{
                //    Console.Write("Ingrese una Calificacion: ");
                //    calificacion = (Console.ReadLine());
                //    validacion = int.TryParse(calificacion, out numero);

                //    if (validacion == true)
                //    {
                //        Materias++;
                //        Acumulado = Acumulado + numero; 
                //        Promedio = Acumulado / Materias;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Calculando el primedio");
                //        Console.WriteLine("\nPresione Ctr + C Terminar\n");
                //        Console.ReadKey();
                //    }

                //} while (validacion = true);
                Console.WriteLine("El promedio de " + Materias + " es: " + Promedio);
            Console.ReadLine();
        }
    }
}
