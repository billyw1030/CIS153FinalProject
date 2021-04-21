using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//classes might be just a set up for our boards (single player, two player, ai, no ai, etc).

namespace CIS153FinalProject
{
    public partial class SinglePlayer : Form
    {
        private new WelcomeForm Menu;
        private Board singlePlayerBoard;

        private bool PlayerOneTurn = true;
        private bool PlayerTwoTurn = false;
        private static Color PlayerOneColor = Color.FromArgb(0, 0, 50);
        private static Color PlayerTwoColor = Color.FromArgb(100, 0, 0);

        //                  r  c  f
        Cell One = new Cell(0, 0, 0);        
        //singlePlayerBoard.setGameBoardCell(Cell One);
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
        
        

        public SinglePlayer()
        {
            InitializeComponent();
            singlePlayerBoard = new Board();
            singlePlayerBoard.setGameBoardCell(One);
        }

        public SinglePlayer(WelcomeForm main)
        {
            InitializeComponent();
            Menu = main;
        }

        public void FormPassedToMeTwo(WelcomeForm mainMenu)
        {
            Menu = mainMenu;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Btn_c0r0_Click(object sender, EventArgs e)
        {//Cell One
            if (One.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (One.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }

        }

        private void Btn_c1r0_Click(object sender, EventArgs e)
        {//Cell Two
            if (Two.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Two.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c2r0_Click(object sender, EventArgs e)
        {//Cell Three
            if (Three.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Three.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c3r0_Click(object sender, EventArgs e)
        {//Cell Four
            if (Four.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Four.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c4r0_Click(object sender, EventArgs e)
        {//Cell Five
            if (Five.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Five.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c5r0_Click(object sender, EventArgs e)
        {//Cell Six
            if (Six.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Six.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c6r0_Click(object sender, EventArgs e)
        {//Cell Seven
            if (Seven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Seven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r0.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c0r1_Click(object sender, EventArgs e)
        {//Cell Eight
            if (Eight.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Eight.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c1r1_Click(object sender, EventArgs e)
        {//Cell Nine
            if (Nine.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Nine.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c2r1_Click(object sender, EventArgs e)
        {//Cell Ten
            if (Ten.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Ten.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c3r1_Click(object sender, EventArgs e)
        {//Cell Eleven
            if (Eleven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Eleven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c4r1_Click(object sender, EventArgs e)
        {//Cell Twelve
            if (Twelve.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Twelve.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c5r1_Click(object sender, EventArgs e)
        {//Cell Thirteen
            if (Thirteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Thirteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c6r1_Click(object sender, EventArgs e)
        {//Cell Fourteen
            if (Fourteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Fourteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r1.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c0r2_Click(object sender, EventArgs e)
        {//Cell Fifteen
            if (Fifteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Fifteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c1r2_Click(object sender, EventArgs e)
        {//Cell Sixteen
            if (Sixteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Sixteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c2r2_Click(object sender, EventArgs e)
        {//Cell Seventeen
            if (Seventeen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Seventeen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c3r2_Click(object sender, EventArgs e)
        {//Cell Eighteen
            if (Eighteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Eighteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c4r2_Click(object sender, EventArgs e)
        {//Cell Nineteen
            if (Nineteen.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Nineteen.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c5r2_Click(object sender, EventArgs e)
        {//Cell Twenty
            if (Twenty.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Twenty.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c6r2_Click(object sender, EventArgs e)
        {//Cell TwentyOne
            if (TwentyOne.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyOne.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r2.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c0r3_Click(object sender, EventArgs e)
        {//Cell TwentyTwo
            if (TwentyTwo.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c1r3_Click(object sender, EventArgs e)
        {//Cell TwentyThree
            if (TwentyThree.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyThree.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c2r3_Click(object sender, EventArgs e)
        {//Cell TwentyFour
            if (TwentyFour.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyFour.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c3r3_Click(object sender, EventArgs e)
        {//Cell TwentyFive
            if (TwentyFive.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyFive.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c4r3_Click(object sender, EventArgs e)
        {//Cell Twenty Six
            if (TwentySix.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentySix.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c5r3_Click(object sender, EventArgs e)
        {//Cell TwentySeven
            if (TwentySeven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentySeven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c6r3_Click(object sender, EventArgs e)
        {//Cell TwentyEight
            if (TwentyEight.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyEight.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r3.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c0r4_Click(object sender, EventArgs e)
        {//Cell TwentyNine
            if (TwentyNine.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyNine.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c1r4_Click(object sender, EventArgs e)
        {//Cell Thirty
            if (Thirty.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Thirty.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c2r4_Click(object sender, EventArgs e)
        {//Cell ThirtyOne
            if (ThirtyOne.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyOne.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c3r4_Click(object sender, EventArgs e)
        {//Cell ThirtyTwo
            if (ThirtyTwo.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c4r4_Click(object sender, EventArgs e)
        {//Cell ThirtyThree
            if (ThirtyThree.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyThree.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c5r4_Click(object sender, EventArgs e)
        {//Cell ThirtyFour
            if (ThirtyFour.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyFour.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c6r4_Click(object sender, EventArgs e)
        {//Cell ThirtyFive
            if (ThirtyFive.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyFive.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r4.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c0r5_Click(object sender, EventArgs e)
        {//Cell ThirtySix
            if (ThirtySix.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtySix.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c0r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c1r5_Click(object sender, EventArgs e)
        {//Cell ThirtySeven
            if (ThirtySeven.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtySeven.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c1r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c2r5_Click(object sender, EventArgs e)
        {//Cell ThirtyEight
            if (ThirtyEight.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyEight.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c2r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c3r5_Click(object sender, EventArgs e)
        {//Cell ThirtyNine
            if (ThirtyNine.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyNine.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c3r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c4r5_Click(object sender, EventArgs e)
        {//Cell Fourty
            if (Fourty.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Fourty.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c4r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c5r5_Click(object sender, EventArgs e)
        {//Cell FourtyOne
            if (FourtyOne.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (FourtyOne.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c5r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }

        private void Btn_c6r5_Click(object sender, EventArgs e)
        {//Cell FourtyTwo
            if (FourtyTwo.getFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (FourtyTwo.getFill() == 0 && PlayerTwoTurn)
            {
                Btn_c6r5.ButtonColor = PlayerTwoColor;
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                Lbl_PlayerTurn.Visible = true;
                lbl_PlayerTwoTurn.Visible = false;
            }
        }
    }
}
