using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Score;
            string Name;
            Console.WriteLine("Ingrese su nombre: ");
            Name = (Console.ReadLine());
            Console.WriteLine("Ingrese su puntuacion: ");
            Score = int.Parse(Console.ReadLine());
            Actualizar(Score, Name);
            Console.Read();
        }
        static void Actualizar(int Score, string Name)
        {
            int ScoreInitial = 1565;
            String NameOne = "Darwin";
            if (ScoreInitial < Score)
            {
                Console.WriteLine("La nueva puntuacion mas alta es: " + Score);
                Console.WriteLine("La puntuacion mas alta fue lograda por: " + Name);
            }
            else
            {
                Console.WriteLine("La puntuacion mas alta fue: " + ScoreInitial + " No se ha podido superar, y aun esta en manos de " + NameOne);

            }
        }
    }
}
