namespace Norbit.Crm.Idiyatullin.StringLibrary
{
    public class StringHelper
    {
        /// <summary>
        /// Конвертация из строки в целое число.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int GetInput(string input)
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