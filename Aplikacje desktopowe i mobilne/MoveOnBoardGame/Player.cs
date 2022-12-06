using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Player
    {
        private ConsoleColor backgroundColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.Yellow;
        private char playerChar = 'O';

        private const char moveUp = 'w';
        private const char moveDown = 's';
        private const char moveLeft = 'a';
        private const char moveRight = 'd';

        private int currX = 1;
        private int currY = 1;
        private int prevX = 1;
        private int prevY = 1;

        public int CurrX
        {
            get
            {
                return currX;
            }
        }
        public int CurrY
        {
            get
            {
                return currY;
            }
        }

        public Player()
        {
            Draw();
        }
        char direction;
        public void Move(char directon)
        {
            char presKey = Console.ReadKey(true).KeyChar; 
            switch(directon)
            {
                case moveUp:
                    currY--;
                    break;
                case moveDown:
                    currY++;
                    break;
                case moveLeft:
                    currX--;
                    break;
                case moveRight:
                    currX++;
                    break;
                default:
                    break;
            }
            Draw();
            
        }

        private void Draw()
        {
            Console.ResetColor();
            Console.SetCursorPosition(prevX, prevY);
            Console.Write(' ');

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.SetCursorPosition(currX, currY);
            Console.Write(playerChar);

            prevX = currX;
            prevY = currY;

            Console.ResetColor();
        }
    }
}
