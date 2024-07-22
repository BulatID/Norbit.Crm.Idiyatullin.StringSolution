using Norbit.Crm.Idiyatullin.StringLibrary;
using System.Text;

namespace Norbit.Crm.Idiyatullin.StringSolution
{
    public class StringCreator
    {
        /// <summary>
        /// Создает строку с последовательностью чисел от 1 до <paramref name="size"/>.
        /// </summary>
        /// <param name="size">Размер последовательности.</param>
        /// <returns>Строка с последовательностью чисел.</returns>
        /// <exception cref="ArgumentException">Число <paramref name="size"/> меньше или равна 0.</exception>
        public static string CreateStringSequence(int size)
        {
            StringHelper.CheckIsPositive(size);

            var sequence = new StringBuilder();

            for (var i = 1; i <= size; i++)
            {
                sequence.Append(i);

                sequence.Append(
                    i != size 
                        ? ", " 
                        : string.Empty);
            }

            sequence.Append(".");

            return sequence.ToString();
        }

        /// <summary>
        /// Строка, представляющую квадрат со стороной <paramref name="size"/>, заполненный звездочками.
        /// </summary>
        /// <param name="size">Размер.</param>
        /// <returns>Строка, представляющая квадрат со звездочками.</returns>
        /// <exception cref="ArgumentException">Число <paramref name="size"/> меньше или равна 0, либо четное.</exception>
        public static string CreateSquareStar(int size)
        {
            StringHelper.CheckIsPositive(size);

            StringHelper.CheckIsOdd(size);

            var square = new StringBuilder();

            var center = size / 2;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    square.Append(
                        i == center && j == center 
                            ? " " 
                            : "*");
                }

                square.Append("\n");
            }

            return square.ToString();
        }
    }
}
