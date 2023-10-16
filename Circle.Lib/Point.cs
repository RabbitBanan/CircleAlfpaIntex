namespace Circle.Lib;

/**
 * Стуктура точки с координатами x и y
 */
public struct Point
{
    public double x, y = 0;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}