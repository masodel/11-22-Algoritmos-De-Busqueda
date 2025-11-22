using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_De_Objetos
{
    public class Estudiante
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Estudiante() { }

        public Estudiante(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public List<Estudiante> CargarEstudiantes()
        {
            Random random = new Random();
            int NewId;

            Estudiante Estudiante1 = new Estudiante(NewId = random.Next(1000, 9999), "Rolando");
            Estudiante Estudiante2 = new Estudiante(NewId = random.Next(1000, 9999), "Tito");
            Estudiante Estudiante3 = new Estudiante(NewId = random.Next(1000, 9999), "Rodrigo");
            Estudiante Estudiante4 = new Estudiante(NewId = random.Next(1000, 9999), "Marvin");
            Estudiante Estudiante5 = new Estudiante(NewId = random.Next(1000, 9999), "Dylan");
            Estudiante Estudiante6 = new Estudiante(NewId = random.Next(1000, 9999), "Markus");
            Estudiante Estudiante7 = new Estudiante(NewId = random.Next(1000, 9999), "Jose");
            Estudiante Estudiante8 = new Estudiante(NewId = random.Next(1000, 9999), "Walter");
            Estudiante Estudiante9 = new Estudiante(NewId = random.Next(1000, 9999), "Steven");
            Estudiante Estudiante10 = new Estudiante(NewId = random.Next(1000, 9999), "Juan");

            List<Estudiante> ListaEstudiantes = new List<Estudiante>()
            {
                Estudiante1,
                Estudiante2,
                Estudiante3,
                Estudiante4,
                Estudiante5,
                Estudiante6,
                Estudiante7,
                Estudiante8,
                Estudiante9,
                Estudiante10
            };

            ListaEstudiantes.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));

            return ListaEstudiantes;
        }

        public void BuscarEstudiantePorNombre(string nombre, List<Estudiante> ListaEstudiantes)
        {
            int low = 0, high = ListaEstudiantes.Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int comparison = string.Compare(ListaEstudiantes[mid].Nombre, nombre, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    Console.WriteLine($"\nEstudiante encontrado: ID = {ListaEstudiantes[mid].Id}, Nombre = {ListaEstudiantes[mid].Nombre}\n");
                    return;
                }

                if (comparison < 0)
                {
                    low = mid + 1;
                }

                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("\nEstudiante no encontrado.\n");
        }

        public void BuscarEstudiantePorId(int id, List<Estudiante> ListaEstudiantes)
        {
            foreach (var estudiante in ListaEstudiantes)
            {
                if (estudiante.Id == (id))
                {
                    Console.WriteLine($"\nEstudiante encontrado: ID = {estudiante.Id}, Nombre = {estudiante.Nombre}\n");
                    return;
                }
            }

            Console.WriteLine("\nEstudiante no encontrado.\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            List<Estudiante> ListaEstudiantes = estudiante.CargarEstudiantes();

            while (true)
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Buscar estudiante por nombre");
                Console.WriteLine("2. Buscar estudiante por ID");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("\nIngrese el nombre del estudiante a buscar: ");
                        string nombreBuscado = Console.ReadLine();

                        estudiante.BuscarEstudiantePorNombre(nombreBuscado, ListaEstudiantes);

                        break;

                    case "2":
                        while (true)
                        {
                            Console.Write("\nIngrese el ID del estudiante a buscar: ");

                            if (int.TryParse(Console.ReadLine(), out int idBuscado))
                            {
                                estudiante.BuscarEstudiantePorId(idBuscado, ListaEstudiantes);
                                break;
                            }

                            else Console.WriteLine("\nID inválido. Por favor, ingrese un número entero.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nLista de Estudiantes:");

                        foreach (var item in ListaEstudiantes)
                        {
                            Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}");
                        }

                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine("\nSaliendo del programa.");
                        return;

                    default:
                        Console.WriteLine("\nOpción inválida. Por favor, seleccione una opción válida.\n");
                        continue;
                }

            }
        }
    }
}
