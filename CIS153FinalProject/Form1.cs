//======================================================================================================================================
//======================================================================================================================================
//======================================================================================================================================

//------------------------------------------------------CONNECT----FOUR-----------------------------------------------------------------

//Names: Tanner, Billy, Shane, Jeremy

//Date: 4/30/2021

//Description: This is our final for CIS 153. This is a connect four game that works with one player vs
//       AI and two players. The statistics for one player are kept. When there is a winner the results are
//       displayed in an endgame form and you can play again or review the board. Have fun.

//======================================================================================================================================
//======================================================================================================================================
//======================================================================================================================================

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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_SinglePlayer_Click(object sender, EventArgs e)
        {//Single player game
            loadSinglePlayerForm();
        }

        private void btn_TwoPlayer_Click(object sender, EventArgs e)
        {//Two player game
            loadTwoPlayerForm();
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {//Stats page
            loadStatisticsForm();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {//exit game
            Application.Exit();
        }


        private void loadSinglePlayerForm()
        {
            SinglePlayer formToLoad = new SinglePlayer(this);

            formToLoad.Show();
            this.Hide();
        }

        private void loadTwoPlayerForm()
        {
            TwoPlayer formToLoad = new TwoPlayer(this);

            formToLoad.Show();
            this.Hide();
        }

        private void loadStatisticsForm()
        {
            Statistics formToLoad = new Statistics(this);
            Statistics formToLoadNoOverload = new Statistics();

            formToLoadNoOverload.FormPassedToMeFour(this);

            formToLoad.Show();
            this.Hide();

        }

        private void lbl_ConnectFour_Click(object sender, EventArgs e)
        {

        }
    }
}
