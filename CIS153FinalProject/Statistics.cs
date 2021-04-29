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
        private string playerWins;
        private string aiWins;
        private string tie;
        private string totalPlayed;
        private string playerPercent;
        private string aiPercent;
        //bool srClosed = false;

        List<Playerstats> listofplayerstats = new List<Playerstats>();

        public Statistics()
        {
            InitializeComponent();

            Playerstats user1 = new Playerstats();
            user1.SetPlayerwins("");
            user1.SetAiwins("");
            user1.SetTie("");
            user1.SetTotalplayed("");
            user1.SetPlayerpercent("");
            user1.SetAipercent("");

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

        private void Btn_mainmenu_Click(object sender, EventArgs e)
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
            StreamReader inputfile = new StreamReader("../../Resources/statsfile.txt");
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            float playerPercent1 = 0.0F;
            float aiPercent1 = 0.0F;
            string text = " ";
            string line;
            line = inputfile.ReadLine();
            while (line != null)
            {

                if (line.Equals("1"))
                {
                    count1++;

                }

                if (line.Equals("2"))
                {
                    count2++;


                }
                if (line.Equals("3"))
                {
                    count3++;


                }
                if (line.Equals("4"))
                {
                    count4++;


                }

                text = text + line + "\n";
                line = inputfile.ReadLine();
                inputfile.Close();
                //srClosed = true;

            }
            playerWins = count1.ToString();
            aiWins = count2.ToString();
            tie = count3.ToString();
            totalPlayed = count4.ToString();
            playerPercent1 = ((float)count1 / (float)count4) * 100;
            aiPercent1 = ((float)count2 / (float)count4) * 100;
            playerPercent = playerPercent1.ToString("0.0") + "%";
            aiPercent = aiPercent1.ToString("0.0") + "%";
            //txt_stats.Text = text;
            inputfile.Close();
            //srClosed = true;

          
            //text is changed
            Console.WriteLine("Entered TextChanged");
            string txt = "";
            StreamWriter sw = new StreamWriter("../../Resources/statsfile.txt");
            Playerstats user1 = new Playerstats();
            user1.SetPlayerwins(playerWins);
            user1.SetAiwins(aiWins);
            user1.SetTie(tie);
            user1.SetTotalplayed(totalPlayed);
            user1.SetPlayerpercent(playerPercent);
            user1.SetAipercent(aiPercent);
            if (user1.GetPlayerwins().Length > 0 && user1.GetAiwins().Length > 0 && user1.GetTie().Length > 0 && user1.GetTotalplayed().Length > 0 && user1.GetPlayerpercent().Length > 0 && user1.GetAipercent().Length > 0)
            {
                
                listofplayerstats.Add(user1);
                
                for (int i = 0; i < listofplayerstats.Count(); i++)
                {
                    lbl_PlayerWins.Text = "Player Wins: " + listofplayerstats[i].GetPlayerwins();
                    //txt_stats.Text = "";
                    //txt = txt + "Player Wins: " + listofplayerstats[i].GetPlayerwins() + Environment.NewLine + "AI wins: " + listofplayerstats[i].GetAiwins() + Environment.NewLine + "Tie: " + listofplayerstats[i].GetTie()
                    //    + Environment.NewLine + "Total games played: " + listofplayerstats[i].GetTotalplayed() + Environment.NewLine + "Player percentage: " + listofplayerstats[i].GetPlayerpercent() + Environment.NewLine + "AI percentage: " + listofplayerstats[i].GetAipercent();
                    //txt_stats.Text = txt;


                }


            }
                sw.Close();
        }

            //playerwins = text;
            //aiwins = text;
            //tie = text;
            //totalplayed = text;
            //playerpercent = text;
            //aipercent = text;
            //txt_stats.Text = text;
            //inputfile.Close();
    }

        //private void Txt_stats_TextChanged(object sender, EventArgs e)
        //{
           


        //}
}


