﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_close = new System.Windows.Forms.Button();
            this.txt_stats = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_mainmenu.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.Location = new System.Drawing.Point(124, 525);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(291, 108);
            this.btn_mainmenu.TabIndex = 0;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.Btn_mainmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Stats";
            // 
            // Button_close
            // 
            this.Button_close.BackColor = System.Drawing.Color.Red;
            this.Button_close.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_close.Location = new System.Drawing.Point(429, 525);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(291, 108);
            this.Button_close.TabIndex = 3;
            this.Button_close.Text = "Exit";
            this.Button_close.UseVisualStyleBackColor = false;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // txt_stats
            // 
            this.txt_stats.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stats.Location = new System.Drawing.Point(168, 131);
            this.txt_stats.Name = "txt_stats";
            this.txt_stats.Size = new System.Drawing.Size(496, 388);
            this.txt_stats.TabIndex = 4;
            this.txt_stats.Text = "";
            this.txt_stats.TextChanged += new System.EventHandler(this.Txt_stats_TextChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 669);
            this.ControlBox = false;
            this.Controls.Add(this.txt_stats);
            this.Controls.Add(this.Button_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mainmenu);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_close;
        private System.Windows.Forms.RichTextBox txt_stats;
    }
}