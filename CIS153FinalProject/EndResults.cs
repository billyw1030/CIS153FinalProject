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

        public EndResults(string results)
        {
            InitializeComponent();
            Lbl_Results.Text = results;
        }

        private void EndResults_Load(object sender, EventArgs e)
        {

        }
    }
}
