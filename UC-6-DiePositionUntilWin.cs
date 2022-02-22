using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_SnakeAndLadderProblem
{
    public class UC_6_DiePositionUntilWin
    {
        /// <summary>
        ///UC-6-Plays the dice and show position.
        /// </summary>
        public static void PlayTheDiceAndShowPosition()
        {
            int START = 0;
            const int NOPLAY = 1;
            const int SNAKE = 2;
            const int LADDER = 3;
            int position = 0;
            int diceRollCount = 0;
            int dice, option;
            
       
            Random random = new Random();

            while (position <= 100)
            {
                dice = random.Next(1, 7);
                option = random.Next(1, 4);
                if (position < 0)
                {
                    position = 0;
                }
                switch (option)
                {
                    case NOPLAY:
                        position += 0;
                        break;
                    case LADDER:
                        position += dice;
                        break;
                    case SNAKE:
                        position -= dice;
                        break;
                }
                if (position == 100)
                {
                    break;
                }
                if (position > 100)
                {
                    position -= dice;
                }
               
                diceRollCount++;
                if (diceRollCount > 5000)
                    break;
            }

            Console.WriteLine("The Dice Position is :- " + position);
            Console.WriteLine("The Number of Time Dice Rolled :- " + diceRollCount);

        }
    }
}
