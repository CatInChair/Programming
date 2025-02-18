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
        public int Duration;
        /// <summary>
        /// Год выпуска фильма в прокат. Принадлежит промежутку [1990; 2025].
        /// </summary>
        public int ReleaseYear;
        /// <summary>
        /// Жанр фильма.
        /// </summary>
        public string Genre;
        /// <summary>
        /// Рейтинг фильма в прокате. Принадлежит промежутку [0.0; 10.0].
        /// </summary>
        public double Rating;

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
