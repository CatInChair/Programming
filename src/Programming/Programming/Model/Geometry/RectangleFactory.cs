using System;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс, содержащий методы для создания экземпляров класса <see cref="Rectangle"/>.
    /// </summary>
    static public class RectangleFactory
    {
        /// <summary>
        /// Создает экземпляр <see cref="Rectangle"/>, заполненный случайными(почти) данными.
        /// </summary>
        /// <returns>Возвращает новый экземпляр <see cref="Rectangle"/></returns>
        public static Rectangle Randomize()
        {
            Random random = new Random();

            return new Rectangle(random.Next(50, 100), random.Next(50, 100), new string[] { "Red", "Yellow", "Orange", "Blue" }[random.Next(0, 4)], new Model.Point2D(random.Next(0, 200), random.Next(0, 200)));
        }
    }
}
