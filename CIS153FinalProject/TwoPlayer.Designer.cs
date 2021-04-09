
namespace CIS153FinalProject
{
    partial class TwoPlayer
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
            this.lbl_playerTurnTwo = new System.Windows.Forms.Label();
            this.lbl_turn = new System.Windows.Forms.Label();
            this.btn_exitTwoPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_playerTurnTwo
            // 
            this.lbl_playerTurnTwo.AutoSize = true;
            this.lbl_playerTurnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerTurnTwo.Location = new System.Drawing.Point(217, 429);
            this.lbl_playerTurnTwo.Name = "lbl_playerTurnTwo";
            this.lbl_playerTurnTwo.Size = new System.Drawing.Size(155, 46);
            this.lbl_playerTurnTwo.TabIndex = 3;
            this.lbl_playerTurnTwo.Text = "Player1";
            // 
            // lbl_turn
            // 
            this.lbl_turn.AutoSize = true;
            this.lbl_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turn.Location = new System.Drawing.Point(113, 429);
            this.lbl_turn.Name = "lbl_turn";
            this.lbl_turn.Size = new System.Drawing.Size(112, 46);
            this.lbl_turn.TabIndex = 4;
            this.lbl_turn.Text = "Turn:";
            // 
            // btn_exitTwoPlayer
            // 
            this.btn_exitTwoPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exitTwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitTwoPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exitTwoPlayer.Location = new System.Drawing.Point(519, 422);
            this.btn_exitTwoPlayer.Name = "btn_exitTwoPlayer";
            this.btn_exitTwoPlayer.Size = new System.Drawing.Size(176, 53);
            this.btn_exitTwoPlayer.TabIndex = 5;
            this.btn_exitTwoPlayer.Text = "Exit Game";
            this.btn_exitTwoPlayer.UseVisualStyleBackColor = false;
            this.btn_exitTwoPlayer.Click += new System.EventHandler(this.btn_exitTwoPlayer_Click);
            // 
            // TwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(794, 537);
            this.Controls.Add(this.btn_exitTwoPlayer);
            this.Controls.Add(this.lbl_turn);
            this.Controls.Add(this.lbl_playerTurnTwo);
            this.Name = "TwoPlayer";
            this.Text = "TwoPlayer";
            this.Load += new System.EventHandler(this.TwoPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playerTurnTwo;
        private System.Windows.Forms.Label lbl_turn;
        private System.Windows.Forms.Button btn_exitTwoPlayer;
    }
}