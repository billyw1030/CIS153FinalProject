using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153FinalProject
{
    partial class Statistics
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
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_close = new System.Windows.Forms.Button();
            this.lbl_TotalPlayed = new System.Windows.Forms.Label();
            this.lbl_Tie = new System.Windows.Forms.Label();
            this.lbl_AIWin = new System.Windows.Forms.Label();
            this.lbl_PlayerWins = new System.Windows.Forms.Label();
            this.lbl_AIPercent = new System.Windows.Forms.Label();
            this.lbl_PlayerPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.Green;
            this.btn_mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btn_mainmenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mainmenu.Location = new System.Drawing.Point(252, 539);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(176, 53);
            this.btn_mainmenu.TabIndex = 0;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.Btn_mainmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(290, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Statistics";
            // 
            // Button_close
            // 
            this.Button_close.BackColor = System.Drawing.Color.Firebrick;
            this.Button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Button_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_close.Location = new System.Drawing.Point(461, 539);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(176, 53);
            this.Button_close.TabIndex = 3;
            this.Button_close.Text = "Exit Game";
            this.Button_close.UseVisualStyleBackColor = false;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // lbl_TotalPlayed
            // 
            this.lbl_TotalPlayed.AutoSize = true;
            this.lbl_TotalPlayed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_TotalPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalPlayed.Location = new System.Drawing.Point(106, 331);
            this.lbl_TotalPlayed.Name = "lbl_TotalPlayed";
            this.lbl_TotalPlayed.Size = new System.Drawing.Size(254, 46);
            this.lbl_TotalPlayed.TabIndex = 4;
            this.lbl_TotalPlayed.Text = "Total Played";
            // 
            // lbl_Tie
            // 
            this.lbl_Tie.AutoSize = true;
            this.lbl_Tie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Tie.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_Tie.Location = new System.Drawing.Point(106, 265);
            this.lbl_Tie.Name = "lbl_Tie";
            this.lbl_Tie.Size = new System.Drawing.Size(246, 46);
            this.lbl_Tie.TabIndex = 5;
            this.lbl_Tie.Text = "Tied Games";
            // 
            // lbl_AIWin
            // 
            this.lbl_AIWin.AutoSize = true;
            this.lbl_AIWin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_AIWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_AIWin.Location = new System.Drawing.Point(106, 194);
            this.lbl_AIWin.Name = "lbl_AIWin";
            this.lbl_AIWin.Size = new System.Drawing.Size(164, 46);
            this.lbl_AIWin.TabIndex = 6;
            this.lbl_AIWin.Text = "AI Wins";
            // 
            // lbl_PlayerWins
            // 
            this.lbl_PlayerWins.AutoSize = true;
            this.lbl_PlayerWins.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_PlayerWins.Location = new System.Drawing.Point(106, 128);
            this.lbl_PlayerWins.Name = "lbl_PlayerWins";
            this.lbl_PlayerWins.Size = new System.Drawing.Size(244, 46);
            this.lbl_PlayerWins.TabIndex = 7;
            this.lbl_PlayerWins.Text = "Player Wins";
            // 
            // lbl_AIPercent
            // 
            this.lbl_AIPercent.AutoSize = true;
            this.lbl_AIPercent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_AIPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_AIPercent.Location = new System.Drawing.Point(106, 466);
            this.lbl_AIPercent.Name = "lbl_AIPercent";
            this.lbl_AIPercent.Size = new System.Drawing.Size(191, 46);
            this.lbl_AIPercent.TabIndex = 8;
            this.lbl_AIPercent.Text = "AI Win %";
            // 
            // lbl_PlayerPercent
            // 
            this.lbl_PlayerPercent.AutoSize = true;
            this.lbl_PlayerPercent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PlayerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_PlayerPercent.Location = new System.Drawing.Point(106, 394);
            this.lbl_PlayerPercent.Name = "lbl_PlayerPercent";
            this.lbl_PlayerPercent.Size = new System.Drawing.Size(271, 46);
            this.lbl_PlayerPercent.TabIndex = 9;
            this.lbl_PlayerPercent.Text = "Player Win %";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(883, 669);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_PlayerPercent);
            this.Controls.Add(this.lbl_AIPercent);
            this.Controls.Add(this.lbl_PlayerWins);
            this.Controls.Add(this.lbl_AIWin);
            this.Controls.Add(this.lbl_Tie);
            this.Controls.Add(this.lbl_TotalPlayed);
            this.Controls.Add(this.Button_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mainmenu);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_close;
        private System.Windows.Forms.Label lbl_TotalPlayed;
        private System.Windows.Forms.Label lbl_Tie;
        private System.Windows.Forms.Label lbl_AIWin;
        private System.Windows.Forms.Label lbl_PlayerWins;
        private System.Windows.Forms.Label lbl_AIPercent;
        private System.Windows.Forms.Label lbl_PlayerPercent;
    }
}