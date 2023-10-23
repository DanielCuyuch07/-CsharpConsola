using System;
using System.Collections.Generic;
using System.Threading;


namespace Gestor_D_Tareas
{
    class Program
    {
        static List<Tasks> tareas = new List<Tasks>();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Gestor de Tareas");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Mostrar tareas");
                Console.WriteLine("5. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la descripción de la tarea: ");
                        string descripcion = Console.ReadLine();
                        tareas.Add(new Tasks { Descripcion = descripcion, Completada = false }); // Cambiado a Tasks
                        break;
                    case "2":
                        Console.Write("Índice de la tarea a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceEliminar) && indiceEliminar >= 0 && indiceEliminar < tareas.Count)
                        {
                            tareas.RemoveAt(indiceEliminar);
                        }
                        else
                        {
                            Console.WriteLine("Índice no válido.");
                        }
                        break;
                    case "3":
                        Console.Write("Índice de la tarea a marcar como completada: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceCompletar) && indiceCompletar >= 0 && indiceCompletar < tareas.Count)
                        {
                            tareas[indiceCompletar].Completada = true;
                        }
                        else
                        {
                            Console.WriteLine("Índice no válido.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Lista de tareas:");
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i}. [{(tareas[i].Completada ? "X" : " ")}] {tareas[i].Descripcion}");
                        }
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
