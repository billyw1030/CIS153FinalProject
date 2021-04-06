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
        {
            loadSinglePlayerForm();
        }

        private void btn_TwoPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loadSinglePlayerForm()
        {
            SinglePlayer formToLoad = new SinglePlayer(this);
            SinglePlayer formToLoadNoOverload = new SinglePlayer();

            formToLoadNoOverload.FormPassedToMeTwo(this);

            this.BackColor = Color.White;
            formToLoad.Show();
            this.Hide();
        }
    }
}
