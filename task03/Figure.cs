using System.Security.Authentication.ExtendedProtection;

namespace task03;

public class Figure
{
    public string? Name { get; set; }
    private Point[] points;
    
    public Figure(Point[] args)
    {
        points = (Point[])args.Clone();
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
    }

    public double PerimeterCalculator()
    {
        double sum = 0;
        for (int i = 1; i <= points.Length; i++)
        {
            sum += LengthSide(points[i%points.Length], points[(i+1)%points.Length]);
        }

        return sum;
    }
}