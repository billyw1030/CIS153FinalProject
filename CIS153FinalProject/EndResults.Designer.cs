
namespace CIS153FinalProject
{
    partial class EndResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Results = new System.Windows.Forms.Label();
            this.btn_CloseEnd = new System.Windows.Forms.Button();
            this.btn_MainMenuEnd = new System.Windows.Forms.Button();
            this.btn_reviewTwoPlayer = new System.Windows.Forms.Button();
            this.btn_reviewSinglePlayer = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.lbl_PlayerPercent = new System.Windows.Forms.Label();
            this.lbl_AIPercent = new System.Windows.Forms.Label();
            this.lbl_PlayerWins = new System.Windows.Forms.Label();
            this.lbl_AIWin = new System.Windows.Forms.Label();
            this.lbl_Tie = new System.Windows.Forms.Label();
            this.lbl_TotalPlayed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Results
            // 
            this.Lbl_Results.AutoSize = true;
            this.Lbl_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Results.Location = new System.Drawing.Point(259, 42);
            this.Lbl_Results.Name = "Lbl_Results";
            this.Lbl_Results.Size = new System.Drawing.Size(260, 46);
            this.Lbl_Results.TabIndex = 0;
            this.Lbl_Results.Text = "test: test test";
            this.Lbl_Results.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_CloseEnd
            // 
            this.btn_CloseEnd.BackColor = System.Drawing.Color.Firebrick;
            this.btn_CloseEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CloseEnd.Location = new System.Drawing.Point(599, 397);
            this.btn_CloseEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CloseEnd.Name = "btn_CloseEnd";
            this.btn_CloseEnd.Size = new System.Drawing.Size(176, 53);
            this.btn_CloseEnd.TabIndex = 8;
            this.btn_CloseEnd.Text = "Exit Game";
            this.btn_CloseEnd.UseVisualStyleBackColor = false;
            this.btn_CloseEnd.Click += new System.EventHandler(this.btn_CloseEnd_Click);
            // 
            // btn_MainMenuEnd
            // 
            this.btn_MainMenuEnd.BackColor = System.Drawing.Color.Green;
            this.btn_MainMenuEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenuEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_MainMenuEnd.Location = new System.Drawing.Point(206, 397);
            this.btn_MainMenuEnd.Name = "btn_MainMenuEnd";
            this.btn_MainMenuEnd.Size = new System.Drawing.Size(176, 53);
            this.btn_MainMenuEnd.TabIndex = 7;
            this.btn_MainMenuEnd.Text = "Main Menu";
            this.btn_MainMenuEnd.UseVisualStyleBackColor = false;
            this.btn_MainMenuEnd.Click += new System.EventHandler(this.btn_MainMenuEnd_Click);
            // 
            // btn_reviewTwoPlayer
            // 
            this.btn_reviewTwoPlayer.BackColor = System.Drawing.Color.Teal;
            this.btn_reviewTwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviewTwoPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reviewTwoPlayer.Location = new System.Drawing.Point(11, 397);
            this.btn_reviewTwoPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reviewTwoPlayer.Name = "btn_reviewTwoPlayer";
            this.btn_reviewTwoPlayer.Size = new System.Drawing.Size(176, 53);
            this.btn_reviewTwoPlayer.TabIndex = 9;
            this.btn_reviewTwoPlayer.Text = "Review";
            this.btn_reviewTwoPlayer.UseVisualStyleBackColor = false;
            this.btn_reviewTwoPlayer.Visible = false;
            this.btn_reviewTwoPlayer.Click += new System.EventHandler(this.btn_reviewTwoPlayer_Click);
            // 
            // btn_reviewSinglePlayer
            // 
            this.btn_reviewSinglePlayer.BackColor = System.Drawing.Color.Teal;
            this.btn_reviewSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviewSinglePlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reviewSinglePlayer.Location = new System.Drawing.Point(11, 397);
            this.btn_reviewSinglePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reviewSinglePlayer.Name = "btn_reviewSinglePlayer";
            this.btn_reviewSinglePlayer.Size = new System.Drawing.Size(176, 53);
            this.btn_reviewSinglePlayer.TabIndex = 10;
            this.btn_reviewSinglePlayer.Text = "Review";
            this.btn_reviewSinglePlayer.UseVisualStyleBackColor = false;
            this.btn_reviewSinglePlayer.Visible = false;
            this.btn_reviewSinglePlayer.Click += new System.EventHandler(this.btn_reviewSinglePlayer_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Indigo;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PlayAgain.Location = new System.Drawing.Point(404, 397);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(176, 53);
            this.btn_PlayAgain.TabIndex = 12;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // lbl_PlayerPercent
            // 
            this.lbl_PlayerPercent.AutoSize = true;
            this.lbl_PlayerPercent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PlayerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_PlayerPercent.Location = new System.Drawing.Point(309, 223);
            this.lbl_PlayerPercent.Name = "lbl_PlayerPercent";
            this.lbl_PlayerPercent.Size = new System.Drawing.Size(271, 46);
            this.lbl_PlayerPercent.TabIndex = 18;
            this.lbl_PlayerPercent.Text = "Player Win %";
            // 
            // lbl_AIPercent
            // 
            this.lbl_AIPercent.AutoSize = true;
            this.lbl_AIPercent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_AIPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_AIPercent.Location = new System.Drawing.Point(309, 299);
            this.lbl_AIPercent.Name = "lbl_AIPercent";
            this.lbl_AIPercent.Size = new System.Drawing.Size(191, 46);
            this.lbl_AIPercent.TabIndex = 17;
            this.lbl_AIPercent.Text = "AI Win %";
            // 
            // lbl_PlayerWins
            // 
            this.lbl_PlayerWins.AutoSize = true;
            this.lbl_PlayerWins.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_PlayerWins.Location = new System.Drawing.Point(12, 147);
            this.lbl_PlayerWins.Name = "lbl_PlayerWins";
            this.lbl_PlayerWins.Size = new System.Drawing.Size(244, 46);
            this.lbl_PlayerWins.TabIndex = 16;
            this.lbl_PlayerWins.Text = "Player Wins";
            // 
            // lbl_AIWin
            // 
            this.lbl_AIWin.AutoSize = true;
            this.lbl_AIWin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_AIWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_AIWin.Location = new System.Drawing.Point(23, 223);
            this.lbl_AIWin.Name = "lbl_AIWin";
            this.lbl_AIWin.Size = new System.Drawing.Size(164, 46);
            this.lbl_AIWin.TabIndex = 15;
            this.lbl_AIWin.Text = "AI Wins";
            // 
            // lbl_Tie
            // 
            this.lbl_Tie.AutoSize = true;
            this.lbl_Tie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Tie.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_Tie.Location = new System.Drawing.Point(23, 299);
            this.lbl_Tie.Name = "lbl_Tie";
            this.lbl_Tie.Size = new System.Drawing.Size(246, 46);
            this.lbl_Tie.TabIndex = 14;
            this.lbl_Tie.Text = "Tied Games";
            // 
            // lbl_TotalPlayed
            // 
            this.lbl_TotalPlayed.AutoSize = true;
            this.lbl_TotalPlayed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_TotalPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalPlayed.Location = new System.Drawing.Point(309, 147);
            this.lbl_TotalPlayed.Name = "lbl_TotalPlayed";
            this.lbl_TotalPlayed.Size = new System.Drawing.Size(254, 46);
            this.lbl_TotalPlayed.TabIndex = 13;
            this.lbl_TotalPlayed.Text = "Total Played";
            // 
            // EndResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(786, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_PlayerPercent);
            this.Controls.Add(this.lbl_AIPercent);
            this.Controls.Add(this.lbl_PlayerWins);
            this.Controls.Add(this.lbl_AIWin);
            this.Controls.Add(this.lbl_Tie);
            this.Controls.Add(this.lbl_TotalPlayed);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.btn_reviewSinglePlayer);
            this.Controls.Add(this.btn_reviewTwoPlayer);
            this.Controls.Add(this.btn_CloseEnd);
            this.Controls.Add(this.btn_MainMenuEnd);
            this.Controls.Add(this.Lbl_Results);
            this.Name = "EndResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndResults";
            this.Load += new System.EventHandler(this.EndResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Results;
        private System.Windows.Forms.Button btn_CloseEnd;
        private System.Windows.Forms.Button btn_MainMenuEnd;
        private System.Windows.Forms.Button btn_reviewTwoPlayer;
        private System.Windows.Forms.Button btn_reviewSinglePlayer;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Label lbl_PlayerPercent;
        private System.Windows.Forms.Label lbl_AIPercent;
        private System.Windows.Forms.Label lbl_PlayerWins;
        private System.Windows.Forms.Label lbl_AIWin;
        private System.Windows.Forms.Label lbl_Tie;
        private System.Windows.Forms.Label lbl_TotalPlayed;
    }
}