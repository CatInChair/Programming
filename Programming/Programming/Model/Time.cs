namespace Programming.Model
{
    /// <summary>
    /// Класс, содержащий информацию о заданном времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Model.Validator.AssertValueInRange(value, 0, 24, "Time.Hours");

                _hours = value;
            }
        }
        private int _hours;
        /// <summary>
        /// Минуты.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Model.Validator.AssertValueInRange(value, 0, 60, "Time.Minutes");

                _minutes = value;
            }
        }
        private int _minutes;
        /// <summary>
        /// Секунды.
        /// </summary>
        public int Seconds
        { 
            get
            {
                return _seconds;
            } 
            set
            {
                Model.Validator.AssertValueInRange(value, 0, 60, "Time.Seconds");

                _seconds = value;
            }
        }
        private int _seconds;

        /// <summary>
        /// Конструктор класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="Time"/>.
        /// </summary>
        public Time() { }
    }
}
