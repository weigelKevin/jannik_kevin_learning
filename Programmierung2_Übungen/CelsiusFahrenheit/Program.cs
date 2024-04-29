namespace CelsiusFahrenheit;

class Program
{
    static void Main(string[] args)
    {
        CelsiusFahrenheit cf = new CelsiusFahrenheit();

        double celsius = cf.CelsiusToFahrenheit(32);
        double fahrenheit = cf.FahrenheitToCelsius(celsius);
        

        Console.WriteLine($"Celsius: {celsius}  Fahrenheit: {fahrenheit}");

    }
}