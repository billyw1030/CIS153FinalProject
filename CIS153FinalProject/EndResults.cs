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
    public partial class EndResults : Form
    {
        //This form will say who won, show the players statistics against the computer, 
        //have an action to play again, have an action to review the game, and have an action to exit.  
        //Play again will close the current form stating who has won and open a new game board form.  
        //Review the game will allow them to see who won and how they won.
        //private new WelcomeForm mainMenu;

        public SinglePlayer RefToSinglePlayer { get; set; }
        public TwoPlayer RefToTwoPlayer { get; set; }
        //This is new to me and I'm experimenting with this {get; set;} thing -- Billy
        private int gamemode;

        public EndResults(string results, int playedBoard, int winner)
        {
            InitializeComponent();
            Lbl_Results.Text = results;
            gamemode = playedBoard;
            //mainMenu = menu;

            if(gamemode == 1)
            {
                btn_reviewSinglePlayer.Visible = true;
                lbx_SinglePlayerEnd.Visible = true;
                //if (winner == 1)
                //{
                //    Lbl_Results.ForeColor = this.RefToSinglePlayer.getPlayerOneColor();
                //}
                //else if (winner == 2)
                //{
                //    Lbl_Results.ForeColor = this.RefToSinglePlayer.getPlayerTwoColor();
                //}
                //else
                //{
                //    Lbl_Results.ForeColor = Color.Black;
                //}
                //this.RefToSinglePlayer.Hide();
            }
            else
            {
                btn_reviewSinglePlayer.Visible = false;
                lbx_SinglePlayerEnd.Visible = false;
            }

            if(gamemode == 2)
            {
                btn_reviewTwoPlayer.Visible = true;
                //if (winner == 1)
                //{
                //    Lbl_Results.ForeColor = RefToTwoPlayer.getPlayerOneColor();
                //}
                //else if(winner == 2)
                //{
                //    Lbl_Results.ForeColor = RefToTwoPlayer.getPlayerTwoColor();
                //}
                //else
                //{
                //    Lbl_Results.ForeColor = Color.Black;
                //}
                //this.RefToTwoPlayer.Hide();
            }
            else
            {
                btn_reviewTwoPlayer.Visible = false;
            }
        }

        private void EndResults_Load(object sender, EventArgs e)
        {

        }

        private void btn_reviewSinglePlayer_Click(object sender, EventArgs e)
        {
            this.RefToSinglePlayer.Show();
            this.Close();
        }

        private void btn_reviewTwoPlayer_Click(object sender, EventArgs e)
        {
            this.RefToTwoPlayer.Show();
            this.Close();
            //Console.WriteLine("we made it");
        }

        private void btn_MainMenuEnd_Click(object sender, EventArgs e)
        {
            //Menu.Show();
            //this.RefToTwoPlayer.Menu.Show();
            this.RefToTwoPlayer.getMenu().Show();
            this.Close();
        }

        private void btn_CloseEnd_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            if(gamemode == 1)
            {
                //SinglePlayer formToLoad = new TwoPlayer(this.RefToSinglePlayer.getMenu());

                //formToLoad.Show();
                //this.Hide();
            }
            else if(gamemode == 2)
            {
                TwoPlayer formToLoad = new TwoPlayer(this.RefToTwoPlayer.getMenu());

                formToLoad.Show();
                this.Hide();
            }
        }
    }
}
