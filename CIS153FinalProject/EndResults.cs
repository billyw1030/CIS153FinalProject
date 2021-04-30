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
        double playerPercent1;
        double aiPercent1;
        string playerWins;
        string aiWins;
        string tie;
        string totalPlayed;
        string playerPercent;
        string aiPercent;
        int position;

        int playerWinNum;
        int aiWinNum;
        int tieNum;
        int totalNum;

        int whoWon;

        public EndResults(string results, int playedBoard, int winner)
        {
            InitializeComponent();
            Lbl_Results.Text = results;
            gamemode = playedBoard;
            //mainMenu = menu;
            whoWon = winner;

            if(gamemode == 1)
            {
                btn_reviewSinglePlayer.Visible = true;
                btn_reviewSinglePlayer.Visible = true;
                lbl_PlayerWins.Visible = true;
                lbl_AIWin.Visible = true;
                lbl_Tie.Visible = true;
                lbl_TotalPlayed.Visible = true;
                lbl_PlayerPercent.Visible = true;
                lbl_AIPercent.Visible = true;

                

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
                lbl_PlayerWins.Visible = false;
                lbl_AIWin.Visible = false;
                lbl_Tie.Visible = false;
                lbl_TotalPlayed.Visible = false;
                lbl_PlayerPercent.Visible = false;
                lbl_AIPercent.Visible = false;
                //lbx_SinglePlayerEnd.Visible = false;
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
            if (gamemode == 1)
            {
                //=====================START READING TEXT FILE TO GRAB VALUES==============================
                StreamReader inputfile = new StreamReader("../../Resources/statsfile.txt");

                //string text = " ";
                string line;
                //line = inputfile.ReadLine();

                Console.WriteLine("endresults load");
                while ((line = inputfile.ReadLine()) != null)
                {
                    //Console.WriteLine("in loop");
                    if (line.Contains("Player Wins:"))
                    {
                        playerWins = line;
                        position = playerWins.IndexOf(": ");
                        playerWins = line.Substring(position + 2);
                    }
                    else if (line.Contains("AI Wins:"))
                    {
                        aiWins = line;
                        position = aiWins.IndexOf(": ");
                        aiWins = line.Substring(position + 2);
                    }
                    else if (line.Contains("Tied Games:"))
                    {
                        tie = line;
                        position = tie.IndexOf(": ");
                        tie = line.Substring(position + 2);
                    }
                    else if (line.Contains("Total Played:"))
                    {
                        totalPlayed = line;
                        position = totalPlayed.IndexOf(": ");
                        totalPlayed = line.Substring(position + 2);

                    }
                    else if (line.Contains("Player Percent:"))
                    {
                        playerPercent = line;
                        position = playerPercent.IndexOf(": ");
                        playerPercent = line.Substring(position + 2);
                    }
                    else if (line.Contains("AI Percent:"))
                    {
                        aiPercent = line;
                        position = aiPercent.IndexOf(": ");
                        aiPercent = line.Substring(position + 2);
                    }
                }
                //Console.WriteLine(playerWins);

                inputfile.Close();
                //====================STOP READING TEXT FILE==================================

                //====================PERFORM MATH============================================
                playerWinNum = Convert.ToInt16(playerWins);
                aiWinNum = Convert.ToInt16(aiWins);
                tieNum = Convert.ToInt16(tie);
                totalNum = Convert.ToInt16(totalPlayed) + 1;

                if (whoWon == 1)
                {
                    playerWinNum++;
                }
                else if(whoWon == 2)
                {

                    aiWinNum++;
                }
                else if(whoWon == 0)
                {
                    tieNum++;
                }
                Console.WriteLine(playerPercent1);
                Console.WriteLine(aiPercent1);
                Console.WriteLine(totalNum);
                Console.WriteLine(playerWinNum);
                playerPercent1 = (playerWinNum / totalNum) * 100;
                aiPercent1 = (aiWinNum / totalNum) * 100;
               // Math.Round(playerPercent1, 2);
                //Math.Round(aiPercent1, 2);
                playerPercent = playerPercent1.ToString();
                aiPercent = aiPercent1.ToString();
                Console.WriteLine(playerPercent1);
                Console.WriteLine(aiPercent1);

                //===============================START WRITING TO TEXT FILE===================================================
                StreamWriter inputFile = new StreamWriter("../../Resources/statsfile.txt");

                //string currentLine;

                string[] lines = {"Player Wins: " + playerWinNum.ToString(), "AI Wins: " + aiWinNum.ToString(), "Tied Games: " + tieNum.ToString(),
                                  "Total Played: " + totalNum.ToString(), "Player Percent: " + playerPercent, "AI Percent: " + aiPercent};

                for (int i = 0; i < 6; i++)
                {
                    inputFile.WriteLineAsync(lines[i]);
                    if(i == 0)
                    {
                        lbl_PlayerWins.Text = lines[i];
                    }
                    else if(i == 1)
                    {
                        lbl_AIWin.Text = lines[i];
                    }
                    else if(i== 2)
                    {
                        lbl_Tie.Text = lines[i];
                    }
                    else if(i == 3)
                    {
                        lbl_TotalPlayed.Text = lines[i];
                    }
                    else if(i == 4)
                    {
                        lbl_PlayerPercent.Text = lines[i] + " %";
                    }
                    else if(i == 5)
                    {
                        lbl_AIPercent.Text = lines[i] + " %";
                    }
                }

                inputFile.Close();
                //=================================DONE WRITING TO TEXT FILE====================================================

            }
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
            if (gamemode == 1)
            {
                this.RefToSinglePlayer.getMenu().Show();
            }
            else if(gamemode == 2)
            {
                this.RefToTwoPlayer.getMenu().Show();
            }
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
                SinglePlayer formToLoad = new SinglePlayer(this.RefToSinglePlayer.getMenu());

                formToLoad.Show();
                this.Hide();
            }
            else if(gamemode == 2)
            {
                TwoPlayer formToLoad = new TwoPlayer(this.RefToTwoPlayer.getMenu());

                formToLoad.Show();
                this.Hide();
            }
        }

        private void lbx_SinglePlayerEnd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
