﻿using System;
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
            //StreamReader inputfile = new StreamReader("C:\\Users\\FleaF\\Documents\\GitHub\\CIS153FinalProject\\CIS153FinalProject\\statsfile.txt.txt");
            string text = " ";
            string line;
            line = inputfile.ReadLine();
            while (line !=null)
            {
                text = text + line + "\n";
                line = inputfile.ReadLine();

            }
            playerwins = text;
            aiwins = text;
            tie = text;
            totalplayed = text;
            playerpercent = text;
            aipercent = text;
            txt_stats.Text = text;
            inputfile.Close();


        }

        private void Txt_stats_TextChanged(object sender, EventArgs e)
        {
            string text = "";
            _ = new StreamReader("../../Resources/statsfile.txt");
            //StreamWriter sw = new StreamWriter("C:\\Users\\FleaF\\Documents\\GitHub\\CIS153FinalProject\\CIS153FinalProject\\statsfile.txt");
            Playerstats user1 = new Playerstats();
            user1.SetPlayerwins(playerwins);
            user1.SetAiwins(aiwins);
            user1.SetTie(tie);
            user1.SetTotalplayed(totalplayed);
            user1.SetPlayerpercent(playerpercent);
            user1.SetAipercent(aipercent);
            if (user1.GetPlayerwins().Length > 0)
            {
                if (user1.GetAiwins().Length > 0)
                {
                    if (user1.GetTie().Length > 0)
                    {

                        if (user1.GetTotalplayed().Length > 0)
                        {

                            if (user1.GetPlayerpercent().Length > 0)
                            {
                                if (user1.GetAipercent().Length > 0)
                                {
                                    listofplayerstats.Add(user1);

                                    for (int i = 0; i < listofplayerstats.Count(); i++)
                                    {
                                        txt_stats.Text = "";
                                        text = text + "Player Wins: " + listofplayerstats[i].GetPlayerwins() + Environment.NewLine + "Ai wins: " + listofplayerstats[i].GetAiwins() + Environment.NewLine + "Tie: " + listofplayerstats[i].GetTie()
                                         + Environment.NewLine + "Total games played: " + listofplayerstats[i].GetTotalplayed() + Environment.NewLine + "Player percentage: " + listofplayerstats[i].GetPlayerpercent() + Environment.NewLine + "Ai percentage: " + listofplayerstats[i].GetAipercent();

                                        txt_stats.Text = text;


                                    }


                                }







                            }

                        }

                    }

                }

            }


            //sw.WriteLine(text);
            //sw.Close();



        }
    }
}
