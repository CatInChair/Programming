using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationalSystem.Model
{
    /// <summary>
    /// Класс, содержащий информацию об авиа-перелетах.
    /// </summary>
    public class AirRoute : IComparable<AirRoute>
    {
        /// <summary>
        /// Точка отправления маршрута.
        /// </summary>
        public string DeparturePoint
        {
            get
            {
                return _departurePoint;
            }
            set
            {
                AssertStringLengthLessOrEqualThan(value, 100, "AirRoute.DeparturePoint");
                AssertStringIsNotEmpty(value, "AirRoute.DeparturePoint");

                _departurePoint = value;
            }
        }
        private string _departurePoint;
        /// <summary>
        /// Точка назначения маршрута.
        /// </summary>
        public string ArrivalPoint
        {
            get
            {
                return _arrivalPoint;
            }
            set
            {
                AssertStringLengthLessOrEqualThan(value, 100, "AirRoute.ArrivalPoint");
                AssertStringIsNotEmpty(value, "AirRoute.ArrivalPoint");

                _arrivalPoint = value;
            }
        }
        private string _arrivalPoint;
        /// <summary>
        /// Время отправления.
        /// </summary>
        public DateTime DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                AssertDateTimeAffectFuture(value, "AirRoute.DepartureTime");

                _departureTime = value;
            }
        }
        private DateTime _departureTime;
        /// <summary>
        /// Длительность перелета в минутах.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                AssertValueInRange(value, 0, 1000, "AirRoute.Duration");

                _duration = value;
            }
        }
        private int _duration;
        /// <summary>
        /// Тип перелета. 0 - Международный, 1 - Внутренний.
        /// </summary>
        public int Type 
        {
            get
            {
                return _type;
            }
            set
            {
                AssertValueInRange(value, -1, 1, "AirRoute.Type");

                _type = value;
            }
        }
        private int _type;
        /// <summary>
        /// Уникальный идентификатор экземпляра.
        /// </summary>
        public int Id { get; }

        private static int _instanceCounter = 0;

        /// <summary>
        /// Проверяет, превышает ли длина переданной строки заданный порог.
        /// </summary>
        /// <param name="value">Строка, требующая проверки.</param>
        /// <param name="length">Максимальная длина строки.</param>
        /// <param name="property">Параметр, проверка которого производится.</param>
        /// <returns>Возвращает <see cref="true">, если длина строки не превышает заданного порога, иначе генерируется <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        private bool AssertStringLengthLessOrEqualThan(string value, int length, string property)
        {
            if (value.Length > length)
            {
                throw new ArgumentException($"{property} length must be less or equal than {length}.");
            }

            return true;
        }

        /// <summary>
        /// Проверяет, является ли строка пустой.
        /// </summary>
        /// <param name="value">Строка, требующая проверки.</param>
        /// <param name="property">Параметр, проверка которого производится.</param>
        /// <returns>Возвращает <see cref="true">, если строка не является пустой, иначе генерируется <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        private bool AssertStringIsNotEmpty(string value, string property)
        {
            if (value.Length == 0)
            {
                throw new ArgumentException($"{property} musn't be empty.");
            }

            return true;
        }

        /// <summary>
        /// Проверяет дату на то, находится ли она в будущем.
        /// </summary>
        /// <param name="value">Дата, требующая проверки.</param>
        /// <param name="property">Параметр, проверка которого производится.</param>
        /// <returns>Возвращает <see cref="true">, если дата находится в будущем, иначе генерируется <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        private bool AssertDateTimeAffectFuture(DateTime value, string property)
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException($"{property} does affect the future time.");
            }

            return true;
        }

        /// <summary>
        /// Проверяет, относится ли число к заданному пределу.
        /// </summary>
        /// <param name="value">Число, требующее проверки.</param>
        /// <param name="minValue">Нижная граница промежутка.</param>
        /// <param name="maxValue">Верхняя граница промежутка.</param>
        /// <param name="property">Параметр, проверка которого производится.</param>
        /// <returns>Возвращает <see cref="true">, если число принадлежит указанному промежутку, иначе генерируется <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        private bool AssertValueInRange(int value, int minValue, int maxValue, string property)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"{property} must be less or equal than {maxValue} and more or equal than {minValue}.");
            }

            return true;
        }

        /// <summary>
        /// Получает значение счетчика экземпляров класса <see cref="AirRoute"/>.
        /// </summary>
        /// <returns>Возвращает значение счетчика.</returns>
        private static int GetInstanceCounter()
        {
            return _instanceCounter;
        }

        public override string ToString()
        {
            if (DeparturePoint == null || ArrivalPoint == null || DepartureTime == null)
            {
                return "Empty Route";
            }

            return $"{DepartureTime.ToString()}: {DeparturePoint} - {ArrivalPoint}";
        }

        public int CompareTo(AirRoute b)
        {
            if (DepartureTime.Date < b.DepartureTime.Date) 
            { 
                return 1; 
            }
            else if (DepartureTime.Date > b.DepartureTime.Date)
            {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Конструктор класса <see cref="AirRoute"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт отправки.</param>
        /// <param name="arrivalPoint">Пункт назначения.</param>
        /// <param name="departureTime">Дата отправки.</param>
        /// <param name="duration">Длительность.</param>
        /// <param name="type">Тип перелета.</param>
        public AirRoute(string departurePoint, string arrivalPoint, DateTime departureTime, int duration, int type)
        {
            DeparturePoint = departurePoint;
            ArrivalPoint = arrivalPoint;
            DepartureTime = departureTime;
            Duration = duration;
            Type = type;
            Id = GetInstanceCounter();

            _instanceCounter++;
        }

        /// <summary>
        /// Конструктор пустого экземпляра класса <see cref="AirRoute"/>
        /// </summary>
        public AirRoute() 
        {
            DepartureTime = DateTime.Now;
            Id = GetInstanceCounter();
            Type = -1;

            _instanceCounter++;
        }
    }
}
