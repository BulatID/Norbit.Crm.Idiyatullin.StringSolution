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
            if (!Int32.TryParse(input, out int inputValue))
            {
                throw new ArgumentException("Введен неверный параметр.", nameof(input));
            }

            return inputValue;
        }
    }
}