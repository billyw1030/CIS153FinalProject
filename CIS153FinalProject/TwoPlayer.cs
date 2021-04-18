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
        private Board twoPlayerBoard;

        private bool PlayerOneTurn = true;
        private bool PlayerTwoTurn = false;
        private static Color PlayerOneColor = Color.FromArgb(0, 0, 50);
        private static Color PlayerTwoColor = Color.FromArgb(100, 0, 0);

        //                  c  r  f
        Cell One = new Cell(0, 0, 0);        
        Cell Two = new Cell(1, 0, 0);
        Cell Three = new Cell(2, 0, 0);
        Cell Four = new Cell(3, 0, 0);
        Cell Five = new Cell(4, 0, 0);
        Cell Six = new Cell(5, 0, 0);
        Cell Seven = new Cell(6, 0, 0);
        Cell Eight = new Cell(0, 1, 0);
        Cell Nine = new Cell(1, 1, 0);
        Cell Ten = new Cell(2, 1, 0);
        Cell Eleven = new Cell(3, 1, 0);
        Cell Twelve = new Cell(4, 1, 0);
        Cell Thirteen = new Cell(5, 1, 0);
        Cell Fourteen = new Cell(6, 1, 0);
        Cell Fifteen = new Cell(0, 2, 0);
        Cell Sixteen = new Cell(1, 2, 0);
        Cell Seventeen = new Cell(2, 2, 0);
        Cell Eighteen = new Cell(3, 2, 0);
        Cell Nineteen = new Cell(4, 2, 0);
        Cell Twenty = new Cell(5, 2, 0);
        Cell TwentyOne = new Cell(6, 2, 0);
        Cell TwentyTwo = new Cell(0, 3, 0);
        Cell TwentyThree = new Cell(1, 3, 0);
        Cell TwentyFour = new Cell(2, 3, 0);
        Cell TwentyFive = new Cell(3, 3, 0);
        Cell TwentySix = new Cell(4, 3, 0);
        Cell TwentySeven = new Cell(5, 3, 0);
        Cell TwentyEight = new Cell(6, 3, 0);
        Cell TwentyNine = new Cell(0, 4, 0);
        Cell Thirty = new Cell(1, 4, 0);
        Cell ThirtyOne = new Cell(2, 4, 0);
        Cell ThirtyTwo = new Cell(3, 4, 0);
        Cell ThirtyThree = new Cell(4, 4, 0);
        Cell ThirtyFour = new Cell(5, 4, 0);
        Cell ThirtyFive = new Cell(6, 4, 0);
        Cell ThirtySix = new Cell(0, 5, 0);
        Cell ThirtySeven = new Cell(1, 5, 0);
        Cell ThirtyEight = new Cell(2, 5, 0);
        Cell ThirtyNine = new Cell(3, 5, 0);
        Cell Fourty = new Cell(4, 5, 0);
        Cell FourtyOne = new Cell(5, 5, 0);
        Cell FourtyTwo = new Cell(6, 5, 0);

        public TwoPlayer()
        {
            InitializeComponent();
            twoPlayerBoard = new Board();
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

        }
        
        private void Btn_close2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        
        private void Btn_c0r0TwoP_Click(object sender, EventArgs e)
        {//Cell One
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                One.setPlayerOne();
                //Console.Write("Before setting boardcell");
                //Console.Write(One);
                twoPlayerBoard.setGameBoardCell(One);
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                One.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(One);
            }
        }

        private void Btn_c1r0TwoP_Click(object sender, EventArgs e)
        {//Cell Two
            if (Two.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Two.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Two);
            }

            else if (Two.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Two.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Two);
            }
        }

        private void Btn_c2r0TwoP_Click(object sender, EventArgs e)
        {//Cell Three
            if (Three.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Three.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Three);
            }

            else if (Three.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Three.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Three);
            }
        }

        private void Btn_c3r0TwoP_Click(object sender, EventArgs e)
        {//Cell Four
            if (Four.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Four.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Four);
            }

            else if (Four.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Four.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Four);
            }
        }

        private void Btn_c4r0TwoP_Click(object sender, EventArgs e)
        {//Cell Five
            if (Five.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Five.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Five);
            }

            else if (Five.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Five.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Five);
            }
        }

        private void Btn_c5r0TwoP_Click(object sender, EventArgs e)
        {//Cell Six
            if (Six.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Six.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Six);
            }

            else if (Six.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Six.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Six);
            }
        }

        private void Btn_c6r0TwoP_Click(object sender, EventArgs e)
        {//Cell Seven
            if (Seven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Seven.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Seven);
            }

            else if (Seven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Seven.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Seven);
            }
        }

        private void Btn_c0r1TwoP_Click(object sender, EventArgs e)
        {//Cell Eight
            if (Eight.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Eight.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Eight);
            }

            else if (Eight.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Eight.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Eight);
            }
        }

        private void Btn_c1r1TwoP_Click(object sender, EventArgs e)
        {//Cell Nine
            if (Nine.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Nine.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Nine);
            }

            else if (Nine.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Nine.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Nine);
            }
        }

        private void Btn_c2r1TwoP_Click(object sender, EventArgs e)
        {//Cell Ten
            if (Ten.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Ten.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Ten);
            }

            else if (Ten.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Ten.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Ten);
            }
        }

        private void Btn_c3r1TwoP_Click(object sender, EventArgs e)
        {//Cell Eleven
            if (Eleven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Eleven.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Eleven);
            }

            else if (Eleven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Eleven.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Eleven);
            }
        }

        private void Btn_c4r1TwoP_Click(object sender, EventArgs e)
        {//Cell Twelve
            if (Twelve.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Twelve.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Twelve);
            }

            else if (Twelve.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Twelve.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Twelve);
            }
        }

        private void Btn_c5r1TwoP_Click(object sender, EventArgs e)
        {//Cell Thirteen
            if (Thirteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Thirteen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Thirteen);
            }

            else if (Thirteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Thirteen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Thirteen);
            }
        }

        private void Btn_c6r1TwoP_Click(object sender, EventArgs e)
        {//Cell Fourteen
            if (Fourteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Fourteen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Fourteen);
            }

            else if (Fourteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Fourteen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Fourteen);
            }
        }

        private void Btn_c0r2TwoP_Click(object sender, EventArgs e)
        {//Cell Fifteen
            if (Fifteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Fifteen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Fifteen);
            }

            else if (Fifteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Fifteen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Fifteen);
            }
        }

        private void Btn_c1r2TwoP_Click(object sender, EventArgs e)
        {//Cell Sixteen
            if (Sixteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Sixteen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Sixteen);
            }

            else if (Sixteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Sixteen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Sixteen);
            }
        }

        private void Btn_c2r2TwoP_Click(object sender, EventArgs e)
        {//Cell Seventeen
            if (Seventeen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Seventeen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Seventeen);
            }

            else if (Seventeen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Seventeen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Seventeen);
            }
        }

        private void Btn_c3r2TwoP_Click(object sender, EventArgs e)
        {//Cell Eighteen
            if (Eighteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Eighteen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Eighteen);
            }

            else if (Eighteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Eighteen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Eighteen);
            }
        }

        private void Btn_c4r2TwoP_Click(object sender, EventArgs e)
        {//Cell Nineteen
            if (Nineteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Nineteen.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Nineteen);
            }

            else if (Nineteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Nineteen.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Nineteen);
            }
        }

        private void Btn_c5r2TwoP_Click(object sender, EventArgs e)
        {//Cell Twenty
            if (Twenty.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Twenty.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Twenty);
            }

            else if (Twenty.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Twenty.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Twenty);
            }
        }

        private void Btn_c6r2TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyOne
            if (TwentyOne.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyOne.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyOne);
            }

            else if (TwentyOne.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyOne.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyOne);
            }
        }

        private void Btn_c0r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyTwo
            if (TwentyTwo.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyTwo.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyTwo);
            }

            else if (TwentyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyTwo.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyTwo);
            }
        }

        private void Btn_c1r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyThree
            if (TwentyThree.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyThree.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyThree);
            }

            else if (TwentyThree.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyThree.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyThree);
            }
        }

        private void Btn_c2r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyFour
            if (TwentyFour.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyFour.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyFour);
            }

            else if (TwentyFour.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyFour.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyFour);
            }
        }

        private void Btn_c3r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyFive
            if (TwentyFive.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyFive.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyFive);
            }

            else if (TwentyFive.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyFive.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyFive);
            }
        }

        private void Btn_c4r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentySix
            if (TwentySix.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentySix.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentySix);
            }

            else if (TwentySix.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentySix.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentySix);
            }
        }

        private void Btn_c5r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentySeven
            if (TwentySeven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentySeven.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentySeven);
            }

            else if (TwentySeven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentySeven.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentySeven);
            }
        }

        private void Btn_c6r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyEight
            if (TwentyEight.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyEight.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyEight);
            }

            else if (TwentyEight.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyEight.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyEight);
            }
        }

        private void Btn_c0r4TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyNine
            if (TwentyNine.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                TwentyNine.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(TwentyNine);
            }

            else if (TwentyNine.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                TwentyNine.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(TwentyNine);
            }
        }

        private void Btn_c1r4TwoP_Click(object sender, EventArgs e)
        {//Cell Thirty
            if (Thirty.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Thirty.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Thirty);
            }

            else if (Thirty.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Thirty.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Thirty);
            }
        }

        private void Btn_c2r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyOne
            if (ThirtyOne.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyOne.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyOne);
            }

            else if (ThirtyOne.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyOne.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyOne);
            }
        }

        private void Btn_c3r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyTwo
            if (ThirtyTwo.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyTwo.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyTwo);
            }

            else if (ThirtyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyTwo.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyTwo);
            }
        }

        private void Btn_c4r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyThree
            if (ThirtyThree.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyThree.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyThree);
            }

            else if (ThirtyThree.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyThree.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyThree);
            }
        }

        private void Btn_c5r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyFour
            if (ThirtyFour.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyFour.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyFour);
            }

            else if (ThirtyFour.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyFour.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyFour);
            }
        }

        private void Btn_c6r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyFive
            if (ThirtyFive.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyFive.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyFive);
            }

            else if (ThirtyFive.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyFive.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyFive);
            }
        }

        private void Btn_c0r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtySix
            if (ThirtySix.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtySix.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtySix);
            }

            else if (ThirtySix.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtySix.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtySix);
            }
        }

        private void Btn_c1r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtySeven
            if (ThirtySeven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtySeven.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtySeven);
            }

            else if (ThirtySeven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtySeven.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtySeven);
            }
        }

        private void Btn_c2r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyEight
            if (ThirtyEight.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyEight.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyEight);
            }

            else if (ThirtyEight.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyEight.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyEight);
            }
        }

        private void Btn_c3r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyNine
            if (ThirtyNine.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                ThirtyNine.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(ThirtyNine);
            }

            else if (ThirtyNine.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                ThirtyNine.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(ThirtyNine);
            }
        }

        private void Btn_c4r5TwoP_Click(object sender, EventArgs e)
        {//Cell Fourty
            if (Fourty.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                Fourty.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(Fourty);
            }

            else if (Fourty.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                Fourty.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(Fourty);
            }
        }

        private void Btn_c5r5TwoP_Click(object sender, EventArgs e)
        {//Cell FourtyOne
            if (FourtyOne.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                FourtyOne.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(FourtyOne);
            }

            else if (FourtyOne.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                FourtyOne.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(FourtyOne);
            }
        }

        private void Btn_c6r5TwoP_Click(object sender, EventArgs e)
        {//Cell FourtyTwo
            if (FourtyTwo.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                FourtyTwo.setPlayerOne();
                twoPlayerBoard.setGameBoardCell(FourtyTwo);
            }

            else if (FourtyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                FourtyTwo.setPlayerTwo();
                twoPlayerBoard.setGameBoardCell(FourtyTwo);
            }
        }
        
        
    }    
    
}
