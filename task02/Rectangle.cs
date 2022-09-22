namespace task02;

public class Rectangle
{
    private double side1, side2;
    
    public Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }

    double AreaCalculator()
    {
        return side1 * side2;
    }

    double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get
        {
            return AreaCalculator();
        }
    }
    public double Perimeter
    {
        get
        {
            return PerimeterCalculator();
        }
    }

}