namespace Programming.Model
{
    /// <summary>
    /// Класс, содержащий информацию о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Название трека.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Исполнитель.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Длительность песни.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Model.Validator.AssertOnPositiveValue(value, "Song.Duration");

                _duration = value;
            }
        }
        private int _duration;

        /// <summary>
        /// Конструктор класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название трека.</param>
        /// <param name="author">Исполнитель.</param>
        /// <param name="duration">Длительность трека.</param>
        public Song(string name, string author, int duration)
        {
            Name = name;
            Name = author;
            Duration = duration;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Song"/>.
        /// </summary>
        public Song() { }
    } 
}
