
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
            this.lst_stats = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_mainmenu.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.Location = new System.Drawing.Point(166, 646);
            this.btn_mainmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(388, 133);
            this.btn_mainmenu.TabIndex = 0;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // lst_stats
            // 
            this.lst_stats.FormattingEnabled = true;
            this.lst_stats.ItemHeight = 16;
            this.lst_stats.Location = new System.Drawing.Point(331, 171);
            this.lst_stats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_stats.Name = "lst_stats";
            this.lst_stats.Size = new System.Drawing.Size(447, 452);
            this.lst_stats.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 95);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Stats";
            // 
            // Button_close
            // 
            this.Button_close.BackColor = System.Drawing.Color.Red;
            this.Button_close.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_close.Location = new System.Drawing.Point(572, 646);
            this.Button_close.Margin = new System.Windows.Forms.Padding(4);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(388, 133);
            this.Button_close.TabIndex = 3;
            this.Button_close.Text = "Exit";
            this.Button_close.UseVisualStyleBackColor = false;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1177, 823);
            this.ControlBox = false;
            this.Controls.Add(this.Button_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_stats);
            this.Controls.Add(this.btn_mainmenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.ListBox lst_stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_close;
    }
}