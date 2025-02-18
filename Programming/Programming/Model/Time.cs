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
                return Hours;
            }
            set
            {
                Model.Validator.AssertValueInRange(value, 0, 24, "Time.Hours");

                Hours = value;
            }
        }
        /// <summary>
        /// Минуты.
        /// </summary>
        public int Minutes
        {
            get
            {
                return Minutes;
            }
            set
            {
                Model.Validator.AssertValueInRange(value, 0, 60, "Time.Minutes");

                Minutes = value;
            }
        }
        /// <summary>
        /// Секунды.
        /// </summary>
        public int Seconds
        { 
            get
            {
                return Seconds;
            } 
            set
            {
                Model.Validator.AssertValueInRange(value, 0, 60, "Time.Seconds");

                Seconds = value;
            }
        }

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
