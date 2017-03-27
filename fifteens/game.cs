using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fifteens
{
    class game
    {
        public readonly int[,] field; 

        public game(int size)
        {
            this.field = new int[size, size];
        }

        
        public int this[int x,int y]
        {
            get
            {
                return this.field[x, y];
            }
            set
            {
                this.field[x, y] = value;
            }
        }


        private int[] GetLocation(int value)
        {
            int[] address = new int[2];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == value)
                    {
                        address[0] = i;
                        address[1] = j;
                    }
                }
            }
            return address;
        }

        public virtual bool Shift(int value)
        {
            int[] addressofvalue = GetLocation(value);
            int[] addressofzero = GetLocation(0);
            int x = addressofvalue[0];
            int y = addressofvalue[1];
            int x0 = addressofzero[0];
            int y0 = addressofzero[1];
            if (Math.Abs(x-x0)+Math.Abs(y-y0)==1)
            {
                int temp = this[x, y];
                this[x, y] = this[x0, y0];
                this[x0, y0] = temp;
                return true;
            }
            else return false;

        }


    }
}

