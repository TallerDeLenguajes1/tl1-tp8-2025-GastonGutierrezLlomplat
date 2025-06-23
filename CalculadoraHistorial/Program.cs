class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        bool seguir = true;

        while (seguir)
        {
            Console.WriteLine("\nCalculadora:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Limpiar historial");
            Console.WriteLine("6. Ver historial");
            Console.WriteLine("7. Salir");

            Console.Write("Seleccione una opción: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int opcion) || opcion < 1 || opcion > 7)
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            if (opcion == 7)
            {
                seguir = false;
                continue;
            }

            if (opcion == 6)
            {
                calc.MostrarHistorial();
                continue;
            }

            if (opcion == 5)
            {
                calc.Limpiar();
                Console.WriteLine("Calculadora reiniciada.");
                continue;
            }

            Console.Write($"Valor actual: {calc.Resultado} - Ingrese un número: ");
            if (!double.TryParse(Console.ReadLine(), out double numero))
            {
                Console.WriteLine("Número inválido.");
                continue;
            }

            switch (opcion)
            {
                case 1: calc.Sumar(numero); break;
                case 2: calc.Restar(numero); break;
                case 3: calc.Multiplicar(numero); break;
                case 4: calc.Dividir(numero); break;
            }

            Console.WriteLine($"Resultado actual: {calc.Resultado}");
        }
    }
}
