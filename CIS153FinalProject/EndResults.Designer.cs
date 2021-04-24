
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
            this.SuspendLayout();
            // 
            // Lbl_Results
            // 
            this.Lbl_Results.AutoSize = true;
            this.Lbl_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Results.Location = new System.Drawing.Point(336, 40);
            this.Lbl_Results.Name = "Lbl_Results";
            this.Lbl_Results.Size = new System.Drawing.Size(0, 46);
            this.Lbl_Results.TabIndex = 0;
            // 
            // EndResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(786, 462);
            this.ControlBox = false;
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
    }
}