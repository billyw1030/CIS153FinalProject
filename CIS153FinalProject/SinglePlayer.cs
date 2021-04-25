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
        Cell One;
        Cell Two;
        Cell Three;
        Cell Four;
        Cell Five;
        Cell Six;
        Cell Seven;
        Cell Eight;
        Cell Nine;
        Cell Ten;
        Cell Eleven;
        Cell Twelve;
        Cell Thirteen;
        Cell Fourteen;
        Cell Fifteen;
        Cell Sixteen;
        Cell Seventeen;
        Cell Eighteen;
        Cell Nineteen;
        Cell Twenty;
        Cell TwentyOne;
        Cell TwentyTwo;
        Cell TwentyThree;
        Cell TwentyFour;
        Cell TwentyFive;
        Cell TwentySix;
        Cell TwentySeven;
        Cell TwentyEight;
        Cell TwentyNine;
        Cell Thirty;
        Cell ThirtyOne;
        Cell ThirtyTwo;
        Cell ThirtyThree;
        Cell ThirtyFour;
        Cell ThirtyFive;
        Cell ThirtySix;
        Cell ThirtySeven;
        Cell ThirtyEight;
        Cell ThirtyNine;
        Cell Fourty;
        Cell FourtyOne;
        Cell FourtyTwo;



        public SinglePlayer()
        {
            InitializeComponent();
            singlePlayerBoard = new Board();
            singlePlayerBoard.SetGameBoardCell(One);
        }

        public SinglePlayer(WelcomeForm main)
        {
            InitializeComponent();
            Menu = main;

            One = new Cell(0, 0, Btn_c0r0);
            Two = new Cell(0, 1, Btn_c1r0);
            Three = new Cell(0, 2, Btn_c2r0);
            Four = new Cell(0, 3, Btn_c3r0);
            Five = new Cell(0, 4, Btn_c4r0);
            Six = new Cell(0, 5, Btn_c5r0);
            Seven = new Cell(0, 6, Btn_c6r0);
            Eight = new Cell(1, 0, Btn_c0r1);
            Nine = new Cell(1, 1, Btn_c1r1);
            Ten = new Cell(1, 2, Btn_c2r1);
            Eleven = new Cell(1, 3, Btn_c3r1);
            Twelve = new Cell(1, 4, Btn_c4r1);
            Thirteen = new Cell(1, 4, Btn_c5r1);
            Fourteen = new Cell(1, 6, Btn_c6r1);
            Fifteen = new Cell(2, 0, Btn_c0r2);
            Sixteen = new Cell(2, 1, Btn_c1r2);
            Seventeen = new Cell(2, 2, Btn_c2r2);
            Eighteen = new Cell(2, 3, Btn_c3r2);
            Nineteen = new Cell(2, 4, Btn_c4r2);
            Twenty = new Cell(2, 5, Btn_c5r2);
            TwentyOne = new Cell(2, 6, Btn_c6r2);
            TwentyTwo = new Cell(3, 0, Btn_c0r3);
            TwentyThree = new Cell(3, 1, Btn_c1r3);
            TwentyFour = new Cell(3, 2, Btn_c2r3);
            TwentyFive = new Cell(3, 3, Btn_c3r3);
            TwentySix = new Cell(3, 4, Btn_c4r3);
            TwentySeven = new Cell(3, 5, Btn_c5r3);
            TwentyEight = new Cell(3, 6, Btn_c6r3);
            TwentyNine = new Cell(4, 0, Btn_c0r4);
            Thirty = new Cell(4, 1, Btn_c1r4);
            ThirtyOne = new Cell(4, 2, Btn_c2r4);
            ThirtyTwo = new Cell(4, 3, Btn_c3r4);
            ThirtyThree = new Cell(4, 4, Btn_c4r4);
            ThirtyFour = new Cell(4, 5, Btn_c5r4);
            ThirtyFive = new Cell(4, 6, Btn_c6r4);
            ThirtySix = new Cell(5, 0, Btn_c0r5);
            ThirtySeven = new Cell(5, 1, Btn_c1r5);
            ThirtyEight = new Cell(5, 2, Btn_c2r5);
            ThirtyNine = new Cell(5, 3, Btn_c3r5);
            Fourty = new Cell(5, 4, Btn_c4r5);
            FourtyOne = new Cell(5, 5, Btn_c5r5);
            FourtyTwo = new Cell(5, 6, Btn_c6r5);
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
        //   1   2   3   4   5   6   7
        //   8   9  10  11  12  13  14
        //  15  16  17  18  19  20  21
        //  22  23  24  25  26  27  28
        //  29  30  31  32  33  34  35 
        //  36  37  38  39  40  41  42

        public void GameIsOver()
        {
            Btn_c0r0.Enabled = false;
            Btn_c1r0.Enabled = false;
            Btn_c2r0.Enabled = false;
            Btn_c3r0.Enabled = false;
            Btn_c4r0.Enabled = false;
            Btn_c5r0.Enabled = false;
            Btn_c6r0.Enabled = false;
            Btn_c0r1.Enabled = false;
            Btn_c1r1.Enabled = false;
            Btn_c2r1.Enabled = false;
            Btn_c3r1.Enabled = false;
            Btn_c4r1.Enabled = false;
            Btn_c5r1.Enabled = false;
            Btn_c6r1.Enabled = false;
            Btn_c0r2.Enabled = false;
            Btn_c1r2.Enabled = false;
            Btn_c2r2.Enabled = false;
            Btn_c3r2.Enabled = false;
            Btn_c4r2.Enabled = false;
            Btn_c5r2.Enabled = false;
            Btn_c6r2.Enabled = false;
            Btn_c0r3.Enabled = false;
            Btn_c1r3.Enabled = false;
            Btn_c2r3.Enabled = false;
            Btn_c3r3.Enabled = false;
            Btn_c4r3.Enabled = false;
            Btn_c5r3.Enabled = false;
            Btn_c6r3.Enabled = false;
            Btn_c0r4.Enabled = false;
            Btn_c1r4.Enabled = false;
            Btn_c2r4.Enabled = false;
            Btn_c3r4.Enabled = false;
            Btn_c4r4.Enabled = false;
            Btn_c5r4.Enabled = false;
            Btn_c6r4.Enabled = false;
            Btn_c0r5.Enabled = false;
            Btn_c1r5.Enabled = false;
            Btn_c2r5.Enabled = false;
            Btn_c3r5.Enabled = false;
            Btn_c4r5.Enabled = false;
            Btn_c5r5.Enabled = false;
            Btn_c6r5.Enabled = false;
        }

        private void Btn_c0r0_Click(object sender, EventArgs e)
        {//Cell One
            if (One.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (One.GetFill() == 0 && PlayerTwoTurn)
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
            if (Two.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Two.GetFill() == 0 && PlayerTwoTurn)
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
            if (Three.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Three.GetFill() == 0 && PlayerTwoTurn)
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
            if (Four.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Four.GetFill() == 0 && PlayerTwoTurn)
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
            if (Five.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Five.GetFill() == 0 && PlayerTwoTurn)
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
            if (Six.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Six.GetFill() == 0 && PlayerTwoTurn)
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
            if (Seven.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r0.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Seven.GetFill() == 0 && PlayerTwoTurn)
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
            if (Eight.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Eight.GetFill() == 0 && PlayerTwoTurn)
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
            if (Nine.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Nine.GetFill() == 0 && PlayerTwoTurn)
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
            if (Ten.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Ten.GetFill() == 0 && PlayerTwoTurn)
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
            if (Eleven.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Eleven.GetFill() == 0 && PlayerTwoTurn)
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
            if (Twelve.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Twelve.GetFill() == 0 && PlayerTwoTurn)
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
            if (Thirteen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Thirteen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Fourteen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r1.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Fourteen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Fifteen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Fifteen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Sixteen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Sixteen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Seventeen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Seventeen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Eighteen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Eighteen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Nineteen.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Nineteen.GetFill() == 0 && PlayerTwoTurn)
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
            if (Twenty.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Twenty.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyOne.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r2.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyOne.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyTwo.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyTwo.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyThree.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyThree.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyFour.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyFour.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyFive.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyFive.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentySix.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentySix.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentySeven.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentySeven.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyEight.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r3.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyEight.GetFill() == 0 && PlayerTwoTurn)
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
            if (TwentyNine.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (TwentyNine.GetFill() == 0 && PlayerTwoTurn)
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
            if (Thirty.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Thirty.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyOne.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyOne.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyTwo.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyTwo.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyThree.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyThree.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyFour.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyFour.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyFive.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r4.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyFive.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtySix.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c0r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtySix.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtySeven.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c1r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtySeven.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyEight.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c2r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyEight.GetFill() == 0 && PlayerTwoTurn)
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
            if (ThirtyNine.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c3r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (ThirtyNine.GetFill() == 0 && PlayerTwoTurn)
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
            if (Fourty.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c4r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (Fourty.GetFill() == 0 && PlayerTwoTurn)
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
            if (FourtyOne.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c5r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (FourtyOne.GetFill() == 0 && PlayerTwoTurn)
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
            if (FourtyTwo.GetFill() == 0 && PlayerOneTurn)
            {
                Btn_c6r5.ButtonColor = PlayerOneColor;
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_PlayerTwoTurn.Visible = true;
                Lbl_PlayerTurn.Visible = false;
            }

            else if (FourtyTwo.GetFill() == 0 && PlayerTwoTurn)
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
