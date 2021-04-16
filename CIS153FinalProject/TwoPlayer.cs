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
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;                
            }
        }

        private void Btn_c1r0TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r0TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r0TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r0TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r0TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r0TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r0TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r0TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r1TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r1TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r1TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r2TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r2TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r2TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r3TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r3TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r3TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r4TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r4TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r4TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c0r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c1r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c2r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c3r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c4r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c5r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }

        private void Btn_c6r5TwoP_Click(object sender, EventArgs e)
        {
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r5TwoP.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r5TwoP.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
            }
        }
        
        
    }    
    
}
