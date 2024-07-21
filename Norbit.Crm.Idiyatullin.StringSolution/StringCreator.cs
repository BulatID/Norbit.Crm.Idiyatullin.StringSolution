﻿using System.Text;

namespace Norbit.Crm.Idiyatullin.StringSolution
{
    public class StringCreator
    {
        /// <summary>
        /// Создает строку с последовательностью чисел от 1 до <paramref name="size"/>.
        /// </summary>
        /// <param name="size">Размер последовательности.</param>
        /// <returns>Строка с последовательностью чисел, разделенных запятыми.</returns>
        /// <exception cref="ArgumentException">Если размер последовательности отрицательный или равен нулю.</exception>
        public static string CreateString(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Число должно быть положительным.", nameof(size));
            }

            var sequence = new StringBuilder();

            for (int i = 0; i <= size; i++)
            {
                sequence.Append(i);

                if (i != size)
                {
                    sequence.Append(", ");
                }
            }

            return sequence.ToString();
        }

        /// <summary>
        /// Создает строку, представляющую квадрат со стороной <paramref name="size"/>, заполненный звездочками, кроме середины.
        /// </summary>
        /// <param name="size">Размер стороны квадрата.</param>
        /// <returns>Строка, представляющая квадрат со звездочками, кроме середины.</returns>
        /// <exception cref="ArgumentException">Если размер квадрата отрицательный или равен нулю, либо не является нечетным числом.</exception>
        public static string CreateStar(int size)
        {
            if (size <= 0 || size % 2 == 0)
            {
                throw new ArgumentException("Число должно быть положительным или нечетным.", nameof(size));
            }

            var square = new StringBuilder();

            var center = size / 2;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    if (i == center && j == center)
                    {
                        square.Append(" ");
                    }
                    else
                    {
                        square.Append("*");
                    }
                }
                square.Append("\n");
            }

            return square.ToString();
        }
    }
}
