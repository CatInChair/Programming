namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий собой информацию о фильме.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        public string Name;
        /// <summary>
        /// Длительность фильма в секундах.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Film.Duration");

                _duration = value;
            }
        }
        private int _duration;
        /// <summary>
        /// Год выпуска фильма в прокат. Принадлежит промежутку [1990; 2025].
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1990, 2025, "Film.ReleaseYear");

                _releaseYear = value;
            }
        }
        private int _releaseYear;
        /// <summary>
        /// Жанр фильма.
        /// </summary>
        public string Genre;
        /// <summary>
        /// Рейтинг фильма в прокате. Принадлежит промежутку [0.0; 10.0].
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0.0, 10.0, "Film.Rating");

                _rating = value;
            }
        }
        private double _rating;

        /// <summary>
        /// Конструктор класса <see cref="Film"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Длительность фильма.</param>
        /// <param name="releaseYear">Год выхода фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Film(string name, int duration, int releaseYear, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Film"/>.
        /// </summary>
        public Film() { }
    }
}
