using System.Text;

namespace Norbit.Crm.Idiyatullin.StringSolution
{
    public class StringCreator
    {
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

        public static string CreateStar(int size)
        {
            if (size <= 0 || size % 2 == 0)
            {
                throw new ArgumentException("Число должно быть положительным или нечетным.", nameof(size));
            }

            var square = new StringBuilder();

            var average = size / 2;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    if (i == average && j == average)
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
