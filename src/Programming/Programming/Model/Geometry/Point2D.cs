namespace Programming.Model
{
    /// <summary>
    /// Данный класс представляет собой точку в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// X - координата точки на пространстве.
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Y - координата точки на пространстве.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Конструктор класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
