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
    }
}
