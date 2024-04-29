
using toTest;

namespace TestProject1;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        CFunction cf = new CFunction();
        Assert.True(2==cf.Sum(1,1));
    }
}