namespace task03
{
    public static class Program
    {
        static void Main()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 2);
            Point p3 = new Point(2, 2);
            Point p4 = new Point(4, 0);
            Figure fig = new Figure(new Point[] {p1, p2, p3, p4});
            fig.Name = "Nice";
            Console.WriteLine($"Периметр фигуры: {fig.PerimeterCalculator()}");
        }
    }
}