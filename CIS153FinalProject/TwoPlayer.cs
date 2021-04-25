using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ePOSOne.btnProduct;

namespace CIS153FinalProject
{
    public partial class TwoPlayer : Form
    {
        private new WelcomeForm Menu;
        private Board twoPlayerBoard = new Board();

        private bool PlayerOneTurn = true;
        private bool PlayerTwoTurn = false;
        private bool PlayerOneWins = false;
        private bool PlayerTwoWins = false;
        private static Color PlayerOneColor = Color.Yellow;
        private static Color PlayerTwoColor = Color.Red;
        private Cell dropCell = new Cell();


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

        public TwoPlayer()
        {
            InitializeComponent();
        }
        
        public TwoPlayer(WelcomeForm main)
        {
            InitializeComponent();
            Menu = main;

             One = new Cell(0, 0, Btn_c0r0TwoP);
             Two = new Cell(0, 1, Btn_c1r0TwoP);
             Three = new Cell(0, 2, Btn_c2r0TwoP);
             Four = new Cell(0, 3, Btn_c3r0TwoP);
             Five = new Cell(0, 4, Btn_c4r0TwoP);
             Six = new Cell(0, 5, Btn_c5r0TwoP);
             Seven = new Cell(0, 6, Btn_c6r0TwoP);
             Eight = new Cell(1, 0, Btn_c0r1TwoP);
             Nine = new Cell(1, 1, Btn_c1r1TwoP);
             Ten = new Cell(1, 2, Btn_c2r1TwoP);
             Eleven = new Cell(1, 3, Btn_c3r1TwoP);
             Twelve = new Cell(1, 4, Btn_c4r1TwoP);
             Thirteen = new Cell(1, 4, Btn_c5r1TwoP);
             Fourteen = new Cell(1, 6, Btn_c6r1TwoP);
             Fifteen = new Cell(2, 0, Btn_c0r2TwoP);
             Sixteen = new Cell(2, 1, Btn_c1r2TwoP);
             Seventeen = new Cell(2, 2, Btn_c2r2TwoP);
             Eighteen = new Cell(2, 3, Btn_c3r2TwoP);
             Nineteen = new Cell(2, 4, Btn_c4r2TwoP);
             Twenty = new Cell(2, 5, Btn_c5r2TwoP);
             TwentyOne = new Cell(2, 6, Btn_c6r2TwoP);
             TwentyTwo = new Cell(3, 0, Btn_c0r3TwoP);
             TwentyThree = new Cell(3, 1, Btn_c1r3TwoP);
             TwentyFour = new Cell(3, 2, Btn_c2r3TwoP);
             TwentyFive = new Cell(3, 3, Btn_c3r3TwoP);
             TwentySix = new Cell(3, 4, Btn_c4r3TwoP);
             TwentySeven = new Cell(3, 5, Btn_c5r3TwoP);
             TwentyEight = new Cell(3, 6, Btn_c6r3TwoP);
             TwentyNine = new Cell(4, 0, Btn_c0r4TwoP);
             Thirty = new Cell(4, 1, Btn_c1r4TwoP);
             ThirtyOne = new Cell(4, 2, Btn_c2r4TwoP);
             ThirtyTwo = new Cell(4, 3, Btn_c3r4TwoP);
             ThirtyThree = new Cell(4, 4, Btn_c4r4TwoP);
             ThirtyFour = new Cell(4, 5, Btn_c5r4TwoP);
             ThirtyFive = new Cell(4, 6, Btn_c6r4TwoP);
             ThirtySix = new Cell(5, 0, Btn_c0r5TwoP);
             ThirtySeven = new Cell(5, 1, Btn_c1r5TwoP);
             ThirtyEight = new Cell(5, 2, Btn_c2r5TwoP);
             ThirtyNine = new Cell(5, 3, Btn_c3r5TwoP);
             Fourty = new Cell(5, 4, Btn_c4r5TwoP);
             FourtyOne = new Cell(5, 5, Btn_c5r5TwoP);
             FourtyTwo = new Cell(5, 6, Btn_c6r5TwoP);
        }

        public void FormPassedToMeThree(WelcomeForm mainMenu)
        {
            Menu = mainMenu;
        }

        private void Btn_exitTwoPlayer_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }

        private void TwoPlayer_Load(object sender, EventArgs e)
        {
            lbl_playerTurnOne.ForeColor = PlayerOneColor;
            lbl_playerTurnTwo.ForeColor = PlayerTwoColor;
            Btn_P1Color.FlatAppearance.BorderColor = PlayerOneColor;
            Btn_P2Color.FlatAppearance.BorderColor = PlayerTwoColor;

            twoPlayerBoard.SetGameBoardCell(One);
            twoPlayerBoard.SetGameBoardCell(Two);
            twoPlayerBoard.SetGameBoardCell(Three);
            twoPlayerBoard.SetGameBoardCell(Four);
            twoPlayerBoard.SetGameBoardCell(Five);
            twoPlayerBoard.SetGameBoardCell(Six);
            twoPlayerBoard.SetGameBoardCell(Seven);
            twoPlayerBoard.SetGameBoardCell(Eight);
            twoPlayerBoard.SetGameBoardCell(Nine);
            twoPlayerBoard.SetGameBoardCell(Ten);
            twoPlayerBoard.SetGameBoardCell(Eleven);
            twoPlayerBoard.SetGameBoardCell(Twelve);
            twoPlayerBoard.SetGameBoardCell(Thirteen);
            twoPlayerBoard.SetGameBoardCell(Fourteen);
            twoPlayerBoard.SetGameBoardCell(Fifteen);
            twoPlayerBoard.SetGameBoardCell(Sixteen);
            twoPlayerBoard.SetGameBoardCell(Seventeen);
            twoPlayerBoard.SetGameBoardCell(Eighteen);
            twoPlayerBoard.SetGameBoardCell(Nineteen);
            twoPlayerBoard.SetGameBoardCell(Twenty);
            twoPlayerBoard.SetGameBoardCell(TwentyOne);
            twoPlayerBoard.SetGameBoardCell(TwentyTwo);
            twoPlayerBoard.SetGameBoardCell(TwentyThree);
            twoPlayerBoard.SetGameBoardCell(TwentyFour);
            twoPlayerBoard.SetGameBoardCell(TwentyFive);
            twoPlayerBoard.SetGameBoardCell(TwentySix);
            twoPlayerBoard.SetGameBoardCell(TwentySeven);
            twoPlayerBoard.SetGameBoardCell(TwentyEight);
            twoPlayerBoard.SetGameBoardCell(TwentyNine);
            twoPlayerBoard.SetGameBoardCell(Thirty);
            twoPlayerBoard.SetGameBoardCell(ThirtyOne);
            twoPlayerBoard.SetGameBoardCell(ThirtyTwo);
            twoPlayerBoard.SetGameBoardCell(ThirtyThree);
            twoPlayerBoard.SetGameBoardCell(ThirtyFour);
            twoPlayerBoard.SetGameBoardCell(ThirtyFive);
            twoPlayerBoard.SetGameBoardCell(ThirtySix);
            twoPlayerBoard.SetGameBoardCell(ThirtySeven);
            twoPlayerBoard.SetGameBoardCell(ThirtyEight);
            twoPlayerBoard.SetGameBoardCell(ThirtyNine);
            twoPlayerBoard.SetGameBoardCell(Fourty);
            twoPlayerBoard.SetGameBoardCell(FourtyOne);
            twoPlayerBoard.SetGameBoardCell(FourtyTwo);


            One.SetCellBelow(Eight);
            Two.SetCellBelow(Nine);
            Three.SetCellBelow(Ten);
            Four.SetCellBelow(Eleven);
            Five.SetCellBelow(Twelve);
            Six.SetCellBelow(Thirteen);
            Seven.SetCellBelow(Fourteen);
            Eight.SetCellBelow(Fifteen);
            Nine.SetCellBelow(Sixteen);
            Ten.SetCellBelow(Seventeen);
            Eleven.SetCellBelow(Eighteen);
            Twelve.SetCellBelow(Nineteen);
            Thirteen.SetCellBelow(Twenty);
            Fourteen.SetCellBelow(TwentyOne);
            Fifteen.SetCellBelow(TwentyTwo);
            Sixteen.SetCellBelow(TwentyThree);
            Seventeen.SetCellBelow(TwentyFour);
            Eighteen.SetCellBelow(TwentyFive);
            Nineteen.SetCellBelow(TwentySix);
            Twenty.SetCellBelow(TwentySeven);
            TwentyOne.SetCellBelow(TwentyEight);
            TwentyTwo.SetCellBelow(TwentyNine);
            TwentyThree.SetCellBelow(Thirty);
            TwentyFour.SetCellBelow(ThirtyOne);
            TwentyFive.SetCellBelow(ThirtyTwo);
            TwentySix.SetCellBelow(ThirtyThree);
            TwentySeven.SetCellBelow(ThirtyFour);
            TwentyEight.SetCellBelow(ThirtyFive);
            TwentyNine.SetCellBelow(ThirtySix);
            Thirty.SetCellBelow(ThirtySeven);
            ThirtyOne.SetCellBelow(ThirtyEight);
            ThirtyTwo.SetCellBelow(ThirtyNine);
            ThirtyThree.SetCellBelow(Fourty);
            ThirtyFour.SetCellBelow(FourtyOne);
            ThirtyFive.SetCellBelow(FourtyTwo);
        }

        public void GameIsOver()
        {
            Btn_c0r0TwoP.Enabled = false;
            Btn_c1r0TwoP.Enabled = false;
            Btn_c2r0TwoP.Enabled = false;
            Btn_c3r0TwoP.Enabled = false;
            Btn_c4r0TwoP.Enabled = false;
            Btn_c5r0TwoP.Enabled = false;
            Btn_c6r0TwoP.Enabled = false;
            Btn_c0r1TwoP.Enabled = false;
            Btn_c1r1TwoP.Enabled = false;
            Btn_c2r1TwoP.Enabled = false;
            Btn_c3r1TwoP.Enabled = false;
            Btn_c4r1TwoP.Enabled = false;
            Btn_c5r1TwoP.Enabled = false;
            Btn_c6r1TwoP.Enabled = false;
            Btn_c0r2TwoP.Enabled = false;
            Btn_c1r2TwoP.Enabled = false;
            Btn_c2r2TwoP.Enabled = false;
            Btn_c3r2TwoP.Enabled = false;
            Btn_c4r2TwoP.Enabled = false;
            Btn_c5r2TwoP.Enabled = false;
            Btn_c6r2TwoP.Enabled = false;
            Btn_c0r3TwoP.Enabled = false;
            Btn_c1r3TwoP.Enabled = false;
            Btn_c2r3TwoP.Enabled = false;
            Btn_c3r3TwoP.Enabled = false;
            Btn_c4r3TwoP.Enabled = false;
            Btn_c5r3TwoP.Enabled = false;
            Btn_c6r3TwoP.Enabled = false;
            Btn_c0r4TwoP.Enabled = false;
            Btn_c1r4TwoP.Enabled = false;
            Btn_c2r4TwoP.Enabled = false;
            Btn_c3r4TwoP.Enabled = false;
            Btn_c4r4TwoP.Enabled = false;
            Btn_c5r4TwoP.Enabled = false;
            Btn_c6r4TwoP.Enabled = false;
            Btn_c0r5TwoP.Enabled = false;
            Btn_c1r5TwoP.Enabled = false;
            Btn_c2r5TwoP.Enabled = false;
            Btn_c3r5TwoP.Enabled = false;
            Btn_c4r5TwoP.Enabled = false;
            Btn_c5r5TwoP.Enabled = false;
            Btn_c6r5TwoP.Enabled = false;
        }

        private void EndGame()
        {
        
            //Horizontal Posibilities for Player One

            if(One.GetFill() == 1 && Two.GetFill() == 1 && Three.GetFill() == 1 && Four.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Two.GetFill() == 1 && Three.GetFill() == 1 && Four.GetFill() == 1 && Five.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Three.GetFill() == 1 && Four.GetFill() == 1 && Five.GetFill() == 1 && Six.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Four.GetFill() == 1 && Five.GetFill() == 1 && Six.GetFill() == 1 && Seven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eight.GetFill() == 1 && Nine.GetFill() == 1 && Ten.GetFill() == 1 && Eleven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Nine.GetFill() == 1 && Ten.GetFill() == 1 && Eleven.GetFill() == 1 && Twelve.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Ten.GetFill() == 1 && Eleven.GetFill() == 1 && Twelve.GetFill() == 1 && Thirteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eleven.GetFill() == 1 && Twelve.GetFill() == 1 && Thirteen.GetFill() == 1 && Fourteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Fifteen.GetFill() == 1 && Sixteen.GetFill() == 1 && Seventeen.GetFill() == 1 && Eighteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Sixteen.GetFill() == 1 && Seventeen.GetFill() == 1 && Eighteen.GetFill() == 1 && Nineteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Seventeen.GetFill() == 1 && Eighteen.GetFill() == 1 && Nineteen.GetFill() == 1 && Twenty.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eighteen.GetFill() == 1 && Nineteen.GetFill() == 1 && Twenty.GetFill() == 1 && TwentyOne.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyTwo.GetFill() == 1 && TwentyThree.GetFill() == 1 && TwentyFour.GetFill() == 1 && TwentyFive.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyThree.GetFill() == 1 && TwentyFour.GetFill() == 1 && TwentyFive.GetFill() == 1 && TwentySix.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyFour.GetFill() == 1 && TwentyFive.GetFill() == 1 && TwentySix.GetFill() == 1 && TwentySeven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyFive.GetFill() == 1 && TwentySix.GetFill() == 1 && TwentySeven.GetFill() == 1 && TwentyEight.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyNine.GetFill() == 1 && Thirty.GetFill() == 1 && ThirtyOne.GetFill() == 1 && ThirtyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Thirty.GetFill() == 1 && ThirtyOne.GetFill() == 1 && ThirtyTwo.GetFill() == 1 && ThirtyThree.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyOne.GetFill() == 1 && ThirtyTwo.GetFill() == 1 && ThirtyThree.GetFill() == 1 && ThirtyFour.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyTwo.GetFill() == 1 && ThirtyThree.GetFill() == 1 && ThirtyFour.GetFill() == 1 && ThirtyFive.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtySix.GetFill() == 1 && ThirtySeven.GetFill() == 1 && ThirtyEight.GetFill() == 1 && ThirtyNine.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtySeven.GetFill() == 1 && ThirtyEight.GetFill() == 1 && ThirtyNine.GetFill() == 1 && Fourty.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyEight.GetFill() == 1 && ThirtyNine.GetFill() == 1 && Fourty.GetFill() == 1 && FourtyOne.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyNine.GetFill() == 1 && Fourty.GetFill() == 1 && FourtyOne.GetFill() == 1 && FourtyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            //Vertical Posibilities for Player One

            if (One.GetFill() == 1 && Eight.GetFill() == 1 && Fifteen.GetFill() == 1 && TwentyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eight.GetFill() == 1 && Fifteen.GetFill() == 1 && TwentyTwo.GetFill() == 1 && TwentyNine.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Fifteen.GetFill() == 1 && TwentyTwo.GetFill() == 1 && TwentyNine.GetFill() == 1 && ThirtySix.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Two.GetFill() == 1 && Nine.GetFill() == 1 && Sixteen.GetFill() == 1 && TwentyThree.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Nine.GetFill() == 1 && Sixteen.GetFill() == 1 && TwentyThree.GetFill() == 1 && Thirty.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Sixteen.GetFill() == 1 && TwentyThree.GetFill() == 1 && Thirty.GetFill() == 1 && ThirtySeven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Three.GetFill() == 1 && Ten.GetFill() == 1 && Seventeen.GetFill() == 1 && TwentyFour.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Ten.GetFill() == 1 && Seventeen.GetFill() == 1 && TwentyFour.GetFill() == 1 && ThirtyOne.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Seventeen.GetFill() == 1 && TwentyFour.GetFill() == 1 && ThirtyOne.GetFill() == 1 && ThirtyEight.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Four.GetFill() == 1 && Eleven.GetFill() == 1 && Eighteen.GetFill() == 1 && TwentyFive.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eleven.GetFill() == 1 && Eighteen.GetFill() == 1 && TwentyFive.GetFill() == 1 && ThirtyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eighteen.GetFill() == 1 && TwentyFive.GetFill() == 1 && ThirtyTwo.GetFill() == 1 && ThirtyNine.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Five.GetFill() == 1 && Twelve.GetFill() == 1 && Nineteen.GetFill() == 1 && TwentySix.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Twelve.GetFill() == 1 && Nineteen.GetFill() == 1 && TwentySix.GetFill() == 1 && ThirtyThree.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Nineteen.GetFill() == 1 && TwentySix.GetFill() == 1 && ThirtyThree.GetFill() == 1 && Fourty.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Six.GetFill() == 1 && Thirteen.GetFill() == 1 && Twenty.GetFill() == 1 && TwentySeven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Thirteen.GetFill() == 1 && Twenty.GetFill() == 1 && TwentySeven.GetFill() == 1 && ThirtyFour.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Twenty.GetFill() == 1 && TwentySeven.GetFill() == 1 && ThirtyFour.GetFill() == 1 && FourtyOne.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Seven.GetFill() == 1 && Fourteen.GetFill() == 1 && TwentyOne.GetFill() == 1 && TwentyEight.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Fourteen.GetFill() == 1 && TwentyOne.GetFill() == 1 && TwentyEight.GetFill() == 1 && ThirtyFive.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyOne.GetFill() == 1 && TwentyEight.GetFill() == 1 && ThirtyFive.GetFill() == 1 && FourtyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            //Diagonal Posibilities for Player One

            //Diagonal TopLeft to Bottom Right
            if (One.GetFill() == 1 && Nine.GetFill() == 1 && Seventeen.GetFill() == 1 && TwentyFive.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eight.GetFill() == 1 && Sixteen.GetFill() == 1 && TwentyFour.GetFill() == 1 && ThirtyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Fifteen.GetFill() == 1 && TwentyThree.GetFill() == 1 && ThirtyOne.GetFill() == 1 && ThirtyNine.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Two.GetFill() == 1 && Ten.GetFill() == 1 && Eighteen.GetFill() == 1 && TwentySix.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Nine.GetFill() == 1 && Seventeen.GetFill() == 1 && TwentyFive.GetFill() == 1 && ThirtyThree.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Sixteen.GetFill() == 1 && TwentyFour.GetFill() == 1 && ThirtyTwo.GetFill() == 1 && Fourty.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Three.GetFill() == 1 && Eleven.GetFill() == 1 && Nineteen.GetFill() == 1 && TwentySeven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Ten.GetFill() == 1 && Eighteen.GetFill() == 1 && TwentySix.GetFill() == 1 && ThirtyFour.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Seventeen.GetFill() == 1 && TwentyFive.GetFill() == 1 && ThirtyThree.GetFill() == 1 && FourtyOne.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Four.GetFill() == 1 && Twelve.GetFill() == 1 && Twenty.GetFill() == 1 && TwentyEight.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eleven.GetFill() == 1 && Nineteen.GetFill() == 1 && TwentySeven.GetFill() == 1 && ThirtyFive.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Eighteen.GetFill() == 1 && TwentySix.GetFill() == 1 && ThirtyFour.GetFill() == 1 && FourtyTwo.GetFill() == 1)
            {
                PlayerOneWins = true;
            }
            //Diagonal BottomLeft to TopRight
            if (TwentyTwo.GetFill() == 1 && Sixteen.GetFill() == 1 && Ten.GetFill() == 1 && Four.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyNine.GetFill() == 1 && TwentyThree.GetFill() == 1 && Seventeen.GetFill() == 1 && Eleven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtySix.GetFill() == 1 && Thirty.GetFill() == 1 && TwentyFour.GetFill() == 1 && Eighteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyThree.GetFill() == 1 && Seventeen.GetFill() == 1 && Eleven.GetFill() == 1 && Five.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (Thirty.GetFill() == 1 && TwentyFour.GetFill() == 1 && Eighteen.GetFill() == 1 && Twelve.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtySeven.GetFill() == 1 && ThirtyOne.GetFill() == 1 && TwentyFive.GetFill() == 1 && Nineteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyFour.GetFill() == 1 && Eighteen.GetFill() == 1 && Twelve.GetFill() == 1 && Six.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyOne.GetFill() == 1 && TwentyFive.GetFill() == 1 && Nineteen.GetFill() == 1 && Thirteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyEight.GetFill() == 1 && ThirtyTwo.GetFill() == 1 && TwentySix.GetFill() == 1 && Twenty.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (TwentyFive.GetFill() == 1 && Nineteen.GetFill() == 1 && Thirteen.GetFill() == 1 && Seven.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyTwo.GetFill() == 1 && TwentySix.GetFill() == 1 && Twenty.GetFill() == 1 && Fourteen.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            if (ThirtyNine.GetFill() == 1 && ThirtyThree.GetFill() == 1 && TwentySeven.GetFill() == 1 && TwentyOne.GetFill() == 1)
            {
                PlayerOneWins = true;
            }

            //Horizontal Posibilities for Player Two

            if (One.GetFill() == 2 && Two.GetFill() == 2 && Three.GetFill() == 2 && Four.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Two.GetFill() == 2 && Three.GetFill() == 2 && Four.GetFill() == 2 && Five.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Three.GetFill() == 2 && Four.GetFill() == 2 && Five.GetFill() == 2 && Six.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Four.GetFill() == 2 && Five.GetFill() == 2 && Six.GetFill() == 2 && Seven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eight.GetFill() == 2 && Nine.GetFill() == 2 && Ten.GetFill() == 2 && Eleven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Nine.GetFill() == 2 && Ten.GetFill() == 2 && Eleven.GetFill() == 2 && Twelve.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Ten.GetFill() == 2 && Eleven.GetFill() == 2 && Twelve.GetFill() == 2 && Thirteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eleven.GetFill() == 2 && Twelve.GetFill() == 2 && Thirteen.GetFill() == 2 && Fourteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Fifteen.GetFill() == 2 && Sixteen.GetFill() == 2 && Seventeen.GetFill() == 2 && Eighteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Sixteen.GetFill() == 2 && Seventeen.GetFill() == 2 && Eighteen.GetFill() == 2 && Nineteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Seventeen.GetFill() == 2 && Eighteen.GetFill() == 2 && Nineteen.GetFill() == 2 && Twenty.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eighteen.GetFill() == 2 && Nineteen.GetFill() == 2 && Twenty.GetFill() == 2 && TwentyOne.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyTwo.GetFill() == 2 && TwentyThree.GetFill() == 2 && TwentyFour.GetFill() == 2 && TwentyFive.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyThree.GetFill() == 2 && TwentyFour.GetFill() == 2 && TwentyFive.GetFill() == 2 && TwentySix.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyFour.GetFill() == 2 && TwentyFive.GetFill() == 2 && TwentySix.GetFill() == 2 && TwentySeven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyFive.GetFill() == 2 && TwentySix.GetFill() == 2 && TwentySeven.GetFill() == 2 && TwentyEight.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyNine.GetFill() == 2 && Thirty.GetFill() == 2 && ThirtyOne.GetFill() == 2 && ThirtyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Thirty.GetFill() == 2 && ThirtyOne.GetFill() == 2 && ThirtyTwo.GetFill() == 2 && ThirtyThree.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyOne.GetFill() == 2 && ThirtyTwo.GetFill() == 2 && ThirtyThree.GetFill() == 2 && ThirtyFour.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyTwo.GetFill() == 2 && ThirtyThree.GetFill() == 2 && ThirtyFour.GetFill() == 2 && ThirtyFive.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtySix.GetFill() == 2 && ThirtySeven.GetFill() == 2 && ThirtyEight.GetFill() == 2 && ThirtyNine.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtySeven.GetFill() == 2 && ThirtyEight.GetFill() == 2 && ThirtyNine.GetFill() == 2 && Fourty.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyEight.GetFill() == 2 && ThirtyNine.GetFill() == 2 && Fourty.GetFill() == 2 && FourtyOne.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyNine.GetFill() == 2 && Fourty.GetFill() == 2 && FourtyOne.GetFill() == 2 && FourtyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            //Vertical Posibilities for Player Two

            if (One.GetFill() == 2 && Eight.GetFill() == 2 && Fifteen.GetFill() == 2 && TwentyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eight.GetFill() == 2 && Fifteen.GetFill() == 2 && TwentyTwo.GetFill() == 2 && TwentyNine.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Fifteen.GetFill() == 2 && TwentyTwo.GetFill() == 2 && TwentyNine.GetFill() == 2 && ThirtySix.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Two.GetFill() == 2 && Nine.GetFill() == 2 && Sixteen.GetFill() == 2 && TwentyThree.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Nine.GetFill() == 2 && Sixteen.GetFill() == 2 && TwentyThree.GetFill() == 2 && Thirty.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Sixteen.GetFill() == 2 && TwentyThree.GetFill() == 2 && Thirty.GetFill() == 2 && ThirtySeven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Three.GetFill() == 2 && Ten.GetFill() == 2 && Seventeen.GetFill() == 2 && TwentyFour.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Ten.GetFill() == 2 && Seventeen.GetFill() == 2 && TwentyFour.GetFill() == 2 && ThirtyOne.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Seventeen.GetFill() == 2 && TwentyFour.GetFill() == 2 && ThirtyOne.GetFill() == 2 && ThirtyEight.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Four.GetFill() == 2 && Eleven.GetFill() == 2 && Eighteen.GetFill() == 2 && TwentyFive.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eleven.GetFill() == 2 && Eighteen.GetFill() == 2 && TwentyFive.GetFill() == 2 && ThirtyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eighteen.GetFill() == 2 && TwentyFive.GetFill() == 2 && ThirtyTwo.GetFill() == 2 && ThirtyNine.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Five.GetFill() == 2 && Twelve.GetFill() == 2 && Nineteen.GetFill() == 2 && TwentySix.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Twelve.GetFill() == 2 && Nineteen.GetFill() == 2 && TwentySix.GetFill() == 2 && ThirtyThree.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Nineteen.GetFill() == 2 && TwentySix.GetFill() == 2 && ThirtyThree.GetFill() == 2 && Fourty.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Six.GetFill() == 2 && Thirteen.GetFill() == 2 && Twenty.GetFill() == 2 && TwentySeven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Thirteen.GetFill() == 2 && Twenty.GetFill() == 2 && TwentySeven.GetFill() == 2 && ThirtyFour.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Twenty.GetFill() == 2 && TwentySeven.GetFill() == 2 && ThirtyFour.GetFill() == 2 && FourtyOne.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Seven.GetFill() == 2 && Fourteen.GetFill() == 2 && TwentyOne.GetFill() == 2 && TwentyEight.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Fourteen.GetFill() == 2 && TwentyOne.GetFill() == 2 && TwentyEight.GetFill() == 2 && ThirtyFive.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyOne.GetFill() == 2 && TwentyEight.GetFill() == 2 && ThirtyFive.GetFill() == 2 && FourtyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            //Diagonal Posibilities for Player Two

            //Diagonal TopLeft to Bottom Right
            if (One.GetFill() == 2 && Nine.GetFill() == 2 && Seventeen.GetFill() == 2 && TwentyFive.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eight.GetFill() == 2 && Sixteen.GetFill() == 2 && TwentyFour.GetFill() == 2 && ThirtyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Fifteen.GetFill() == 2 && TwentyThree.GetFill() == 2 && ThirtyOne.GetFill() == 2 && ThirtyNine.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Two.GetFill() == 2 && Ten.GetFill() == 2 && Eighteen.GetFill() == 2 && TwentySix.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Nine.GetFill() == 2 && Seventeen.GetFill() == 2 && TwentyFive.GetFill() == 2 && ThirtyThree.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Sixteen.GetFill() == 2 && TwentyFour.GetFill() == 2 && ThirtyTwo.GetFill() == 2 && Fourty.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Three.GetFill() == 2 && Eleven.GetFill() == 2 && Nineteen.GetFill() == 2 && TwentySeven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Ten.GetFill() == 2 && Eighteen.GetFill() == 2 && TwentySix.GetFill() == 2 && ThirtyFour.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Seventeen.GetFill() == 2 && TwentyFive.GetFill() == 2 && ThirtyThree.GetFill() == 2 && FourtyOne.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Four.GetFill() == 2 && Twelve.GetFill() == 2 && Twenty.GetFill() == 2 && TwentyEight.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eleven.GetFill() == 2 && Nineteen.GetFill() == 2 && TwentySeven.GetFill() == 2 && ThirtyFive.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Eighteen.GetFill() == 2 && TwentySix.GetFill() == 2 && ThirtyFour.GetFill() == 2 && FourtyTwo.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }
            //Diagonal BottomLeft to TopRight
            if (TwentyTwo.GetFill() == 2 && Sixteen.GetFill() == 2 && Ten.GetFill() == 2 && Four.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyNine.GetFill() == 2 && TwentyThree.GetFill() == 2 && Seventeen.GetFill() == 2 && Eleven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtySix.GetFill() == 2 && Thirty.GetFill() == 2 && TwentyFour.GetFill() == 2 && Eighteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyThree.GetFill() == 2 && Seventeen.GetFill() == 2 && Eleven.GetFill() == 2 && Five.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (Thirty.GetFill() == 2 && TwentyFour.GetFill() == 2 && Eighteen.GetFill() == 2 && Twelve.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtySeven.GetFill() == 2 && ThirtyOne.GetFill() == 2 && TwentyFive.GetFill() == 2 && Nineteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyFour.GetFill() == 2 && Eighteen.GetFill() == 2 && Twelve.GetFill() == 2 && Six.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyOne.GetFill() == 2 && TwentyFive.GetFill() == 2 && Nineteen.GetFill() == 2 && Thirteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyEight.GetFill() == 2 && ThirtyTwo.GetFill() == 2 && TwentySix.GetFill() == 2 && Twenty.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (TwentyFive.GetFill() == 2 && Nineteen.GetFill() == 2 && Thirteen.GetFill() == 2 && Seven.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyTwo.GetFill() == 2 && TwentySix.GetFill() == 2 && Twenty.GetFill() == 2 && Fourteen.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            if (ThirtyNine.GetFill() == 2 && ThirtyThree.GetFill() == 2 && TwentySeven.GetFill() == 2 && TwentyOne.GetFill() == 2)
            {
                PlayerTwoWins = true;
            }

            //If there is a winner or draw

            if (PlayerOneWins)
            {
                EndResults form = new EndResults("Player 1 Wins!");
                form.Show();
                GameIsOver();
            }

            if (PlayerTwoWins)
            {
                EndResults form = new EndResults("Player 2 Wins!");
                form.Show();
                GameIsOver();
            }

            if (One.GetFill() != 0 && Two.GetFill() != 0 && Three.GetFill() != 0 && Four.GetFill() != 0 && Five.GetFill() != 0 && Six.GetFill() != 0
                 && Seven.GetFill() != 0 && Eight.GetFill() != 0 && Nine.GetFill() != 0 && Ten.GetFill() != 0 && Eleven.GetFill() != 0 && Twelve.GetFill() != 0
                 && Thirteen.GetFill() != 0 && Fourteen.GetFill() != 0 && Fifteen.GetFill() != 0 && Sixteen.GetFill() != 0 && Seventeen.GetFill() != 0
                 && Eighteen.GetFill() != 0 && Nineteen.GetFill() != 0 && Twenty.GetFill() != 0 && TwentyOne.GetFill() != 0 && TwentyTwo.GetFill() != 0
                 && TwentyThree.GetFill() != 0 && TwentyFour.GetFill() != 0 && TwentyFive.GetFill() != 0 && TwentySix.GetFill() != 0 && TwentySeven.GetFill() != 0
                 && TwentyEight.GetFill() != 0 && TwentyNine.GetFill() != 0 && Thirty.GetFill() != 0 && ThirtyOne.GetFill() != 0 && ThirtyTwo.GetFill() != 0
                 && ThirtyThree.GetFill() != 0 && ThirtyFour.GetFill() != 0 && ThirtyFive.GetFill() != 0 && ThirtySix.GetFill() != 0 && ThirtySeven.GetFill() != 0
                 && ThirtyEight.GetFill() != 0 && ThirtyNine.GetFill() != 0 && Fourty.GetFill() != 0 && FourtyOne.GetFill() != 0 && FourtyTwo.GetFill() != 0)
            {
                EndResults form = new EndResults("Draw!");
                form.Show();
                GameIsOver();
            }

        }

        private Cell ChipFall(Cell cell)
        {

            if (cell.GetR() != 5)
            {

                while (cell.GetR() != 5 && cell.GetCellBelow().GetFill() == 0)
                {
                    cell = cell.GetCellBelow();
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

        private void Btn_c0r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(One);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if(cell.GetR() == 0 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c0r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(One);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c1r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Two);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 0 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c1r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Two);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c2r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Three);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 0 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c2r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Three);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c3r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Four);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 0 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c3r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Four);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c4r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Five);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 0 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c4r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Five);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c5r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Six);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 0 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c5r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Six);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c6r0TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Seven);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 0 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 0 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c6r0TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Seven);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c0r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Eight);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c0r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Eight);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c1r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Nine);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c1r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Nine);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c2r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Ten);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c2r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Ten);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c3r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Eleven);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c3r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Eleven);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c4r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Twelve);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c4r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Twelve);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c5r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Thirteen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c5r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Thirteen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c6r1TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Fourteen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 1 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 1 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c6r1TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Fourteen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c0r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Fifteen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c0r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Fifteen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c1r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Sixteen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c1r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Sixteen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c2r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Seventeen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c2r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Seventeen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c3r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Eighteen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c3r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Eighteen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c4r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Nineteen);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c4r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Nineteen);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c5r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Twenty);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c5r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Twenty);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c6r2TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyOne);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 2 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 2 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c6r2TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyOne);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c0r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyTwo);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c0r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyTwo);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c1r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyThree);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c1r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyThree);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c2r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyFour);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c2r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyFour);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c3r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyFive);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c3r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyFive);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c4r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentySix);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c4r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentySix);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c5r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentySeven);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c5r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentySeven);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c6r3TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyEight);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 3 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 3 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c6r3TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyEight);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c0r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyNine);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c0r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(TwentyNine);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c1r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Thirty);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c1r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Thirty);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c2r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyOne);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c2r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyOne);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c3r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyTwo);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c3r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyTwo);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c4r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyThree);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c4r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyThree);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c5r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyFour);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c5r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyFour);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c6r4TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyFive);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 4 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 4 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c6r4TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyFive);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c0r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtySix);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 0)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c0r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtySix);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c1r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtySeven);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 1)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c1r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtySeven);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c2r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyEight);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 2)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c2r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyEight);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c3r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyNine);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 3)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c3r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(ThirtyNine);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c4r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Fourty);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 4)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c4r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(Fourty);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c5r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(FourtyOne);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 5)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c5r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(FourtyOne);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_c6r5TwoP_MouseEnter(object sender, EventArgs e)
        {
            Cell cell = ChipFall(FourtyTwo);

            if (cell.GetFill() == 0 && PlayerOneTurn)
            {
                cell.GetButton().ButtonColor = PlayerOneColor;
                if (cell.GetR() == 5 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerOneColor;
                }
            }

            if (cell.GetFill() == 0 && PlayerTwoTurn)
            {
                cell.GetButton().ButtonColor = PlayerTwoColor;
                if (cell.GetR() == 5 && cell.GetC() == 6)
                {
                    cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
                }
            }

            if (cell.GetFill() == 1)
            {
                cell.GetButton().OnHoverButtonColor = PlayerOneColor;
            }
            if (cell.GetFill() == 2)
            {
                cell.GetButton().OnHoverButtonColor = PlayerTwoColor;
            }
        }
        private void Btn_c6r5TwoP_MouseLeave(object sender, EventArgs e)
        {
            Cell cell = ChipFall(FourtyTwo);

            if (cell.GetFill() == 0)
            {
                cell.GetButton().ButtonColor = Color.Blue;
            }
        }

        private void Btn_close2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        
        private void Btn_c0r0TwoP_Click(object sender, EventArgs e)
        {//Cell One
            if (One.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(One);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (One.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(One);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c1r0TwoP_Click(object sender, EventArgs e)
        {//Cell Two
            if (Two.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Two);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Two.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Two);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c2r0TwoP_Click(object sender, EventArgs e)
        {//Cell Three
            if (Three.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Three);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Three.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Three);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c3r0TwoP_Click(object sender, EventArgs e)
        {//Cell Four
            if (Four.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Four);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Four.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Four);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c4r0TwoP_Click(object sender, EventArgs e)
        {//Cell Five
            if (Five.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Five);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Five.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Five);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c5r0TwoP_Click(object sender, EventArgs e)
        {//Cell Six
            if (Six.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Six);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Six.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Six);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c6r0TwoP_Click(object sender, EventArgs e)
        {//Cell Seven
            if (Seven.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Seven);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Seven.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Seven);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c0r1TwoP_Click(object sender, EventArgs e)
        {//Cell Eight
            if (Eight.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Eight);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Eight.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Eight);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c1r1TwoP_Click(object sender, EventArgs e)
        {//Cell Nine
            if (Nine.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Nine);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Nine.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Nine);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c2r1TwoP_Click(object sender, EventArgs e)
        {//Cell Ten
            if (Ten.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Ten);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Ten.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Ten);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c3r1TwoP_Click(object sender, EventArgs e)
        {//Cell Eleven
            if (Eleven.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Eleven);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Eleven.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Eleven);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c4r1TwoP_Click(object sender, EventArgs e)
        {//Cell Twelve
            if (Twelve.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Twelve);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Twelve.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Twelve);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c5r1TwoP_Click(object sender, EventArgs e)
        {//Cell Thirteen
            if (Thirteen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Thirteen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Thirteen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Thirteen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c6r1TwoP_Click(object sender, EventArgs e)
        {//Cell Fourteen
            if (Fourteen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Fourteen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Fourteen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Fourteen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c0r2TwoP_Click(object sender, EventArgs e)
        {//Cell Fifteen
            if (Fifteen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Fifteen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Fifteen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Fifteen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c1r2TwoP_Click(object sender, EventArgs e)
        {//Cell Sixteen
            if (Sixteen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Sixteen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Sixteen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Sixteen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c2r2TwoP_Click(object sender, EventArgs e)
        {//Cell Seventeen
            if (Seventeen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Seventeen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Seventeen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Seventeen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c3r2TwoP_Click(object sender, EventArgs e)
        {//Cell Eighteen
            if (Eighteen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Eighteen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Eighteen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Eighteen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c4r2TwoP_Click(object sender, EventArgs e)
        {//Cell Nineteen
            if (Nineteen.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Nineteen);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Nineteen.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Nineteen);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c5r2TwoP_Click(object sender, EventArgs e)
        {//Cell Twenty
            if (Twenty.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Twenty);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Twenty.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Twenty);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c6r2TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyOne
            if (TwentyOne.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyOne);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyOne.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyOne);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c0r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyTwo
            if (TwentyTwo.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyTwo);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyTwo.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyTwo);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c1r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyThree
            if (TwentyThree.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyThree);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyThree.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyThree);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c2r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyFour
            if (TwentyFour.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyFour);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyFour.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyFour);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c3r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyFive
            if (TwentyFive.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyFive);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyFive.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyFive);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c4r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentySix
            if (TwentySix.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentySix);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentySix.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentySix);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c5r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentySeven
            if (TwentySeven.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentySeven);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentySeven.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentySeven);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c6r3TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyEight
            if (TwentyEight.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyEight);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyEight.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyEight);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c0r4TwoP_Click(object sender, EventArgs e)
        {//Cell TwentyNine
            if (TwentyNine.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(TwentyNine);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (TwentyNine.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(TwentyNine);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c1r4TwoP_Click(object sender, EventArgs e)
        {//Cell Thirty
            if (Thirty.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Thirty);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Thirty.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Thirty);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c2r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyOne
            if (ThirtyOne.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyOne);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyOne.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyOne);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c3r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyTwo
            if (ThirtyTwo.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyTwo);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyTwo.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyTwo);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c4r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyThree
            if (ThirtyThree.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyThree);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyThree.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyThree);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c5r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyFour
            if (ThirtyFour.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyFour);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyFour.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyFour);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c6r4TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyFive
            if (ThirtyFive.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyFive);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyFive.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyFive);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c0r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtySix
            if (ThirtySix.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtySix);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtySix.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtySix);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c1r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtySeven
            if (ThirtySeven.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtySeven);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtySeven.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtySeven);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c2r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyEight
            if (ThirtyEight.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyEight);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyEight.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyEight);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c3r5TwoP_Click(object sender, EventArgs e)
        {//Cell ThirtyNine
            if (ThirtyNine.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(ThirtyNine);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (ThirtyNine.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(ThirtyNine);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c4r5TwoP_Click(object sender, EventArgs e)
        {//Cell Fourty
            if (Fourty.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(Fourty);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (Fourty.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(Fourty);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c5r5TwoP_Click(object sender, EventArgs e)
        {//Cell FourtyOne
            if (FourtyOne.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(FourtyOne);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (FourtyOne.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(FourtyOne);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_c6r5TwoP_Click(object sender, EventArgs e)
        {//Cell FourtyTwo
            if (FourtyTwo.GetFill() == 0 && PlayerOneTurn)
            {
                dropCell = ChipFall(FourtyTwo);
                DeclareButton(dropCell, 1);
                dropCell.SetPlayerOne();
                PlayerOneTurn = false;
                PlayerTwoTurn = true;
                lbl_playerTurnTwo.Visible = true;
                lbl_playerTurnOne.Visible = false;
                EndGame();
            }

            else if (FourtyTwo.GetFill() == 0 && PlayerTwoTurn)
            {
                dropCell = ChipFall(FourtyTwo);
                DeclareButton(dropCell, 2);
                dropCell.SetPlayerTwo();
                PlayerTwoTurn = false;
                PlayerOneTurn = true;
                lbl_playerTurnOne.Visible = true;
                lbl_playerTurnTwo.Visible = false;
                EndGame();
            }
        }

        private void Btn_P1Color_Click(object sender, EventArgs e)
        {
            if (One.GetFill() == 0 && Two.GetFill() == 0 && Three.GetFill() == 0 && Four.GetFill() == 0 && Five.GetFill() == 0 && Six.GetFill() == 0
                 && Seven.GetFill() == 0 && Eight.GetFill() == 0 && Nine.GetFill() == 0 && Ten.GetFill() == 0 && Eleven.GetFill() == 0 && Twelve.GetFill() == 0
                 && Thirteen.GetFill() == 0 && Fourteen.GetFill() == 0 && Fifteen.GetFill() == 0 && Sixteen.GetFill() == 0 && Seventeen.GetFill() == 0
                 && Eighteen.GetFill() == 0 && Nineteen.GetFill() == 0 && Twenty.GetFill() == 0 && TwentyOne.GetFill() == 0 && TwentyTwo.GetFill() == 0
                 && TwentyThree.GetFill() == 0 && TwentyFour.GetFill() == 0 && TwentyFive.GetFill() == 0 && TwentySix.GetFill() == 0 && TwentySeven.GetFill() == 0
                 && TwentyEight.GetFill() == 0 && TwentyNine.GetFill() == 0 && Thirty.GetFill() == 0 && ThirtyOne.GetFill() == 0 && ThirtyTwo.GetFill() == 0
                 && ThirtyThree.GetFill() == 0 && ThirtyFour.GetFill() == 0 && ThirtyFive.GetFill() == 0 && ThirtySix.GetFill() == 0 && ThirtySeven.GetFill() == 0
                 && ThirtyEight.GetFill() == 0 && ThirtyNine.GetFill() == 0 && Fourty.GetFill() == 0 && FourtyOne.GetFill() == 0 && FourtyTwo.GetFill() == 0)
            {
                colorDialog1.ShowDialog();
                PlayerOneColor = colorDialog1.Color;
                Btn_P1Color.FlatAppearance.BorderColor = PlayerOneColor;
            }

            else
            {
                Lbl_ColorChangeError.Visible = true;
            }

            while (PlayerOneColor == PlayerTwoColor)
            {
                lbl_MatchError.Visible = true;
                colorDialog1.ShowDialog();
                PlayerOneColor = colorDialog1.Color;
                Btn_P1Color.FlatAppearance.BorderColor = PlayerOneColor;
                if (PlayerOneColor != PlayerTwoColor)
                {
                    lbl_MatchError.Visible = false;
                }
            }
            

            lbl_playerTurnOne.ForeColor = PlayerOneColor;
            lbl_playerTurnTwo.ForeColor = PlayerTwoColor;
        }

        private void Btn_P2Color_Click(object sender, EventArgs e)
        {
            if (One.GetFill() == 0 && Two.GetFill() == 0 && Three.GetFill() == 0 && Four.GetFill() == 0 && Five.GetFill() == 0 && Six.GetFill() == 0
                 && Seven.GetFill() == 0 && Eight.GetFill() == 0 && Nine.GetFill() == 0 && Ten.GetFill() == 0 && Eleven.GetFill() == 0 && Twelve.GetFill() == 0
                 && Thirteen.GetFill() == 0 && Fourteen.GetFill() == 0 && Fifteen.GetFill() == 0 && Sixteen.GetFill() == 0 && Seventeen.GetFill() == 0
                 && Eighteen.GetFill() == 0 && Nineteen.GetFill() == 0 && Twenty.GetFill() == 0 && TwentyOne.GetFill() == 0 && TwentyTwo.GetFill() == 0
                 && TwentyThree.GetFill() == 0 && TwentyFour.GetFill() == 0 && TwentyFive.GetFill() == 0 && TwentySix.GetFill() == 0 && TwentySeven.GetFill() == 0
                 && TwentyEight.GetFill() == 0 && TwentyNine.GetFill() == 0 && Thirty.GetFill() == 0 && ThirtyOne.GetFill() == 0 && ThirtyTwo.GetFill() == 0
                 && ThirtyThree.GetFill() == 0 && ThirtyFour.GetFill() == 0 && ThirtyFive.GetFill() == 0 && ThirtySix.GetFill() == 0 && ThirtySeven.GetFill() == 0
                 && ThirtyEight.GetFill() == 0 && ThirtyNine.GetFill() == 0 && Fourty.GetFill() == 0 && FourtyOne.GetFill() == 0 && FourtyTwo.GetFill() == 0)
            {
                colorDialog2.ShowDialog();
                PlayerTwoColor = colorDialog2.Color;
                Btn_P2Color.FlatAppearance.BorderColor = PlayerTwoColor;
            }

            else
            {
                Lbl_ColorChangeError.Visible = true;
            }

            while (PlayerTwoColor == PlayerOneColor)
            {
                lbl_MatchError.Visible = true;
                colorDialog2.ShowDialog();
                PlayerTwoColor = colorDialog2.Color;
                Btn_P2Color.FlatAppearance.BorderColor = PlayerTwoColor;
                if (PlayerTwoColor != PlayerOneColor)
                {
                    lbl_MatchError.Visible = false;
                }
            }

            lbl_playerTurnOne.ForeColor = PlayerOneColor;
            lbl_playerTurnTwo.ForeColor = PlayerTwoColor;
        }
    }    
    
}
