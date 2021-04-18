using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIS153FinalProject
{
    public partial class Statistics : Form
    {
        private new WelcomeForm Menu;
        private string playerwins;
        private string aiwins;
        private string tie;
        private string totalplayed;
        private string playerpercent;
        private string aipercent;

        List<playerstats> listofplayerstats = new List<playerstats>();

        public Statistics()
        {
            InitializeComponent();

            playerstats user1 = new playerstats();
            user1.setPlayerwins("");
            user1.setAiwins("");
            user1.setTie("");
            user1.setTotalplayed("");
            user1.setPlayerpercent("");
            user1.setAipercent("");

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

        private void Button_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

       

        private void Statistics_Load(object sender, EventArgs e)
        {
            StreamReader inputfile = new StreamReader("C:\\Users\\FleaF\\Documents\\GitHub\\CIS153FinalProject\\CIS153FinalProject");
            string text = " ";
            string line;
            line = inputfile.ReadLine();
            while (line !=null)
            {
                text = text + line + "\n";
                line = inputfile.ReadLine();

            }
            txt_stats.Text = text;
            inputfile.Close();


        }

        private void txt_stats_TextChanged(object sender, EventArgs e)
        {
            string text = "";
            StreamWriter sw = new StreamWriter("C:\\Users\\FleaF\\Documents\\GitHub\\CIS153FinalProject\\CIS153FinalProject");
            playerstats user1 = new playerstats();
            user1.setPlayerwins(playerwins);
            user1.setAiwins(aiwins);
            user1.setTie(tie);
            user1.setTotalplayed(totalplayed);
            user1.setPlayerpercent(playerpercent);
            user1.setAipercent(aipercent);
            if (user1.getPlayerwins().Length > 0)
            {
                if (user1.getAiwins().Length > 0)
                {
                    if (user1.getTie().Length > 0)
                    {

                        if (user1.getTotalplayed().Length > 0)
                        {

                            if (user1.getPlayerpercent().Length > 0)
                            {
                                if (user1.getAipercent().Length > 0)
                                {
                                    listofplayerstats.Add(user1);

                                    for (int i = 0; i < listofplayerstats.Count(); i++)
                                    {
                                        txt_stats.Text = "";
                                        text = text + "Player Wins: " + listofplayerstats[i].getPlayerwins() + Environment.NewLine + "Ai wins: " + listofplayerstats[i].getAiwins() + Environment.NewLine + "Tie: " + listofplayerstats[i].getTie()
                                         + Environment.NewLine + "Total games played: " + listofplayerstats[i].getTotalplayed() + Environment.NewLine + "Player percentage: " + listofplayerstats[i].getPlayerpercent() + Environment.NewLine + "Ai percentage: " + listofplayerstats[i].getAipercent();

                                        txt_stats.Text = text;


                                    }


                                }







                            }

                        }

                    }

                }

            }


            sw.WriteLine(text);
            sw.Close();



        }
    }
}
