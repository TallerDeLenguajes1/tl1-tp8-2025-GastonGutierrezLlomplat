using espacioTarea;
using espacioToDoManager;


var manager = new ToDoManager();
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== GESTIÓN DE TAREAS ===");
    Console.WriteLine("1. Agregar tarea");
    Console.WriteLine("2. Marcar tarea como realizada");
    Console.WriteLine("3. Buscar tarea por descripción");
    Console.WriteLine("4. Mostrar todas las tareas");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese la descripción de la tarea: ");
            string desc = Console.ReadLine();
            Console.Write("Ingrese la duración (entre 10 y 100): ");
            if (int.TryParse(Console.ReadLine(), out int duracion) && duracion >= 10 && duracion <= 100)
            {
                manager.AgregarTarea(desc, duracion);
            }
            else
            {
                Console.WriteLine("Duración inválida.");
            }
            break;
        case "2":
            Console.Write("Ingrese el ID de la tarea a marcar como realizada: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                manager.MarcarComoRealizada(id);
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            break;
        case "3":
            Console.Write("Ingrese el texto a buscar en las descripciones: ");
            string texto = Console.ReadLine();
            manager.BuscarPorDescripcion(texto);
            break;
        case "4":
            manager.MostrarTodasLasTareas();
            break;
        case "5":
            salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
}







