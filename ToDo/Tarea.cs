namespace espacioTarea;

public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }
    public int Duracion { get; set; }

    // Constructor, tiene el mismo nombre que la clase, público
    public Tarea(int tareaID, string descripcion, int duracion)
    {
        if (duracion < 10 || duracion > 100)
        {
            throw new ArgumentException("La duración debe estar entre 10 y 100.");
        }

        TareaID = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public override string ToString()
    {
        return $"ID: {TareaID}, Descripción: {Descripcion}, Duración: {Duracion}";
    }
}

