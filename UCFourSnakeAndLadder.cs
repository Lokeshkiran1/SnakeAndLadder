using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UCFourSnakeAndLadder
    {
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public static void ucFour()
        {
            int positionOfPlayer = 0;
            while(positionOfPlayer <100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch(option)
                {
                    case IS_LADDER:
                        Console.WriteLine("yeah its a ladder climb upp");
                        positionOfPlayer+=dice;
                        break;
                        case IS_SNAKE:
                        Console.WriteLine("oops its snake come down");
                        positionOfPlayer-=dice; 
                        if(positionOfPlayer<0)
                            positionOfPlayer=0;
                        break;
                        default:
                        Console.WriteLine("remain in same positin");
                        break;
                }
                Console.WriteLine("initial positin : "+positionOfPlayer+" and dice value : "+dice);
            }
        }
    }
}
