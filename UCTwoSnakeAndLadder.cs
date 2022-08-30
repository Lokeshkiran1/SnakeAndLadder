using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UCTwoSnakeAndLadder
    {
        public static void ucTwo()
        {
            int positionOfPlayer = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Position of player at initial is : " + positionOfPlayer +", and rolled a die : " + dice);
        }
    }
}
