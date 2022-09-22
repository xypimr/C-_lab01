namespace task03;

using NUnit.Framework;

public class Tests
{
    [Test]
    public void LengthSideTest()
    {
        Point one = new(10, 10);
        Point two = new(10, 15);
        Point three = new(0, 0);
        Figure test = new(new Point[]{one, two, three});
        Assert.AreEqual(5, test.LengthSide(one, two));
    }

    [Test]
    public void PerimeterCalculatorTest()
    {
        Point one = new(0, 0);
        Point two = new(0, 4);
        Point three = new(3, 0);
        Figure test = new(new Point[] {one, two, three });
        Assert.AreEqual(12, test.PerimeterCalculator());
    }
}