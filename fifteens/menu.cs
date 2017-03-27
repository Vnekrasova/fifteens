using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fifteens
{
    class menu
    {
        static public void StartTheGame()
        {
            //Random gen = new Random();
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            game3 player = new game3(number);
            player.Randomize();            
            
            //player.Fillig(gen); 
            Console.Clear();
            while (!player.CheckingSequence())
            {
                // player.Printing();
                print.PrintInfo(player, number);
                Console.WriteLine("Выберете число,которое хотите передвинуть");
                int value = Convert.ToInt16(Console.ReadLine());
                player.Shift(value);
                Console.Clear();

            }
            //  player.Printing();
            print.PrintInfo(player, number);
            Console.WriteLine("Вы выиграли!");
            Console.WriteLine("Вывести историю ходов на экран?");
            string answer = Convert.ToString(Console.ReadLine());
            if (answer == "да")
            {
                Console.WriteLine("История ходов:");
                player.PrintHistory();
                Console.WriteLine("Хотите сыграть еще раз: да/нет ");
                string answer1 = Convert.ToString(Console.ReadLine());
                while (answer1 == "да")
                {
                    Console.Clear();
                    menu.StartTheGame();
                }
                Console.WriteLine("Спасибо за игру!");
            }
            else
            {
                Console.WriteLine("Хотите сыграть еще раз: да/нет ");
                string answer1 = Convert.ToString(Console.ReadLine());
                while (answer1 == "да")
                {
                    Console.Clear();
                    menu.StartTheGame();
                }
                Console.WriteLine("Спасибо за игру!");
            }
          


        }
    }
}
