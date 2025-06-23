public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;
    public double NuevoValor => nuevoValor;
    public double Resultado
    {
        get
        {
            switch (operacion)
            {
                case TipoOperacion.Suma:
                    return resultadoAnterior + nuevoValor;
                case TipoOperacion.Resta:
                    return resultadoAnterior - nuevoValor;
                case TipoOperacion.Multiplicacion:
                    return resultadoAnterior * nuevoValor;
                case TipoOperacion.Division:
                    if (nuevoValor == 0)
                        return double.NaN;
                    return resultadoAnterior / nuevoValor;
                case TipoOperacion.Limpiar:
                    return 0;
                default:
                    return 0;
            }
        }
    }

    // Constructor
    public Operacion(double anterior, double nuevo, TipoOperacion tipo)
    {
        resultadoAnterior = anterior;
        nuevoValor = nuevo;
        operacion = tipo;
    }

    // ToString para mostrar la operación como texto
    public override string ToString()
    {
        string simbolo;

        switch (operacion)
        {
            case TipoOperacion.Suma:
                simbolo = "+";
                break;
            case TipoOperacion.Resta:
                simbolo = "-";
                break;
            case TipoOperacion.Multiplicacion:
                simbolo = "*";
                break;
            case TipoOperacion.Division:
                simbolo = "/";
                break;
            case TipoOperacion.Limpiar:
                simbolo = "LIMPIAR";
                break;
            default:
                simbolo = "?";
                break;
        }

        if (operacion == TipoOperacion.Limpiar)
        {
            return $"Operación: {simbolo} → Resultado: 0";
        }

        return $"{resultadoAnterior} {simbolo} {nuevoValor} = {Resultado}";
    }

}

public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}