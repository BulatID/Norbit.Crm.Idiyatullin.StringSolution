using Norbit.Crm.Idiyatullin.StringLibrary;
using Norbit.Crm.Idiyatullin.StringSolution;

namespace Norbit.Crm.Idiyatullin.StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        /// <summary>
        /// Меню для выбора нужной операции.
        /// </summary>
        /// <exception cref="InvalidOperationException">Выбран неверный параметр.</exception>
        public static void Menu()
        {
            Console.WriteLine("Выберите необходимую задачу:");
            Console.WriteLine("1. Формирование и возвращение строки с N значением");
            Console.WriteLine("2. Вывод звездочек со стороной N");
            Console.WriteLine("0. Выход");

            switch (Console.ReadLine())
            {
                case "1":

                    GenerateSequence();

                    break;

                case "2":

                    GenerateStarSquare();

                    break;

                case "0":

                    return;

                default:

                    throw new InvalidOperationException("Указан неверный параметр при выборе в меню.");
            }
        }

        /// <summary>
        /// Генерирует последовательность чисел до этого числа и выводит ее.
        /// </summary>
        public static void GenerateSequence()
        {
            var input = GetIntInput("Введите число для генерации последовательности:");

            var result = StringCreator.CreateString(input);

            Console.WriteLine($"Последовательность до числа {input}: {result}");
        }

        /// <summary>
        /// Генерирует квадрат со звездочками и выводит его.
        /// </summary>
        public static void GenerateStarSquare()
        {
            var input = GetIntInput("Введите нечетное число для генерации звездочек:");

            var result = StringCreator.CreateStar(input);

            Console.WriteLine($"Результат:\n{result}");
        }

        /// <summary>
        /// Получение целого числа.
        /// </summary>
        /// <param name="text">Подсказка.</param>
        /// <returns>Целое число.</returns>
        public static int GetIntInput(string text)
        {
            Console.WriteLine(text);

            var input = Console.ReadLine();

            return StringHelper.CheckIsInteger(input!);
        }
    }
}