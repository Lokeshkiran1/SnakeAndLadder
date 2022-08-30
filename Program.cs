using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Snake and Ladder Game");
            Console.WriteLine("Choose option\n1.Check position of player\n2.Rolling of Dice");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    UCOneSnakeAndLadder.ucOne();
                    break;
                    case 2:
                    UCTwoSnakeAndLadder.ucTwo();
                    break;
                    default:
                    Console.WriteLine("enter valid choice");
                    break;

            }
        }
    }
}
