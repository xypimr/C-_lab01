namespace task03;

public class Point
{
    private int coordX, coordY;

    public Point(int x, int y)
    {
        coordX = x;
        coordY = y;
    }
    
    public int X
    {
        get
        {
            return coordX;
        }
    }
    public int Y
    {
        get
        {
            return coordY;
        }
    }
}