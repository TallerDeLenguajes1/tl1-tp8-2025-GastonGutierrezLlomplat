using EspacioCalculadora;

Calculadora calc = new Calculadora();

bool opcion = true;

do
{
    Console.WriteLine("¿Que calculo desea realizar?");
    Console.WriteLine("1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir, 5. Limpiar: ");

    if (!int.TryParse(Console.ReadLine(), out int calculo) || (calculo < 1 || calculo > 5))
    {
        Console.WriteLine("Opcion incorrecta.");
        continue;
    }

    double numero = 0;

    if (calculo == 5)
    {
        calc.Limpiar();
        Console.WriteLine("Resultado reiniciado.");
    }
    else
    {
        Console.WriteLine($"Valor actual {calc.Resultado}");
        Console.Write("Ingrese un numero: ");
        if (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Numero invalido.");
            continue;
        }
        switch (calculo)
        {
            case 1:
                calc.Sumar(numero);
                break;
            case 2:
                calc.Restar(numero);
                break;
            case 3:
                calc.Multiplicar(numero);
                break;
            case 4:
                calc.Dividir(numero);
                break;
            default:
                Console.WriteLine("Opcion incorrecta.");
                continue;
        }

        Console.WriteLine($"El resultado es {calc.Resultado}");

        Console.WriteLine("¿Desea realizar otro calculo? (s/n)");
        string entrada = Console.ReadLine();
        if (entrada.ToLower() == "s")
        {
            opcion = true;
        }
        else
        {
            opcion = false;
        }
    }

} while (opcion == true);