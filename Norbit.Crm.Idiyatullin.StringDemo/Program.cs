using Norbit.Crm.Idiyatullin.StringSolution;

namespace Norbit.Crm.Idiyatullin.StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Выберите необходимую задачу:");
            Console.WriteLine("1. Формирование и возвращение строки с N значением");
            Console.WriteLine("2. Вывод звездочек со стороной N");
            Console.WriteLine("0. Выход");

            switch (Console.ReadLine())
            {
                case "1":

                    GetAndPrintSequence();

                    break;

                case "2":

                    GetAndPrintStars();

                    break;

                case "0":

                    return;

                default:

                    throw new InvalidOperationException("Указан неверный параметр при выборе в меню.");
            }
        }

        public static void GetAndPrintSequence()
        {
            Console.WriteLine("Введите число для генерации последовательности:");

            var input = Console.ReadLine();

            var count = StringHelper.GetInput(input!);

            string result = StringCreator.CreateString(count);

            Console.WriteLine($"Последовательность до числа {count}: {result}");
        }

        public static void GetAndPrintStars()
        {
            Console.WriteLine("Введите нечетное число для генерации звездочек:");

            var input = Console.ReadLine();

            var count = StringHelper.GetInput(input!);

            var result = StringCreator.CreateStar(count);

            Console.WriteLine($"Результат:\n{result}");
        }
    }
}