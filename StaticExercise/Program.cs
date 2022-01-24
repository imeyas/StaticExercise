using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is the temperature in fahrenheit you would like to convert\n");
            var userInput = double.TryParse(Console.ReadLine(), out double result);
            Console.WriteLine($"\nThis converts to {TempConverter.FahrenheitToCelcius(result)} degrees celcius...\n");

            Console.WriteLine($"----------------------------------");

            Console.WriteLine($"\nWhat is the temperature in celcius you would like to convert\n");
            var userInputC = double.TryParse(Console.ReadLine(), out double result2);
            Console.WriteLine($"\nThis converts to {TempConverter.CelciusToFahrenheit(result2)} degrees celcius...\n");

            Console.WriteLine($"----------------------------------");

        }
    }
}
