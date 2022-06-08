using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(68);
                Console.WriteLine($"It is {celcius} degrees in celcius!");

            var fahrenheit = TempConverter.CelciusToFahrenheit(20);
            Console.WriteLine($"It is {fahrenheit} degrees in fahrenhiet!");

        }
    }
}
