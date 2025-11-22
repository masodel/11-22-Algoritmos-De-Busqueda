using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_De_Texto
{
    internal class Program
    {
        public void BuscarEnParrafo(string parrafo, string palabra)
        {
            parrafo = parrafo.ToLower();
            palabra = palabra.ToLower();

            int contador = 0;

            for (int i = 0; i <= parrafo.Length - palabra.Length; i++)
            {
                bool encontrado = true;

                for (int j = 0; j < palabra.Length; j++)
                {
                    if (parrafo[i + j] != palabra[j])
                    {
                        encontrado = false;
                        break;
                    }
                }

                if (encontrado) contador++;
            }

            if (contador > 0) Console.WriteLine($"\nLa palabra '{palabra}' fue encontrada {contador} veces en el párrafo.");
            
            else Console.WriteLine($"\nLa palabra '{palabra}' no fue encontrada en el párrafo.");
        }

        public String CargarParrafo()
        {
            return "La tecnología avanza cada día y cambia la forma en que las personas se comunican. Muchas herramientas digitales facilitan el acceso a la información, pero también pueden causar distracciones. Por eso, es importante aprender a usar la tecnología de manera responsable para aprovechar sus beneficios sin afectar la concentración.";
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            string parrafoPredefinido = program.CargarParrafo();

            string parrafo = "";

            while (true)
            {
                Console.Write("¿Deseas usar un párrafo predefinido? (S/N): ");
                string respuesta = Console.ReadLine().ToUpper().Trim();

                switch (respuesta)
                {
                    case "S":
                        parrafo = parrafoPredefinido;

                        Console.WriteLine("\nPárrafo predefinido cargado:");
                        Console.WriteLine(parrafo);

                        break;

                    case "N":
                        Console.Write("Escribe un párrafo: ");
                        parrafo = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opcion inválida");
                        continue;
                }

                break;
            }

            Console.Write("\nEscribe la palabra a buscar en el párrafo: ");
            string palabra = Console.ReadLine();

            program.BuscarEnParrafo(parrafo, palabra);
        }
    }
}
