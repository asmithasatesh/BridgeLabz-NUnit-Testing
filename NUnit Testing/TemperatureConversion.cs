using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    class TemperatureConversion
    {
        public static void ReadInput()
        {
            //Read input from user
            Console.WriteLine("Enter degree in Celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());
            CelsiusToFahrenheit(celsius);
            Console.WriteLine("Enter degree in Fahrenheit:");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            FahrenheitToCelsius(fahrenheit);

        }
        private static void CelsiusToFahrenheit(double celsius)
        {
            //Convert from Celsius to Fahrenheit
            double celToFar = (celsius * 9 / 5) + 32;   
            Console.WriteLine("Celusis To Fahrenheit Temperature : " + Math.Round(celToFar));
           
        }

        private static void FahrenheitToCelsius(double fahrenheit)
        {
            //Convert from Fahrenheit to Celsius
            double FarToCel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit To Celusis Temperature : " + Math.Round(FarToCel));
        }

    }
}
