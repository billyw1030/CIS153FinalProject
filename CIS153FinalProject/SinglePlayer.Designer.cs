namespace CIS153FinalProject
{
    partial class SinglePlayer
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
            this.Lbl_WhoTurn = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_PlayerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_WhoTurn
            // 
            this.Lbl_WhoTurn.AutoSize = true;
            this.Lbl_WhoTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_WhoTurn.Location = new System.Drawing.Point(117, 430);
            this.Lbl_WhoTurn.Name = "Lbl_WhoTurn";
            this.Lbl_WhoTurn.Size = new System.Drawing.Size(112, 46);
            this.Lbl_WhoTurn.TabIndex = 0;
            this.Lbl_WhoTurn.Text = "Turn:";
            this.Lbl_WhoTurn.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Exit.Location = new System.Drawing.Point(484, 423);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(176, 53);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.Text = "Exit Game";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_PlayerTurn
            // 
            this.Lbl_PlayerTurn.AutoSize = true;
            this.Lbl_PlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PlayerTurn.Location = new System.Drawing.Point(235, 430);
            this.Lbl_PlayerTurn.Name = "Lbl_PlayerTurn";
            this.Lbl_PlayerTurn.Size = new System.Drawing.Size(155, 46);
            this.Lbl_PlayerTurn.TabIndex = 2;
            this.Lbl_PlayerTurn.Text = "Player1";
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(794, 537);
            this.Controls.Add(this.Lbl_PlayerTurn);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Lbl_WhoTurn);
            this.Name = "SinglePlayer";
            this.Text = "SinglePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_WhoTurn;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_PlayerTurn;
    }
}