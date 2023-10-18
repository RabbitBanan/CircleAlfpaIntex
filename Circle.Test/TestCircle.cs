using Circle.Lib;

namespace Circle.Test;

[TestClass]
public class TestCirle
{
    [TestMethod]
    public void Create_Circle()
    {
        Lib.Circle circle = new Lib.Circle(
            new Point(1, 1), new Point(3, 5), 3, true, 1);

        Console.WriteLine(circle.pointO);
        Console.WriteLine(circle.pointOStreak);

        Assert.IsNotNull(circle);
    }
}