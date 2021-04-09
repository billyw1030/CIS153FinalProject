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
    public partial class Statistics : Form
    {
        private new WelcomeForm Menu;
        public Statistics()
        {
            InitializeComponent();
        }


        public Statistics(WelcomeForm main)
        {
            InitializeComponent();
            Menu = main;
        }
        public void FormPassedToMeFour(WelcomeForm mainMenu)
        {
            Menu = mainMenu;
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            this.Close();
        }
    }
}
