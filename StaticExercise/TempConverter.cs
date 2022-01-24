using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {


        public static double FahrenheitToCelcius (double toCelcius)
        {
            var celcius = (toCelcius - 32) * 5 / 9;
            return celcius;
        }

        public static double CelciusToFahrenheit(double toFahren)
        {
            var fahren = (toFahren * 9) / 5 + 32;
            return fahren;
        }

    }
}
