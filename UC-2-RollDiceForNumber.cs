using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_SnakeAndLadderProblem
{
    public class UC_2_RollDiceForNumber
    {
        /// <summary>
        /// UC-2-Rolls the die to get value.
        /// </summary>
        public static void RollDieToGetValue()
        {
            int START = 0;
            int POSITION = 0;
            
            Random random = new Random();
            int dice = random.Next(1, 7);

            Console.WriteLine(dice);
        }
    }
}
