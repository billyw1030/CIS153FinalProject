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
        private int c;
        private int r;
        private int fill = 0;
        //Button btn; is also possible like in zack video, but our current way works as well.
        
        public Cell(int co, int ro, int f)
        {
            c = co;
            r = ro;
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

        public void setC(int columns)
        {
            c = columns;
        }

        public void setR(int rows)
        {
            r = rows;
        }

        public int getFill()
        {
            return fill;
        }

        public int getC()
        {
            return c;
        }

        public int getR()
        {
            return r;
        }
    }
}
