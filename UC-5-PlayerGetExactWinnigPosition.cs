using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_SnakeAndLadderProblem
{
    public class UC_5_PlayerGetExactWinnigPosition
    {
        /// <summary>
        /// UC-5-Exacts the winning position by player.
        /// </summary>
        public static void ExactWinningPositionByPlayer()
        {
            int START = 0;
            const int NOPLAY = 1;
            const int SNAKE = 2;
            const int LADDER = 3;
            int position = 0;
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
               
            }

            Console.WriteLine(position);
            
        }
    }
}
