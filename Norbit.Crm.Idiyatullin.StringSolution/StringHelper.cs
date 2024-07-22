using System.Drawing;

namespace Norbit.Crm.Idiyatullin.StringLibrary
{
    public class StringHelper
    {
        /// <summary>
        /// Проверка на целое число.
        /// </summary>
        /// <param name="input">Строка для проверка.</param>
        /// <returns>Целое число.</returns>
        /// <exception cref="ArgumentException">Если строка не является целым числом.</exception>
        public static int CheckIsInteger(string input)
        {
            return Int32.TryParse(input, out var inputValue) 
                ? inputValue 
                : throw new ArgumentException("Введен неверный параметр.", nameof(input));
        }

        /// <summary>
        /// Проверка числа на положительность.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <exception cref="ArgumentException">Не является положительным числом.</exception>
        public static void CheckIsPositive(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.", nameof(number));
            }
        }

        /// <summary>
        /// Проверка числа на нечетность.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <exception cref="ArgumentException">Не является нечетным.</exception>
        public static void CheckIsOdd(int number)
        {
            if (number % 2 == 0)
            {
                throw new ArgumentException("Число должно быть нечетным.", nameof(number));
            }
        }
    }
}