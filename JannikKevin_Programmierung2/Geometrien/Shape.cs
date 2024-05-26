namespace Geometrien;

public interface IShape
{
    public double CalculateArea();
}
public class Circle : IShape
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * (Radius * Radius);
    }
}
public class Rectangel : IShape
{
    private double A { get; set; }
    private double B { get; set; }

    public Rectangel(double a, double b)
    {
        A = a;
        B = b;
    }

    public double CalculateArea()
    {
        return A * B;
    }
}

public class Square : IShape
{
        private double A { get; set; }

        public Square(double a)
        {
            A = a;
        }

        public double CalculateArea()
        {
            return (A * A);
        }
}