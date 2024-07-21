namespace Norbit.Crm.Idiyatullin.StringLibrary
{
    public class StringHelper
    {
        /// <summary>
        /// Преобразует строку в целое число.
        /// </summary>
        /// <param name="input">Строка для преобразования.</param>
        /// <returns>Целое число, полученное из строки.</returns>
        /// <exception cref="ArgumentException">Если строка не представляет собой корректное целое число или если число отрицательное.</exception>
        public static int CheckAndConvertToInt32(string input)
        {
            var isParsed = Int32.TryParse(input, out int inputValue);

            if (inputValue < 0 || !isParsed)
            {
                throw new ArgumentException("Введен неверный параметр.", nameof(input));
            }

            return inputValue;
        }
    }
}