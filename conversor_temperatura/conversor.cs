/// <summary>
/// A ideia desse programa eh realizar a conversao de temperatura para Fahrenheit, Celsius, e Kelvim  
/// </sumary>

using System;

    // Funcao para converter as temperaturas 
class ConversorTemperatura
{
    // Converter de Celsius para Fahrenheit
    static double CelsiusFahrenheit(double valorTemperatura)
    {
        double valorConvertido = (valorTemperatura * 9 / 5) + 32;
        return valorConvertido;  
    }

    // Converter de Celsius para Kelvin
    static double CelsiusKelvin(double valorTemperatura) 
    {
        double valorConvertido = valorTemperatura + 273;
        return valorConvertido;
    }
    
    // Converter de  Fahrenheit para Celsius 
    static double FahrenheitCelsius(double valorTemperatura)
    {
        double valorConvertido = (valorTemperatura - 32) * 5 / 9;
        return valorConvertido;
    }

    // Converter de Fahrenheit para Kelvin
    static double FahrenheitKelvin(double valorTemperatura)
    {
        double valorConvertido = (valorTemperatura + 459.67) * 5 / 9;
        return valorConvertido;
    }

    // Converter de Kelvin para Celsius
    static double KelvinCelsius(double valorTemperatura)
    {
        double valorConvertido = valorTemperatura - 273;
        return valorConvertido;
    }

    // Converter de Kelvin para Fahrenheit
    static double KelvinFahrenheit(double valorTemperatura)
    {
        double valorConvertido = (valorTemperatura * 9 / 5) - 459.67;
        return valorConvertido;
    }

// Funcao Conversor
    static void Conversor()
    {
        // texto de apresentacao 
        Console.WriteLine("********************");
        Console.WriteLine("Bem Vindo ao conversor de Temperatura!");
        Console.WriteLine("Programado por: Talita Ventura <3");
        Console.WriteLine("********************");

        // Informa as conversoes disponiveis 
        Console.WriteLine("Escola a Escala de temperatura que deseja converter:");
        Console.WriteLine("1 - Fahrenheit");
        Console.WriteLine("2 - Celsius");
        Console.WriteLine("3 - Kelvin");
    

    // Para obter as temperaturas 
    int escalaOriginal = Convert.ToInt32(Console.ReadLine());

    double temperatura;

    // Para que o usuario informe a escala para conversao desejada 
        Console.WriteLine("Por favor, informe para qual escala que deseja converter:");
        Console.WriteLine("1 - Fahrenheit");
        Console.WriteLine("2 - Celsius");
        Console.WriteLine("3 - Kelvin");

    int escalaConversao = Convert.ToInt32(Console.ReadLine());

    // Para que o usuario informe a temperatura desejada
        Console.WriteLine("Por favor, informe a temperatura:");
        temperatura = Convert.ToInt32(Console.ReadLine()); 
        double resultado = 0;

        if (escalaOriginal == 1)
        {
            // Fahrenheit e a outra escala escolhida
            if (escalaConversao == 2)
            resultado = FahrenheitCelsius(temperatura);
            else if (escalaConversao == 3)
            resultado = FahrenheitKelvin(temperatura);
            else
            resultado = resultado; // caso o usuario deseje escolher a mesma escala da temperatura 
        }
        else if (escalaOriginal == 2)
        {
            if (escalaConversao == 1)
            resultado = CelsiusFahrenheit(temperatura);
            else if (escalaConversao == 3)
            resultado = CelsiusKelvin(temperatura);
            resultado = resultado; // caso o usuario deseje escolher a mesma escala da temperatura 
        }
        else if (escalaConversao == 3)
        {
            if (escalaConversao == 1)
            resultado = KelvinFahrenheit(temperatura);
            else if (escalaConversao == 2)
            resultado = KelvinCelsius(temperatura);
            else
            resultado = resultado; // caso o usuario deseje escolher a mesma escala da temperatura  
        }

        // Exibe a conversao 
        Console.WriteLine($"A temperatura convertida é: {resultado}");
    }
    static void Main()
    {
        Conversor();
    }

}