using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UCThreeSnakeAndLadder
    {
        public const int IS_LADDER=1;
        public const int IS_SNAKE=2;
        public static void ucThree()
        {
            int positionOfPlayer = 0;
            Random random = new Random();   
            int dice=random.Next(1,7);
            int option=random.Next(0,3);
            switch(option)
            {
                case IS_LADDER:
                    positionOfPlayer += dice;
                    break;
                    case IS_SNAKE:
                    positionOfPlayer -= dice;
                    if(positionOfPlayer < 0)
                        positionOfPlayer = 0;
                    break ;
                default:break;

            }
            Console.WriteLine("Position of player is " + positionOfPlayer + ", and rolled a die: " + dice);
        }
    }
}
