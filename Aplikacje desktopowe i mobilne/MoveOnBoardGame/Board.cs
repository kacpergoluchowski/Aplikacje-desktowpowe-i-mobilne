using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Board
    {
        private int height = 20;
        private int width = 30;
        private ConsoleColor backgroundColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.Yellow;
        private char borderCharTop = '|';
        private char borderCharLeft = '-';
        public Board()
        {
        
        }
        public void Draw()
        {
            Console.Clear();
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;

            for (int i = 0; i < width; i++)
            {
                Console.Write(borderCharLeft);
            }

            for (int i = 1; i < height-1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(borderCharTop);

                Console.SetCursorPosition(width-1, i);
                Console.Write(borderCharTop);
            }
            Console.SetCursorPosition(0, height-1);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderCharLeft);
            }
            Console.ResetColor();
        }
        public bool CollisionDetect(int x, int y)
        {
            if (y == 0)
                return true;
            if (x == 0)
                return true;
            if (y == height-1)
                return true;
            if (x == width-1)
                return true;

            return false;
        }
    }
}
