namespace Programming.Model
{
    /// <summary>
    /// Класс, представляющий собой запись в зачетной книжке.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Название дисциплины.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Оценка за дисциплину. Значение в промежутке [1; 5].
        /// </summary>
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                Model.Validator.AssertValueInRange(value, 1, 5, "Discipline.Grade");

                _grade = value;
            }
        }
        private int _grade;
        /// <summary>
        /// ФИО преподавателя.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="grade">Оценка за дисциплину.</param>
        /// <param name="teacher">ФИО преподавателя.</param>
        public Discipline(string name, int grade, string teacher)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline() { }
    }
}
