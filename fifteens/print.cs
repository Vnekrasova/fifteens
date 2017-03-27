using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteens
{
    class print
    {
        public static void PrintInfo(game mas,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", mas[i, j]);

                }
                Console.WriteLine();
            }
        }
        
    }
}
