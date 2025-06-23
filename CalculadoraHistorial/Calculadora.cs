public class Calculadora
{
    private double dato = 0;
    private List<Operacion> historial = new List<Operacion>();

    public double Resultado => dato;

    public void Sumar(double termino)
    {
        historial.Add(new Operacion(dato, termino, TipoOperacion.Suma));
        dato += termino;
    }

    public void Restar(double termino)
    {
        historial.Add(new Operacion(dato, termino, TipoOperacion.Resta));
        dato -= termino;
    }

    public void Multiplicar(double termino)
    {
        historial.Add(new Operacion(dato, termino, TipoOperacion.Multiplicacion));
        dato *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Division));
            dato /= termino;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No se puede dividir por cero.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public void Limpiar()
    {
        historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
        dato = 0;
    }

    public void MostrarHistorial()
    {
        if (historial.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Historial vacío.");
            Console.ForegroundColor = ConsoleColor.Gray;
            return;
        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Historial de operaciones:");
        Console.ForegroundColor = ConsoleColor.Gray;

        int i = 1;
        foreach (var op in historial)
        {
            Console.WriteLine($"{i}. {op}");
            i++;
        }
    }
}
