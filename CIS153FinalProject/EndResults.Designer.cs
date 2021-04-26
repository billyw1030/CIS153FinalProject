
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
            this.lbx_SinglePlayerEnd = new System.Windows.Forms.ListBox();
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
            // 
            // btn_CloseEnd
            // 
            this.btn_CloseEnd.BackColor = System.Drawing.Color.Firebrick;
            this.btn_CloseEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CloseEnd.Location = new System.Drawing.Point(532, 397);
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
            this.btn_MainMenuEnd.Location = new System.Drawing.Point(319, 397);
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
            this.btn_reviewTwoPlayer.Location = new System.Drawing.Point(102, 397);
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
            this.btn_reviewSinglePlayer.Location = new System.Drawing.Point(102, 397);
            this.btn_reviewSinglePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reviewSinglePlayer.Name = "btn_reviewSinglePlayer";
            this.btn_reviewSinglePlayer.Size = new System.Drawing.Size(176, 53);
            this.btn_reviewSinglePlayer.TabIndex = 10;
            this.btn_reviewSinglePlayer.Text = "Review";
            this.btn_reviewSinglePlayer.UseVisualStyleBackColor = false;
            this.btn_reviewSinglePlayer.Visible = false;
            this.btn_reviewSinglePlayer.Click += new System.EventHandler(this.btn_reviewSinglePlayer_Click);
            // 
            // lbx_SinglePlayerEnd
            // 
            this.lbx_SinglePlayerEnd.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_SinglePlayerEnd.FormattingEnabled = true;
            this.lbx_SinglePlayerEnd.ItemHeight = 46;
            this.lbx_SinglePlayerEnd.Location = new System.Drawing.Point(102, 91);
            this.lbx_SinglePlayerEnd.Name = "lbx_SinglePlayerEnd";
            this.lbx_SinglePlayerEnd.Size = new System.Drawing.Size(606, 280);
            this.lbx_SinglePlayerEnd.TabIndex = 11;
            this.lbx_SinglePlayerEnd.Visible = false;
            // 
            // EndResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(786, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lbx_SinglePlayerEnd);
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
        private System.Windows.Forms.ListBox lbx_SinglePlayerEnd;
    }
}