using System;

namespace Programming.Model
{
    /// <summary>
    /// Статичный класс, предоставляющий методы для валидации чисел.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет данное целое число на то, является ли оно положительным.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="property">Свойство, над которым производится валидация.</param>
        /// <returns>Возвращает true, если переданное число больше нуля, иначе метод генерирует <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(int value, string property)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{property} value must be positive integer.");
            }

            return true;
        }

        /// <summary>
        /// Проверяет данное вещественное число на то, является ли оно положительным.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="property">Свойство, над которым производится валидация.</param>
        /// <returns>Возвращает true, если переданное число больше нуля, иначе метод генерирует <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(double value, string property)
        {
            if (value < 0.0)
            {
                throw new ArgumentException($"{property} value must be positive integer.");
            }

            return true;
        }

        /// <summary>
        /// Проверяет данное целое число на то, принадлежит ли оно заданному промежутку.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Нижний порог промежутка.</param>
        /// <param name="max">Верхний порог промежутка.</param>
        /// <param name="property">Свойство, над которым производится валидация.</param>
        /// <returns>Возвращает true, если переданное число принадлежит заданному промежутку, иначе метод генерирует <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(int value, int min, int max, string property) 
        {
            if ( value < min ||  value > max)
            {
                throw new ArgumentException($"{property} value must be more than or equal than {min} and less or equal than {max}.");
            }

            return true;
        }

        /// <summary>
        /// Проверяет данное вещественное число на то, принадлежит ли оно заданному промежутку.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Нижний порог промежутка.</param>
        /// <param name="max">Верхний порог промежутка.</param>
        /// <param name="property">Свойство, над которым производится валидация.</param>
        /// <returns>Возвращает true, если переданное число принадлежит заданному промежутку, иначе метод генерирует <see cref="ArgumentException"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(double value, double min, double max, string property)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{property} value must be more than or equal than {min} and less or equal than {max}.");
            }

            return true;
        }
    }
}
