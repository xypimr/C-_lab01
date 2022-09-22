namespace task02
{
    public static class Program
    {
        static void Main()
        {
            double sideA, sideB;
            Console.WriteLine("Введите первую сторону прямоугольника:");
            sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника:");
            sideB = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(sideA, sideB);
            Console.WriteLine($"Периметр данного прямоугольника: {rect.Perimeter}\n" +
                              $"Площадь данного прямоугольника: {rect.Area}");
            
        }
    }
}
