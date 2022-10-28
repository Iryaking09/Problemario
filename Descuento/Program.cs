using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pedido;
            double descuento, subtotal, total;
            Console.WriteLine("------------------- Muebleria Peréz -------------------");
            Console.WriteLine("----------- Costo de un escritorio: $6,500 -----------");
            Console.WriteLine("Introduzca la cantidad de escritorio(s) que desea adquirir: ");
            pedido = int.Parse(Console.ReadLine());
            if (pedido < 5)
            {
                subtotal = (pedido * 6500);
                descuento = subtotal * 0.10;
                total = subtotal - descuento;
                Console.WriteLine("El valor a pagar es de: " + total);
            }
            else if (pedido >= 5 && pedido < 10)
            {
                subtotal = (pedido * 6500);
                descuento = subtotal * 0.20;
                total = subtotal - descuento;
                Console.WriteLine("El valor a pagar es de: " + total);
            }
            else if (pedido >=  10)
            {
                subtotal = (pedido * 6500);
                descuento = subtotal * 0.40;
                total = subtotal - descuento;
                Console.WriteLine("El valor a pagar es de: " + total);
            }
            Console.ReadLine();
        }
    }
}
