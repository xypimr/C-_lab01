namespace task02;

public class Tests
{
    [Test]
    public void Areatest()
    {
        Rectangle one = new(2, 5);
        Assert.AreEqual(10, one.Area);
    }

    [Test]
    public void Perimetrtest()
    {
        Rectangle one = new(2, 5);
        Assert.AreEqual(14, one.Perimeter);

    }
}