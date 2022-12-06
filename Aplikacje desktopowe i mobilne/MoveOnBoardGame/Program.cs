using System;
using System.Threading;

namespace MoveOnBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var dane = Console.ReadKey();

            Board board = new Board();
            board.Draw();

            Player player = new Player();
            

            char direction = 's';

            while(true)
            {
                player.Move(direction);
                if(board.CollisionDetect(player.CurrX, player.CurrY))
                {
                    break;
                }
                Thread.Sleep(500);
            }
        }
    }
}
