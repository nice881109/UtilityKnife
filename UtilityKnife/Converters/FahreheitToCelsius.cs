using System.Reflection.Metadata.Ecma335;
using UtlityKnife.Calculator;

namespace UtilityKnife.Converters
{
    public class FahrenheitToCelsius
    {
        public double FahrenheitToCelsiusConverter(double
                                        fahrenheitTemp)
        {
            double _fahreneithTemp = 0.0;
            double _celsius = 0.0;

            var step1 = Calculator.Calculator.Subtract(
                fahrenheitTemp, 32);
            var step2 = Calculator.Calculator.Multiply(
                step1, 5.0);
            _celsius = Calculator.Calculator.Division(step2, 9.0);
            return _celsius;
        }
    }
}