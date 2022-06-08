using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double CelciusToFahrenheit(double celcius)
        {
            var result = (celcius * 9) / 5 + 32;
            return result;

        }



        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;
            return result;

        }





    }
    



}
