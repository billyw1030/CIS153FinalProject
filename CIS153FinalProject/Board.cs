using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153FinalProject
{
    class Board
    {//board has height of 6 and width of 7

        //we can make a 2d array of cells to make up the board
        //we can call board by names that look like:

        //   1   2   3   4   5   6   7
        //   8   9  10  11  12  13  14
        //  15  16  17  18  19  20  21
        //  22  23  24  25  26  27  28
        //  29  30  31  32  33  34  35 
        //  36  37  38  39  40  41  42
        // private Cell board[Cell][Cell] = {Cell one(1, 6, 0), Cell two(2, 6, 0), Cell three(3, 6, 0), Cell four(4, 6, 0), Cell five(5, 6, 0), Cell six(6, 6, 0)Cell seven(7, 6, 0), 
        //                                Cell eight(1, 5, 0), Cell nine(2, 5, 0), Cell ten(3, 5, 0), Cell eleven(4, 5, 0), Cell twelve(5, 5, 0), Cell thirteen(6, 5, 0), Cell fourteen(7, 5, 0),
        //                     Cell fifteen(1, 4, 0), Cell sixteen(2, 4, 0), Cell seventeen(3, 4, 0), Cell eighteen(4, 4, 0), Cell nineteen(5, 4, 0), Cell twenty(6, 4, 0), Cell twentyOne(7, 4, 0),
        //                    Cell twentyTwo(1, 3, 0), Cell twentyThree(2, 3, 0), Cell twentyFour(3, 3, 0), Cell twentyFive(4, 3, 0), Cell twentySix(5, 3, 0), Cell twentySeven(6, 3, 0), Cell twentyEight(7, 3, 0),
        //                  Cell twentyNine(1, 2, 0), Cell thirty(2, 2, 0), Cell thirtyOne(3, 2, 0), Cell thirtyTwo(4, 2, 0), Cell thirtyThree(5, 2, 0), Cell thirtyFour(6, 2, 0), Cell thirtyFive(7, 2, 0),
        //                 Cell thirtySix(1, 1, 0), Cell thirtySeven(2, 1, 0), Cell thirtyEight(3, 1, 0), Cell thirtyNine(4, 1, 0), Cell fourty(5, 1, 0), Cell fourtyOne(6, 1, 0), Cell fourtyTwo(7, 1, 0);

        //this is what I was thinking would work for our boards, however, i also think we can condense this if we wanted to utilize only 1 board.
        //You can see this in zacks example and his lecture.
        Cell[,] singlePlayerBoard = new Cell[6, 7];
        Cell[,] twoPlayerBoard = new Cell[6, 7];


    }
}
