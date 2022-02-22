using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_SnakeAndLadderProblem
{
    public class UC_4_RepeationTillPlayerWin
    {
        /// <summary>
        /// UC-4-Repeations the till winning position.
        /// </summary>
        public static void RepeationTillWinningPosition()
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
                if (position< 0)
                {
                    position = 0;
                }
                switch (option)
                {
                    case NOPLAY:
                        position += 0;
                        break;
                    case SNAKE:
                        position -= dice;
                        break;
                    case LADDER:
                        position += dice;
                        break;
                }
                Console.WriteLine(position);
            }
        }
    }
}
