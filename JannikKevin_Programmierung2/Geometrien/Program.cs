namespace Geometrien;

class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new(2);
        Rectangel r1 = new(2, 3);
        Square s1 = new(2);

        double circle = c1.CalculateArea();
        double rectangle = r1.CalculateArea();
        double square = s1.CalculateArea();
        Console.WriteLine($"Circle: {circle}\nrectangle: {rectangle}\nsquare: {square}");
    }
}