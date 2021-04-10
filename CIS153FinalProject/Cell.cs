using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153FinalProject
{
    class Cell
    {
        //every cell in the board can either be empty, player one, or player two.
        //we will decide what status each cell is by an int, 1 = player1, 2 = player2, and 0 = not taken.
        //we will identify every cell with x and y coordinate for the board.
        private int x;
        private int y;
        private int fill = 0;
        
        Cell(int xc, int yc, int f)
        {
            x = xc;
            y = yc;
            fill = f;
        }
        public void setPlayerOne()
        {
            fill = 1;
        }

        public void setPlayerTwo()
        {
            fill = 2;
        }

        public void setX(int Xcoordinate)
        {
            x = Xcoordinate;
        }

        public void setY(int Ycoordinate)
        {
            y = Ycoordinate;
        }

        public int getFill()
        {
            return fill;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
