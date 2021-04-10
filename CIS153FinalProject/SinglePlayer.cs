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
        public SinglePlayer()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
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
    }
}
