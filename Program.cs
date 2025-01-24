using System;

class ProgramaDeConversion
{
    const double PulgadasACentimetros = 2.54;
    const double LibrasAKilogramos = 0.453592;
    const double KilogramosALibras = 2.20462;
    const double FahrenheitACelsiusFactor = 5.0 / 9.0;
    const double CelsiusAFahrenheitFactor = 9.0 / 5.0;

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione el tipo de conversión:");
            Console.WriteLine("1. Longitud");
            Console.WriteLine("2. Peso");
            Console.WriteLine("3. Temperatura");
            int tipoConversion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor a convertir:");
            double valor = double.Parse(Console.ReadLine());
            double resultado = 0;

            switch (tipoConversion)
            {
                case 1: // Longitud
                    Console.WriteLine("Seleccione la conversión específica:");
                    Console.WriteLine("1. Pulgadas a Centímetros");
                    Console.WriteLine("2. Centímetros a Pulgadas");
                    int conversionLongitud = int.Parse(Console.ReadLine());

                    if (conversionLongitud == 1)
                        resultado = valor * PulgadasACentimetros;
                    else if (conversionLongitud == 2)
                        resultado = valor / PulgadasACentimetros;

                    break;

                case 2: // Peso
                    Console.WriteLine("Seleccione la conversión específica:");
                    Console.WriteLine("1. Kilogramos a Libras");
                    Console.WriteLine("2. Libras a Kilogramos");
                    int conversionPeso = int.Parse(Console.ReadLine());

                    if (conversionPeso == 1)
                        resultado = valor * KilogramosALibras;
                    else if (conversionPeso == 2)
                        resultado = valor * LibrasAKilogramos;

                    break;

                case 3: // Temperatura
                    Console.WriteLine("Seleccione la conversión específica:");
                    Console.WriteLine("1. Celsius a Fahrenheit");
                    Console.WriteLine("2. Fahrenheit a Celsius");
                    int conversionTemperatura = int.Parse(Console.ReadLine());

                    if (conversionTemperatura == 1)
                        resultado = (valor * CelsiusAFahrenheitFactor) + 32;
                    else if (conversionTemperatura == 2)
                        resultado = (valor - 32) * FahrenheitACelsiusFactor;

                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine("¿Desea realizar otra conversión? (s/n):");
            string respuesta = Console.ReadLine();
            continuar = (respuesta.ToLower() == "s");
        }
    }
}
