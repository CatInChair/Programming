using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс с методами для валидации значений
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        /// Проверяет, превышает ли строка заданную длину
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Максимальная длина строки</param>
        /// <param name="propertyName">Имя поля</param>
        /// <exception cref="ArgumentException">Возвращает исключение при превышении строкой определенной длины</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} length must be less or equal than {maxLength}");
            }

            return;
        }

        /// <summary>
        /// Проверяет, находится ли данное число в заданном промежутке
        /// </summary>
        /// <param name="value">Проверяемое целочисленное значение</param>
        /// <param name="maxValue">Верхняя граница</param>
        /// <param name="minValue">Нижняя граница</param>
        /// <param name="propertyName">Имя поля</param>
        /// <exception cref="ArgumentException">Возвращает исключение, если число не лежит на указанном промежутке</exception>
        public static void AssertValueOnRange(int value, int maxValue, int minValue, string propertyName)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"{propertyName} must be more or equal than {minValue} and less or equal than {maxValue}");
            }

            return;
        }

        /// <summary>
        /// Проверяет, находится ли данное число в заданном промежутке
        /// </summary>
        /// <param name="value">Проверяемое число с плавающей точкой</param>
        /// <param name="maxValue">Верхняя граница</param>
        /// <param name="minValue">Нижняя граница</param>
        /// <param name="propertyName">Имя поля</param>
        /// <exception cref="ArgumentException">Возвращает исключение, если число не лежит на указанном промежутке</exception>
        public static void AssertValueOnRange(double value, double maxValue, double minValue, string propertyName)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"{propertyName} must be more or equal than {minValue} and less or equal than {maxValue}");
            }

            return;
        }
    }
}
