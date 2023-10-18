using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Lib;

public class Calculator
{
    /// <summary>
    /// Функция рассчета Декартового расстояние между двумя точками
    /// </summary>
    /// <param name="A">Точка A</param>
    /// <param name="B">Точка B</param>
    /// <returns></returns>
    public static double ToDecartDistance(Point A, Point B)
    {
        return Math.Sqrt(
                Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2)
            );
    }

    /// <summary>
    /// Функция нахождения катета в прямоугольном треугольнике
    /// </summary>
    /// <param name="h">Гипотенуза</param>
    /// <param name="l">Известый катет</param>
    /// <returns></returns>
    public static double ToLegInRightTriangle(double h, double l)
    {
        return Math.Sqrt(
                 Math.Pow(h, 2) - Math.Pow(l, 2)
            ); ;
    }
}
