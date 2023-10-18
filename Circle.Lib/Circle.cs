namespace Circle.Lib;

/*
 * d = sqr ((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2))
h = sqr(r * r - (d/2) * (d/2));

x01 = x1 + (x2 - x1)/2 + h * (y2 - y1) / d
y01 = y1 + (y2 - y1)/2 - h * (x2 - x1) / d

x02 = x1 + (x2 - x1)/2 - h * (y2 - y1) / d
y02 = y1 + (y2 - y1)/2 + h * (x2 - x1) / d
 * 
 */
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
    public Point pointO, pointOStreak;

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
        // находим растояние между двух точками через декардовое растояние
        double d = ToDecartDistance();
        // если середина гипотенузы больше радиуса, то окружность через две эти точки провести нельзя
        if(IsHaflHypotenuseLargeToRadius(d)) 
            //TODO: добавить исключение 
            return;
        // находим высоту через середину декардовое растояние и радиус
        double h = ToHeight(d/2);
        // координаты центра окружности
        pointO = ToPointO(d, h);

        // А если высота равна 0????
        // если половина декардового растояние не равна радиуса
        if(!IsHaflHypotenuseEqualToRadius(d)) 
            // то есть второй центр окружности
            pointOStreak = ToPointOStreak(d, h);
      
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

    private double ToDecartDistance() => Calculator.ToDecartDistance(pointP1, pointP2);

    private double ToHeight(double d) => Calculator.ToLegInRightTriangle(this.radius, d);

    private Point ToPointO(double d, double h)
    {
        /*
         * x01 = x1 + (x2 - x1)/2 + h * (y2 - y1) / d
         * y01 = y1 + (y2 - y1)/2 - h * (x2 - x1) / d
         */
        return new Point(
            x: pointP1.x + (pointP2.x - pointP1.x) / 2 + h * (pointP2.y - pointP1.y) / d,
            y: pointP1.y + (pointP2.y - pointP1.y) / 2 - h * (pointP2.x - pointP1.x) / d
        );
    }

    private Point ToPointOStreak(double d, double h)
    {
        /*
         * x02 = x1 + (x2 - x1)/2 - h * (y2 - y1) / d
         * y02 = y1 + (y2 - y1)/2 + h * (x2 - x1) / d
         */
        return new Point(
            x: pointP1.x + (pointP2.x - pointP1.x) / 2 - h * (pointP2.y - pointP1.y) / d,
            y: pointP1.y + (pointP2.y - pointP1.y) / 2 + h * (pointP2.x - pointP1.x) / d
        );
    }
}
