using System;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс, хранящий методы, позволяющие проверить пересечение геометрических фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет на пересечение переданные прямоугольники.
        /// </summary>
        /// <param name="r1">Первый прямоугольник.</param>
        /// <param name="r2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если данные прямоугольники пересекаются, и false, если пересечение отсутствует.</returns>
        static public bool IsCollision(Rectangle r1, Rectangle r2)
        {
            return (Math.Abs(r1.Center.Y - r2.Center.Y) < (r1.Height + r2.Height)/2) && (Math.Abs(r1.Center.X - r2.Center.X) < (r1.Width + r2.Width) / 2);
        }

        /// <summary>
        /// Проверяет на пересечение переданные кольца.
        /// </summary>
        /// <param name="r1">Первое кольцо.</param>
        /// <param name="r2">Второе кольцо.</param>
        /// <returns>Возвращает true, если данные кольца пересекаются, и false, если пересечение отсутствует.</returns>
        static public bool IsCollision(Ring r1, Ring r2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(r1.Center.X - r2.Center.X), 2) + Math.Pow(Math.Abs(r1.Center.Y - r2.Center.Y), 2)) < r1.OuterR + r2.OuterR;
        }
    }
}
