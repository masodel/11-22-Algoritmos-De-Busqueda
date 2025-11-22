using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Lineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArregloRanodm = new int[20];
            Random rand = new Random();

            int index = 0;

            for (int i = 0; i < ArregloRanodm.Length; i++)
            {
                ArregloRanodm[i] = rand.Next(1, 100);
            }

            Console.Write("Escribe un número a buscar en el arreglo: ");

            if (!int.TryParse(Console.ReadLine(), out int numeroABuscar))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero.");
                return;
            }

            foreach (var numero in ArregloRanodm)
            {
                if (numero == numeroABuscar)
                {
                    Console.WriteLine($"El número {numeroABuscar} fue encontrado en índice {index}");
                    return;
                }

                index++;
            }

            Console.WriteLine($"El número {numeroABuscar} no fue encontrado en el arreglo.");
        }
    }
}
