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
       
        //bool srClosed = false;

        List<Playerstats> listofplayerstats = new List<Playerstats>();

        public Statistics()
        {
            InitializeComponent();

            
            //srClosed = true;

            //Set labels
            //labelSetter(playerWins, aiWins, tie, totalPlayed, playerPercent, aiPercent);
        }
        private void labelSetter(string pWin, string aWin, string tie, string total, string pPercent, string aPercent)
        {
            lbl_PlayerWins.Text = pWin;
            lbl_AIWin.Text = aWin;
            lbl_Tie.Text = tie;
            lbl_TotalPlayed.Text = total;
            lbl_PlayerPercent.Text = pPercent + " %";
            lbl_AIPercent.Text = aPercent + " %";
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



        //private void Statistics_Load(object sender, EventArgs e)
        //{

        //}

        private void Statistics_Load_1(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
            StreamReader inputfile = new StreamReader("../../Resources/statsfile.txt");

            //string text = " ";
            string line;
            //line = inputfile.ReadLine();

            Console.WriteLine("just before loop");
            while ((line = inputfile.ReadLine()) != null)
            {
                Console.WriteLine("in loop");
                if (line.Contains("Player Wins:"))
                {
                    Console.WriteLine("player wins written");
                    //playerWins = line;
                    Console.WriteLine(line);
                    lbl_PlayerWins.Text = line;
                    Console.WriteLine(lbl_PlayerWins.Text);
                }
                else if (line.Contains("AI Wins:"))
                {
                    Console.WriteLine("ai wins written");
                    //aiWins = line;
                    lbl_AIWin.Text = line;
                }
                else if (line.Contains("Tied Games:"))
                {
                    Console.WriteLine("tie written");
                    //tie = line;
                    lbl_Tie.Text = line;
                }
                else if (line.Contains("Total Played:"))
                {
                    Console.WriteLine("total played written");
                    //totalPlayed = line;
                    lbl_TotalPlayed.Text = line;
                }
                else if (line.Contains("Player Percent:"))
                {
                    Console.WriteLine("player % written");
                    //playerPercent = line;
                    lbl_PlayerPercent.Text = line + " %";
                }
                else if (line.Contains("AI Percent:"))
                {
                    Console.WriteLine("ai % written");
                    //aiPercent = line;
                    lbl_AIPercent.Text = line + " %";
                }
            }

            inputfile.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            StreamWriter inputFile = new StreamWriter("../../Resources/statsfile.txt");

            //string currentLine;

            string[] lines = {"Player Wins: 0", "AI Wins: 0", "Tied Games: 0", "Total Played: 0", "Player Percent: 0", "AI Percent: 0"};

            for (int i = 0; i < 6; i++)
            {
                inputFile.WriteLineAsync(lines[i]);
                if (i == 0)
                {
                    lbl_PlayerWins.Text = lines[i];
                }
                else if (i == 1)
                {
                    lbl_AIWin.Text = lines[i];
                }
                else if (i == 2)
                {
                    lbl_Tie.Text = lines[i];
                }
                else if (i == 3)
                {
                    lbl_TotalPlayed.Text = lines[i];
                }
                else if (i == 4)
                {
                    lbl_PlayerPercent.Text = lines[i] + " %";
                }
                else if (i == 5)
                {
                    lbl_AIPercent.Text = lines[i] + " %";
                }
            }

            inputFile.Close();




            StreamReader inputfile = new StreamReader("../../Resources/statsfile.txt");

            //string text = " ";
            string line;
            //line = inputfile.ReadLine();

            Console.WriteLine("just before loop");
            while ((line = inputfile.ReadLine()) != null)
            {
                Console.WriteLine("in loop");
                if (line.Contains("Player Wins:"))
                {
                    Console.WriteLine("player wins written");
                    //playerWins = line;
                    Console.WriteLine(line);
                    lbl_PlayerWins.Text = line;
                    Console.WriteLine(lbl_PlayerWins.Text);
                }
                else if (line.Contains("AI Wins:"))
                {
                    Console.WriteLine("ai wins written");
                    //aiWins = line;
                    lbl_AIWin.Text = line;
                }
                else if (line.Contains("Tied Games:"))
                {
                    Console.WriteLine("tie written");
                    //tie = line;
                    lbl_Tie.Text = line;
                }
                else if (line.Contains("Total Played:"))
                {
                    Console.WriteLine("total played written");
                    //totalPlayed = line;
                    lbl_TotalPlayed.Text = line;
                }
                else if (line.Contains("Player Percent:"))
                {
                    Console.WriteLine("player % written");
                    //playerPercent = line;
                    lbl_PlayerPercent.Text = line + " %";
                }
                else if (line.Contains("AI Percent:"))
                {
                    Console.WriteLine("ai % written");
                    //aiPercent = line;
                    lbl_AIPercent.Text = line + " %";
                }
            }

            inputfile.Close();
        }
    }
}


//int count1 = 0;
//int count2 = 0;
//int count3 = 0;
//int count4 = 0;
//while (line != null)
//{

//    if (line.Equals("1"))
//    {
//        count1++;

//    }

//    if (line.Equals("2"))
//    {
//        count2++;


//    }
//    if (line.Equals("3"))
//    {
//        count3++;


//    }
//    if (line.Equals("4"))
//    {
//        count4++;


//    }

//    text = text + line + "\n";
//    line = inputfile.ReadLine();
//    inputfile.Close();
//    //srClosed = true;

//}


//text is changed
//Console.WriteLine("Entered TextChanged");
//string txt = "";
//StreamWriter sw = new StreamWriter("../../Resources/statsfile.txt");
//Playerstats user1 = new Playerstats();
//user1.SetPlayerwins(playerWins);
//user1.SetAiwins(aiWins);
//user1.SetTie(tie);
//user1.SetTotalplayed(totalPlayed);
//user1.SetPlayerpercent(playerPercent);
//user1.SetAipercent(aiPercent);
//if (user1.GetPlayerwins().Length > 0 && user1.GetAiwins().Length > 0 && user1.GetTie().Length > 0 && user1.GetTotalplayed().Length > 0 && user1.GetPlayerpercent().Length > 0 && user1.GetAipercent().Length > 0)
//{

//    listofplayerstats.Add(user1);

//    for (int i = 0; i < listofplayerstats.Count(); i++)
//    {
//        lbl_PlayerWins.Text = "Player Wins: " + listofplayerstats[i].GetPlayerwins();
//        //txt_stats.Text = "";
//        //txt = txt + "Player Wins: " + listofplayerstats[i].GetPlayerwins() + Environment.NewLine + "AI wins: " + listofplayerstats[i].GetAiwins() + Environment.NewLine + "Tie: " + listofplayerstats[i].GetTie()
//        //    + Environment.NewLine + "Total games played: " + listofplayerstats[i].GetTotalplayed() + Environment.NewLine + "Player percentage: " + listofplayerstats[i].GetPlayerpercent() + Environment.NewLine + "AI percentage: " + listofplayerstats[i].GetAipercent();
//        //txt_stats.Text = txt;


//    }


//}
//sw.Close();