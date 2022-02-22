using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_SnakeAndLadderProblem
{
    public class UC_7_PlayGameUsingTwoPlayer
    {
        /// <summary>
        /// UC-7-Plays the game show player who won from two player.
        /// </summary>
        public static void PlayGameShowPlayerWhoWon()
        {
            const int START = 0;
            const int NOPLAY = 1;
            const int SNAKE = 2;
            const int LADDER = 3;
            int player1Count = 0;
            int player2Count = 0;
            int position = 0;
            int diceRollCount = 0;

            Random random = new Random();

            while (position <= 100)
            { 
                int dice, option;
                dice = random.Next(1, 7);
                option = random.Next(1, 4);
                 if (position < 0)
                 {
                    position = START;
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
                player1Count++;
                player2Count++;
                

            }
            Console.WriteLine("The Dice Position is :- " + position);
            Console.WriteLine("The Number of Time Dice Rolled :- " + diceRollCount);

           
            if (player1Count <= 1000)
              {
                   Console.WriteLine("Player 1 is winner "+player1Count);
              }
               else
               {
                    Console.WriteLine("Player 2 is winner " + player2Count);   
               }
            

        }
    }
    
}
