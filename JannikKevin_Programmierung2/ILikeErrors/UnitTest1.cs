using Geometrien;

namespace ILikeErrors;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Circle c1 = new(1);
        Rectangel r1 = new(2, 3);
        Square s1 = new(2);
        Assert.IsTrue(c1.CalculateArea() == Math.PI);
        Assert.AreEqual(6, r1.CalculateArea());
        Assert.IsTrue(s1.CalculateArea() == 4);


    }
}