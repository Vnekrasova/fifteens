using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteens
{
    class game2:game
    {
        public game2(int size): base(size)
        {

        }

        public void Randomize()
        {
            Random gen = new Random();
            int[] numbers = new int[field.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = gen.Next(0, field.Length);
                int y = numbers[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (numbers[i] == numbers[j])
                        {
                            numbers[i] = gen.Next(0, field.Length);
                            j = 0;
                            y = numbers[i];
                        }
                        y = numbers[i];
                    }
                }
                //Console.WriteLine("{0},{1}",numbers[i],i);
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = numbers[i * field.GetLength(0) + j];

                }
            }
        }

        public bool CheckingSequence()
        {
            int[] numbers = new int[field.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = i + 1;
                }
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] != numbers[i * field.GetLength(0) + j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
