using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Matriz2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rnd.Next(1, 101);
                }
            }

            int numeroBuscado;
            do
            {
                Console.Write("Ingrese un número a buscar (1-100): ");
            } while (!int.TryParse(Console.ReadLine(), out numeroBuscado) || numeroBuscado < 1 || numeroBuscado > 100);

            bool encontrado = false;
            int iteraciones = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    iteraciones++;
                    if (matriz[i, j] == numeroBuscado)
                    {
                        Console.WriteLine($"Número encontrado en posición [{i},{j}]");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
                Console.WriteLine("Número no encontrado en la matriz.");

            Console.WriteLine($"Cantidad de iteraciones realizadas: {iteraciones}");
        }
    }
}
