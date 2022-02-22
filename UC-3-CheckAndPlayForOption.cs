using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_SnakeAndLadderProblem
{
    public class UC_3_CheckAndPlayForOption
    {
        /// <summary>
        /// UC-3-Play and check the option to play.
        /// </summary>
        public static void PlayerCheckOptionToplay()
        {
            int START = 0;
            const int NOPLAY = 1;
            const int SNAKE = 2;
            const int LADDER = 3;
            int position = 0;
           
            Random random = new Random();
            int dice = random.Next(1, 7);
            int option = random.Next(1, 4);

            switch (option)
            {
                case NOPLAY:
                    position = 0;
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
