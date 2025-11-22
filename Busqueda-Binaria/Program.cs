using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArregloRandom = new int[30];
            Random random = new Random();

            for (int i = 0; i < ArregloRandom.Length; i++)
            {
                ArregloRandom[i] = random.Next(1, 100);
            }

            Array.Sort(ArregloRandom);

            Console.Write("Escribe un número a buscar en el arreglo: ");
            if (!int.TryParse(Console.ReadLine(), out int numeroABuscar))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero.");
                return;
            }

            int high = 0, low = ArregloRandom.Length - 1;

            Console.WriteLine("\nIniciando búsqueda binaria...\n");

            while (high <= low)
            {
                int mid = (high + low) / 2;

                Console.WriteLine($"Índice alto: {high}, Índice bajo: {low}, Índice medio: {mid}\n");

                if (ArregloRandom[mid] == numeroABuscar)
                {
                    Console.WriteLine($"El número {numeroABuscar} fue encontrado en índice {mid}");
                    return;
                }

                if (numeroABuscar > ArregloRandom[mid])
                {
                    high = mid + 1;
                }

                else
                {
                    low = mid - 1;
                }
            }

            Console.WriteLine($"El número {numeroABuscar} no fue encontrado en el arreglo.");
        }
    }
}
