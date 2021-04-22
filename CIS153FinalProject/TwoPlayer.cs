using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153FinalProject
{
    public partial class TwoPlayer : Form
    {
        private new WelcomeForm Menu;
        private Board twoPlayerBoard = new Board();

        private bool PlayerOneTurn = true;
        private bool PlayerTwoTurn = false;
        private static Color PlayerOneColor = Color.FromArgb(0, 0, 50);
        private static Color PlayerTwoColor = Color.FromArgb(100, 0, 0);
        private Cell dropCell = new Cell();


        //                  r  c  f
        Cell One = new Cell(0, 0, 0);
        Cell Two = new Cell(0, 1, 0);
        Cell Three = new Cell(0, 2, 0);
        Cell Four = new Cell(0, 3, 0);
        Cell Five = new Cell(0, 4, 0);
        Cell Six = new Cell(0, 5, 0);
        Cell Seven = new Cell(0, 6, 0);
        Cell Eight = new Cell(1, 0, 0);
        Cell Nine = new Cell(1, 1, 0);
        Cell Ten = new Cell(1, 2, 0);
        Cell Eleven = new Cell(1, 3, 0);
        Cell Twelve = new Cell(1, 4, 0);
        Cell Thirteen = new Cell(1, 4, 0);
        Cell Fourteen = new Cell(1, 6, 0);
        Cell Fifteen = new Cell(2, 0, 0);
        Cell Sixteen = new Cell(2, 1, 0);
        Cell Seventeen = new Cell(2, 2, 0);
        Cell Eighteen = new Cell(2, 3, 0);
        Cell Nineteen = new Cell(2, 4, 0);
        Cell Twenty = new Cell(2, 5, 0);
        Cell TwentyOne = new Cell(2, 6, 0);
        Cell TwentyTwo = new Cell(3, 0, 0);
        Cell TwentyThree = new Cell(3, 1, 0);
        Cell TwentyFour = new Cell(3, 2, 0);
        Cell TwentyFive = new Cell(3, 3, 0);
        Cell TwentySix = new Cell(3, 4, 0);
        Cell TwentySeven = new Cell(3, 5, 0);
        Cell TwentyEight = new Cell(3, 6, 0);
        Cell TwentyNine = new Cell(4, 0, 0);
        Cell Thirty = new Cell(4, 1, 0);
        Cell ThirtyOne = new Cell(4, 2, 0);
        Cell ThirtyTwo = new Cell(4, 3, 0);
        Cell ThirtyThree = new Cell(4, 4, 0);
        Cell ThirtyFour = new Cell(4, 5, 0);
        Cell ThirtyFive = new Cell(4, 6, 0);
        Cell ThirtySix = new Cell(5, 0, 0);
        Cell ThirtySeven = new Cell(5, 1, 0);
        Cell ThirtyEight = new Cell(5, 2, 0);
        Cell ThirtyNine = new Cell(5, 3, 0);
        Cell Fourty = new Cell(5, 4, 0);
        Cell FourtyOne = new Cell(5, 5, 0);
        Cell FourtyTwo = new Cell(5, 6, 0);


        public TwoPlayer()
        {
            InitializeComponent();
        }
        
        public TwoPlayer(WelcomeForm main)
        {
            InitializeComponent();
            Menu = main;
        }

        public void FormPassedToMeThree(WelcomeForm mainMenu)
        {
            Menu = mainMenu;
        }

        private void btn_exitTwoPlayer_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void TwoPlayer_Load(object sender, EventArgs e)
        {
            twoPlayerBoard.setGameBoardCell(One);
            twoPlayerBoard.setGameBoardCell(Two);
            twoPlayerBoard.setGameBoardCell(Three);
            twoPlayerBoard.setGameBoardCell(Four);
            twoPlayerBoard.setGameBoardCell(Five);
            twoPlayerBoard.setGameBoardCell(Six);
            twoPlayerBoard.setGameBoardCell(Seven);
            twoPlayerBoard.setGameBoardCell(Eight);
            twoPlayerBoard.setGameBoardCell(Nine);
            twoPlayerBoard.setGameBoardCell(Ten);
            twoPlayerBoard.setGameBoardCell(Eleven);
            twoPlayerBoard.setGameBoardCell(Twelve);
            twoPlayerBoard.setGameBoardCell(Thirteen);
            twoPlayerBoard.setGameBoardCell(Fourteen);
            twoPlayerBoard.setGameBoardCell(Fifteen);
            twoPlayerBoard.setGameBoardCell(Sixteen);
            twoPlayerBoard.setGameBoardCell(Seventeen);
            twoPlayerBoard.setGameBoardCell(Eighteen);
            twoPlayerBoard.setGameBoardCell(Nineteen);
            twoPlayerBoard.setGameBoardCell(Twenty);
            twoPlayerBoard.setGameBoardCell(TwentyOne);
            twoPlayerBoard.setGameBoardCell(TwentyTwo);
            twoPlayerBoard.setGameBoardCell(TwentyThree);
            twoPlayerBoard.setGameBoardCell(TwentyFour);
            twoPlayerBoard.setGameBoardCell(TwentyFive);
            twoPlayerBoard.setGameBoardCell(TwentySix);
            twoPlayerBoard.setGameBoardCell(TwentySeven);
            twoPlayerBoard.setGameBoardCell(TwentyEight);
            twoPlayerBoard.setGameBoardCell(TwentyNine);
            twoPlayerBoard.setGameBoardCell(Thirty);
            twoPlayerBoard.setGameBoardCell(ThirtyOne);
            twoPlayerBoard.setGameBoardCell(ThirtyTwo);
            twoPlayerBoard.setGameBoardCell(ThirtyThree);
            twoPlayerBoard.setGameBoardCell(ThirtyFour);
            twoPlayerBoard.setGameBoardCell(ThirtyFive);
            twoPlayerBoard.setGameBoardCell(ThirtySix);
            twoPlayerBoard.setGameBoardCell(ThirtySeven);
            twoPlayerBoard.setGameBoardCell(ThirtyEight);
            twoPlayerBoard.setGameBoardCell(ThirtyNine);
            twoPlayerBoard.setGameBoardCell(Fourty);
            twoPlayerBoard.setGameBoardCell(FourtyOne);
            twoPlayerBoard.setGameBoardCell(FourtyTwo);


            One.setCellBelow(Eight);
            Two.setCellBelow(Nine);
            Three.setCellBelow(Ten);
            Four.setCellBelow(Eleven);
            Five.setCellBelow(Twelve);
            Six.setCellBelow(Thirteen);
            Seven.setCellBelow(Fourteen);
            Eight.setCellBelow(Fifteen);
            Nine.setCellBelow(Sixteen);
            Ten.setCellBelow(Seventeen);
            Eleven.setCellBelow(Eighteen);
            Twelve.setCellBelow(Nineteen);
            Thirteen.setCellBelow(Twenty);
            Fourteen.setCellBelow(TwentyOne);
            Fifteen.setCellBelow(TwentyTwo);
            Sixteen.setCellBelow(TwentyThree);
            Seventeen.setCellBelow(TwentyFour);
            Eighteen.setCellBelow(TwentyFive);
            Nineteen.setCellBelow(TwentySix);
            Twenty.setCellBelow(TwentySeven);
            TwentyOne.setCellBelow(TwentyEight);
            TwentyTwo.setCellBelow(TwentyNine);
            TwentyThree.setCellBelow(Thirty);
            TwentyFour.setCellBelow(ThirtyOne);
            TwentyFive.setCellBelow(ThirtyTwo);
            TwentySix.setCellBelow(ThirtyThree);
            TwentySeven.setCellBelow(ThirtyFour);
            TwentyEight.setCellBelow(ThirtyFive);
            TwentyNine.setCellBelow(ThirtySix);
            Thirty.setCellBelow(ThirtySeven);
            ThirtyOne.setCellBelow(ThirtyEight);
            ThirtyTwo.setCellBelow(ThirtyNine);
            ThirtyThree.setCellBelow(Fourty);
            ThirtyFour.setCellBelow(FourtyOne);
            ThirtyFive.setCellBelow(FourtyTwo);
        }

        private Cell ChipFall(Cell cell)
        {

            if (cell.getR() != 5)
            {
                while (cell.getCellBelow().getFill() == 0)
                {
                    cell = cell.getCellBelow();
                }

                return cell;
            }

            else
            {
                return cell;
            }
        }

        private void DeclareButton(Cell cell, int playerTurn)
        {
            if (cell == One && playerTurn == 1)
            {
                Btn_c0r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == One && playerTurn == 2)
            {
                Btn_c0r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Two && playerTurn == 1)
            {
                Btn_c1r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Two && playerTurn == 2)
            {
                Btn_c1r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Three && playerTurn == 1)
            {
                Btn_c2r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Three && playerTurn == 2)
            {
                Btn_c2r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Four && playerTurn == 1)
            {
                Btn_c3r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Four && playerTurn == 2)
            {
                Btn_c3r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Five && playerTurn == 1)
            {
                Btn_c4r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Five && playerTurn == 2)
            {
                Btn_c4r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Six && playerTurn == 1)
            {
                Btn_c5r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Six && playerTurn == 2)
            {
                Btn_c5r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Seven && playerTurn == 1)
            {
                Btn_c6r0TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Seven && playerTurn == 2)
            {
                Btn_c6r0TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Eight && playerTurn == 1)
            {
                Btn_c0r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Eight && playerTurn == 2)
            {
                Btn_c0r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Nine && playerTurn == 1)
            {
                Btn_c1r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Nine && playerTurn == 2)
            {
                Btn_c1r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Ten && playerTurn == 1)
            {
                Btn_c2r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Ten && playerTurn == 2)
            {
                Btn_c2r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Eleven && playerTurn == 1)
            {
                Btn_c3r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Eleven && playerTurn == 2)
            {
                Btn_c3r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Twelve && playerTurn == 1)
            {
                Btn_c4r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Twelve && playerTurn == 2)
            {
                Btn_c4r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Thirteen && playerTurn == 1)
            {
                Btn_c5r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Thirteen && playerTurn == 2)
            {
                Btn_c5r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Fourteen && playerTurn == 1)
            {
                Btn_c6r1TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Fourteen && playerTurn == 2)
            {
                Btn_c6r1TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Fifteen && playerTurn == 1)
            {
                Btn_c0r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Fifteen && playerTurn == 2)
            {
                Btn_c0r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Sixteen && playerTurn == 1)
            {
                Btn_c1r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Sixteen && playerTurn == 2)
            {
                Btn_c1r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Seventeen && playerTurn == 1)
            {
                Btn_c2r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Seventeen && playerTurn == 2)
            {
                Btn_c2r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Eighteen && playerTurn == 1)
            {
                Btn_c3r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Eighteen && playerTurn == 2)
            {
                Btn_c3r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Nineteen && playerTurn == 1)
            {
                Btn_c4r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Nineteen && playerTurn == 2)
            {
                Btn_c4r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Twenty && playerTurn == 1)
            {
                Btn_c5r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Twenty && playerTurn == 2)
            {
                Btn_c5r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyOne && playerTurn == 1)
            {
                Btn_c6r2TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyOne && playerTurn == 2)
            {
                Btn_c6r2TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyTwo && playerTurn == 1)
            {
                Btn_c0r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyTwo && playerTurn == 2)
            {
                Btn_c0r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyThree && playerTurn == 1)
            {
                Btn_c1r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyThree && playerTurn == 2)
            {
                Btn_c1r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyFour && playerTurn == 1)
            {
                Btn_c2r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyFour && playerTurn == 2)
            {
                Btn_c2r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyFive && playerTurn == 1)
            {
                Btn_c3r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyFive && playerTurn == 2)
            {
                Btn_c3r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentySix && playerTurn == 1)
            {
                Btn_c4r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentySix && playerTurn == 2)
            {
                Btn_c4r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentySeven && playerTurn == 1)
            {
                Btn_c5r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentySeven && playerTurn == 2)
            {
                Btn_c5r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyEight && playerTurn == 1)
            {
                Btn_c6r3TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyEight && playerTurn == 2)
            {
                Btn_c6r3TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == TwentyNine && playerTurn == 1)
            {
                Btn_c0r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == TwentyNine && playerTurn == 2)
            {
                Btn_c0r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Thirty && playerTurn == 1)
            {
                Btn_c1r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Thirty && playerTurn == 2)
            {
                Btn_c1r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyOne && playerTurn == 1)
            {
                Btn_c2r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyOne && playerTurn == 2)
            {
                Btn_c2r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyTwo && playerTurn == 1)
            {
                Btn_c3r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyTwo && playerTurn == 2)
            {
                Btn_c3r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyThree && playerTurn == 1)
            {
                Btn_c4r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyThree && playerTurn == 2)
            {
                Btn_c4r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyFour && playerTurn == 1)
            {
                Btn_c5r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyFour && playerTurn == 2)
            {
                Btn_c5r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyFive && playerTurn == 1)
            {
                Btn_c6r4TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyFive && playerTurn == 2)
            {
                Btn_c6r4TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtySix && playerTurn == 1)
            {
                Btn_c0r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtySix && playerTurn == 2)
            {
                Btn_c0r5TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtySeven && playerTurn == 1)
            {
                Btn_c1r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtySeven && playerTurn == 2)
            {
                Btn_c1r5TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyEight && playerTurn == 1)
            {
                Btn_c2r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyEight && playerTurn == 2)
            {
                Btn_c2r5TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == ThirtyNine && playerTurn == 1)
            {
                Btn_c3r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == ThirtyNine && playerTurn == 2)
            {
                Btn_c3r5TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == Fourty && playerTurn == 1)
            {
                Btn_c4r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == Fourty && playerTurn == 2)
            {
                Btn_c4r5TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == FourtyOne && playerTurn == 1)
            {
                Btn_c5r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == FourtyOne && playerTurn == 2)
            {
                Btn_c5r5TwoP.ButtonColor = PlayerTwoColor;
            }

            if (cell == FourtyTwo && playerTurn == 1)
            {
                Btn_c6r5TwoP.ButtonColor = PlayerOneColor;
            }

            if (cell == FourtyTwo && playerTurn == 2)
            {
                Btn_c6r5TwoP.ButtonColor = PlayerTwoColor;
            }

        }

        private void Btn_close2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        
        private void Btn_c0r0TwoP_Click(object sender, EventArgs e)
        {//Cell One
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(One);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(One);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r0TwoP_Click(object sender, EventArgs e)
        {//Cell Two
            if (Two.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Two);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Two.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Two);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r0TwoP_Click(object sender, EventArgs e)
        {//Cell Three
            if (Three.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Three);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Three.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Three);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r0TwoP_Click(object sender, EventArgs e)
        {//Cell Four
            if (Four.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Four);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Four.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Four);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r0TwoP_Click(object sender, EventArgs e)
        {//Cell Five
            if (Five.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Five);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Five.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Five);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r0TwoP_Click(object sender, EventArgs e)
        {//Cell Six
            if (Six.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Six);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Six.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Six);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r0TwoP_Click(object sender, EventArgs e)
        {//Cell Seven
            if (Seven.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Seven);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Seven.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Seven);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r1TwoP_Click(object sender, EventArgs e)
        {//Cell Eight
            if (Eight.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Eight);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Eight.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Eight);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r1TwoP_Click(object sender, EventArgs e)
        {//Cell Nine
            if (Nine.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Nine);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Nine.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Nine);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r1TwoP_Click(object sender, EventArgs e)
        {//Cell Ten
            if (Ten.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Ten);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Ten.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Ten);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r1TwoP_Click(object sender, EventArgs e)
        {//Cell Eleven
            if (Eleven.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Eleven);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Eleven.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Eleven);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r1TwoP_Click(object sender, EventArgs e)
        {//Cell Twelve
            if (Twelve.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Twelve);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Twelve.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Twelve);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r1TwoP_Click(object sender, EventArgs e)
        {//Cell Thirteen
            if (Thirteen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Thirteen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Thirteen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Thirteen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r1TwoP_Click(object sender, EventArgs e)
        {//Cell Fourteen
            if (Fourteen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Fourteen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Fourteen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Fourteen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r2TwoP_Click(object sender, EventArgs e)
        {//Cell Fifteen
            if (Fifteen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Fifteen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Fifteen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Fifteen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r2TwoP_Click(object sender, EventArgs e)
        {//Cell Sixteen
            if (Sixteen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Sixteen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Sixteen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Sixteen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r2TwoP_Click(object sender, EventArgs e)
        {//Cell Seventeen
            if (Seventeen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Seventeen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Seventeen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Seventeen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r2TwoP_Click(object sender, EventArgs e)
        {//Cell Eighteen
            if (Eighteen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Eighteen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Eighteen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Eighteen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r2TwoP_Click(object sender, EventArgs e)
        {//Cell Nineteen
            if (Nineteen.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Nineteen);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Nineteen.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Nineteen);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r2TwoP_Click(object sender, EventArgs e)
        {//Cell Twenty
            if (Twenty.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Twenty);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Twenty.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Twenty);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r2TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyOne
            if (TwentyOne.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyOne);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyOne.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyOne);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyTwo
            if (TwentyTwo.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyTwo);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyTwo);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyThree
            if (TwentyThree.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyThree);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyThree.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyThree);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyFour
            if (TwentyFour.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyFour);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyFour.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyFour);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyFive
            if (TwentyFive.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyFive);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyFive.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyFive);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentySix
            if (TwentySix.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentySix);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentySix.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentySix);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentySeven
            if (TwentySeven.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentySeven);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentySeven.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentySeven);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyEight
            if (TwentyEight.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyEight);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyEight.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyEight);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r4TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyNine
            if (TwentyNine.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyNine);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (TwentyNine.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyNine);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r4TwoP_Click(object sender, EventArgs e)
        {//Cell Thirty
            if (Thirty.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Thirty);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Thirty.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Thirty);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyOne
            if (ThirtyOne.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyOne);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyOne.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyOne);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyTwo
            if (ThirtyTwo.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyTwo);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyTwo);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyThree
            if (ThirtyThree.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyThree);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyThree.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyThree);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyFour
            if (ThirtyFour.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyFour);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyFour.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyFour);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyFive
            if (ThirtyFive.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyFive);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyFive.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyFive);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtySix
            if (ThirtySix.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtySix);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtySix.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtySix);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtySeven
            if (ThirtySeven.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtySeven);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtySeven.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtySeven);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyEight
            if (ThirtyEight.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyEight);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyEight.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyEight);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyNine
            if (ThirtyNine.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyNine);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (ThirtyNine.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyNine);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r5TwoP_Click(object sender, EventArgs e)
        {//Cell Fourty
            if (Fourty.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Fourty);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (Fourty.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Fourty);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r5TwoP_Click(object sender, EventArgs e)
        {//Cell FourtyOne
            if (FourtyOne.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(FourtyOne);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (FourtyOne.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(FourtyOne);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r5TwoP_Click(object sender, EventArgs e)
        {//Cell FourtyTwo
            if (FourtyTwo.getFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(FourtyTwo);
                DeclareButton(dropCell, 1);
                dropCell.setPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (FourtyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(FourtyTwo);
                DeclareButton(dropCell, 2);
                dropCell.setPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }
        
        
    }    
    
}
