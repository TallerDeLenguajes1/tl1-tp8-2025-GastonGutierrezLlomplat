namespace espacioTarea;

public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }
    public int Duracion { get; set; }

    // Constructor, tiene el mismo nombre que la clase, público.
    public Tarea(int tareaID, string descripcion, int duracion)
    {
        TareaID = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public override string ToString() // Muestra los datos correctamente.
    {
        return $"ID: {TareaID}, Descripción: {Descripcion}, Duración: {Duracion}";
    }
}

