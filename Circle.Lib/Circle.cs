namespace Circle.Lib;

public class Circle
{
    // координаты двух точек
    public Point pointP1, pointP2;
    // радиус
    public double radius;
    // напарвление 
    public bool direction;
    // количество точек на окружностей
    public int countPoint;

    /** координаты центра окружности
      * координаты две, так как радиус из точек P1 и P2 может пересекаться максимум в двух точек
      * если радиус совподает с половиной расстояние от двух точек, то точка одна
      */
    private Point pointMiddleCircle, pointMiddleCircleStreak;

    public Circle(Point pointP1, Point pointP2, double radius, bool direction, int countPoint)
    {
        this.pointP1 = pointP1;
        this.pointP2 = pointP2;
        this.radius = radius;
        this.direction = direction;
        this.countPoint = countPoint;

        StartCalculations();

    }

    private void StartCalculations()
    {
        // находим растояние между двух точками как гипотенузу прямогоугольника
        double d = ToHypotenuse();
        // если середина гипотенузы больше радиуса, то окружность через две эти точки провести нельзя
        if(IsHaflHypotenuseLargeToRadius(d)) 
            return;
        // находим высоту через середины гипотенузы и радиус
        double h = ToHeight();
        // координаты центра окружности
        pointMiddleCircle = ToMiddleCircle(d, h);

        // А если высота равна 0????
        // если середина гипотенузы меньше  то 
        if (IsHaflHypotenuseEqualToRadius(d)) 
            pointMiddleCircleStreak = ToMiddleCircleStreak(d, h);
      
    }

    private bool IsHaflHypotenuseEqualToRadius(double d)
    {
        if(d / 2 == this.radius)
            return true;
        return false;
    }

    private bool IsHaflHypotenuseLargeToRadius(double d)
    {
        if(d / 2 > this.radius)
            return true;
        return false;
    }

    private double ToHypotenuse()
    {
        return 0.0;
    }

    private double ToHeight() {
        return 0.0; 
    }

    private Point ToMiddleCircle(double d, double h)
    {
        return new Point();
    }

    private Point ToMiddleCircleStreak(double d, double h)
    {
        return new Point();
    }
}
