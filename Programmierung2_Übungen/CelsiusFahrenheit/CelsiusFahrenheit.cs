namespace CelsiusFahrenheit;

public class CelsiusFahrenheit
{
    public double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = celsius * 1.8 + 32;
        return fahrenheit;
    }
    public double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit-32) * 5/9;
        return celsius;
    }
}