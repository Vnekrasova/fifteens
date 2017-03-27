using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fifteens
{
    class game3:game2
    {
        public readonly List<int> history;
        public game3(int size): base(size)
        {
           history = new List<int>();
        }

        public override bool Shift(int value)
        {
                if (base.Shift(value))
                {
                    history.Add(value);
                    return true;
                }
            return false;
        }
       
        public void Rollback()
        {
            int lastMove = history.Last();
            history.Remove(lastMove);
            this.Shift(lastMove);
        }
       public void PrintHistory()
        {
            for (int i = 0; i < history.Count; i++)
            {
                Console.WriteLine("Ход {0}, костяшка {1}",i+1, history[i]);
            }
        }



    }
}
