
namespace CIS153FinalProject
{
    partial class WelcomeForm
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_SinglePlayer = new System.Windows.Forms.Button();
            this.btn_TwoPlayer = new System.Windows.Forms.Button();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.lbl_ConnectFour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(183, 316);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(179, 63);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SinglePlayer
            // 
            this.btn_SinglePlayer.BackColor = System.Drawing.Color.Green;
            this.btn_SinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinglePlayer.Location = new System.Drawing.Point(138, 109);
            this.btn_SinglePlayer.Name = "btn_SinglePlayer";
            this.btn_SinglePlayer.Size = new System.Drawing.Size(266, 63);
            this.btn_SinglePlayer.TabIndex = 1;
            this.btn_SinglePlayer.Text = "Single Player";
            this.btn_SinglePlayer.UseVisualStyleBackColor = false;
            this.btn_SinglePlayer.Click += new System.EventHandler(this.btn_SinglePlayer_Click);
            // 
            // btn_TwoPlayer
            // 
            this.btn_TwoPlayer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TwoPlayer.Location = new System.Drawing.Point(152, 178);
            this.btn_TwoPlayer.Name = "btn_TwoPlayer";
            this.btn_TwoPlayer.Size = new System.Drawing.Size(240, 63);
            this.btn_TwoPlayer.TabIndex = 2;
            this.btn_TwoPlayer.Text = "Two Player";
            this.btn_TwoPlayer.UseVisualStyleBackColor = false;
            this.btn_TwoPlayer.Click += new System.EventHandler(this.btn_TwoPlayer_Click);
            // 
            // btn_Stats
            // 
            this.btn_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stats.Location = new System.Drawing.Point(162, 247);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(221, 63);
            this.btn_Stats.TabIndex = 3;
            this.btn_Stats.Text = "Statistics";
            this.btn_Stats.UseVisualStyleBackColor = false;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // lbl_ConnectFour
            // 
            this.lbl_ConnectFour.AutoSize = true;
            this.lbl_ConnectFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConnectFour.Location = new System.Drawing.Point(130, 38);
            this.lbl_ConnectFour.Name = "lbl_ConnectFour";
            this.lbl_ConnectFour.Size = new System.Drawing.Size(287, 46);
            this.lbl_ConnectFour.TabIndex = 4;
            this.lbl_ConnectFour.Text = "Connect Four!";
            this.lbl_ConnectFour.Click += new System.EventHandler(this.lbl_ConnectFour_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(522, 417);
            this.Controls.Add(this.lbl_ConnectFour);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.btn_TwoPlayer);
            this.Controls.Add(this.btn_SinglePlayer);
            this.Controls.Add(this.btn_Exit);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SinglePlayer;
        private System.Windows.Forms.Button btn_TwoPlayer;
        private System.Windows.Forms.Button btn_Stats;
        private System.Windows.Forms.Label lbl_ConnectFour;
        
    }
}

