using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontrar_Max_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int cantidad;

            do
            {
                Console.Write("Ingrese la cantidad de números a procesar (mayor que 0): ");
            } while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0);

            for (int i = 0; i < cantidad; i++)
            {
                int num;
                do
                {
                    Console.Write($"Ingrese el número #{i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out num));

                numeros.Add(num);
            }

            int max = numeros[0];
            int min = numeros[0];
            int iteraciones = 0;

            foreach (int n in numeros)
            {
                iteraciones++;
                if (n > max) max = n;
                if (n < min) min = n;
            }

            Console.WriteLine($"\nValor máximo: {max}");
            Console.WriteLine($"Valor mínimo: {min}");
            Console.WriteLine($"Cantidad de iteraciones: {iteraciones}");
        }
    }
}
