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
        Cell cellBelow;
        
        public Cell()
        {

        }

        public Cell(int ro, int co, int f)
        {
            c = co;
            r = ro;
            fill = f;
        }
        public void SetPlayerOne()
        {
            fill = 1;
        }

        public void SetPlayerTwo()
        {
            fill = 2;
        }

        public void SetC(int columns)
        {
            c = columns;
        }

        public void SetR(int rows)
        {
            r = rows;
        }

        public void SetCellBelow(Cell c)
        {
            cellBelow = c;
        }

        public int GetFill()
        {
            return fill;
        }

        public int GetC()
        {
            return c;
        }

        public int GetR()
        {
            return r;
        }

        public Cell GetCellBelow()
        {
            //Console.WriteLine("Grabbing cell below");
            return cellBelow;
        }
    }
}
