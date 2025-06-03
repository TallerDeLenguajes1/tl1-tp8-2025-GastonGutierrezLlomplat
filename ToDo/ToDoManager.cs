namespace espacioToDoManager;

using espacioTarea;


public class ToDoManager
{
    private List<Tarea> tareasPendientes = new List<Tarea>();
    private List<Tarea> tareasRealizadas = new List<Tarea>();
    int contadorID = 1;

    public void AgregarTarea(string descripcion, int duracion)
    {
        var nuevaTarea = new Tarea(contadorID++, descripcion, duracion);
        tareasPendientes.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada correctamente.");
    }

    public void MarcarComoRealizada(int id)
    {
        var tarea = tareasPendientes.FirstOrDefault(t => t.TareaID == id);

        if (tarea != null)
        {
            tareasPendientes.Remove(tarea);
            tareasRealizadas.Add(tarea);
            Console.WriteLine($"Tarea ID {id} marcada como realizada.");
        }
        else
        {
            Console.WriteLine("No se encontró una tarea con ese ID.");
        }
    }
    public void BuscarPorDescripcion(string texto)
    {
        var resultadosPendientes = tareasPendientes.Where(t => t.Descripcion.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();
        var resultadosRealizadas = tareasRealizadas.Where(t => t.Descripcion.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"\nResultados en tareas pendientes ({resultadosPendientes.Count}):");

        foreach (var t in resultadosPendientes)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine($"\nResultados en tareas realizadas ({resultadosRealizadas.Count}):");
        foreach (var t in resultadosRealizadas)
        {
            Console.WriteLine(t);
        }
    }
    public void MostrarTodasLasTareas()
    {
        Console.WriteLine("\nTAREAS PENDIENTES:");
        foreach (var tareaPendiente in tareasPendientes)
        {
            Console.WriteLine(tareaPendiente);
        }
        Console.WriteLine("\nTAREAS REALIZADAS:");
        foreach (var tareaRealizada in tareasRealizadas)
        {
            Console.WriteLine(tareaRealizada);
        }
    }
}





