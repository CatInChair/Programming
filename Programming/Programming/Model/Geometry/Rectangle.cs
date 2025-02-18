namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий собой прямоугольник в пространстве.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Положительное не-нулевое число, представляющее высоту данного прямоугольника.
        /// </summary>
        public double Height { 
            get
            {
                return Height;
            }
            set
            {
                Model.Validator.AssertOnPositiveValue(value, "Rectangle.Length");

                Height = value;
            }
        }
        /// <summary>
        /// Положительное не-нулевое число, представляющее ширину данного прямоугольника.
        /// </summary>
        public double Width 
        {
            get
            {
                return Width;
            }
            set
            {
                Model.Validator.AssertOnPositiveValue(value, "Rectangle.Length");

                Width = value;
            }
        }
        /// <summary>
        /// Цвет данного прямоугольника.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Экземпляр <see cref="Point2D"/>, представляющий собой центр данного прямоугольника.
        /// </summary>
        public Point2D Center;
        /// <summary>
        /// Уникальный идентификатор данного экземпляра.
        /// </summary>
        public int Id { get; }  
        /// <summary>
        /// Счетчик уникальных экземпляров класса Rectangle.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Статический метод, позволяющий получить число-количество уникальных экземпляров класса Rectangle.
        /// </summary>
        /// <returns>Возвращает счетчик экземпляров класса Rectangle.</returns>
        private static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }

        /// <summary>
        /// Конструктор класса <see cref="Rectangle"\>.
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Центр прямоугольника, представленный экземпляром <see cref="Point2D"/></param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Height = length;
            Width = width;
            Color = color;
            Center = center;
            Id = AllRectanglesCount();

            _allRectanglesCount++;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Rectangle"\>.
        /// </summary>
        public Rectangle() 
        {
            _allRectanglesCount++;
        }
    }
}
