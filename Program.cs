using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucesionFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool final = true;
            while (final == true)
            {
                Console.Clear();
                Program.Menu();
                while (!int.TryParse(Console.ReadLine(),out option))
                {
                    Console.WriteLine("Dato no válido");
                }
                switch (option) 
                {
                    case 1: Metodos.Generador(); break;
                    case 2: Metodos.Posicion(); break;
                    case 0: final = false; break;
                }
            }
            
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
        private static void Menu()
        {
            Console.WriteLine("----------");
            Console.WriteLine("La secuencia de Fibonacci:");
            Console.WriteLine("----------");
            Console.WriteLine("1.Generador");
            Console.WriteLine("2.Posición");
            Console.WriteLine("0.Salir");
            Console.WriteLine("----------");
        }
    }
    class Metodos
    {
        public static void Generador ()
        {
            bool final = false;
            ulong prim = 1, secun = 1, aux;
            string seguir;
            while (!final)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.Write($" [{prim},{secun}] ");
                    aux = secun;
                    secun = prim + secun;
                    prim = aux;
                }
                Console.WriteLine("\nInserta \"n\" para parar, en caso contrario, pulsa enter");
                seguir = Console.ReadLine();
                if (seguir == "n")
                {
                    final = true;
                }
            }
            Console.WriteLine("\nPulsa una tecla para volver al menú principal");
            Console.ReadKey();
        }
        public static void Posicion ()
        {
            ulong prim = 1, secun = 1, aux, pos;
            Console.WriteLine("Dame la posición que quieres:");
            while (!ulong.TryParse(Console.ReadLine(),out pos))
            {

            }
            for (ulong i = 0; i < pos; i++)
            {
                aux = secun;
                secun = prim + secun;
                prim = aux;
            }
            Console.Write($" [{prim},{secun}] ");
            Console.WriteLine("\nPulsa una tecla para volver al menú principal");
            Console.ReadKey();
        }
    }
}