
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    partial class Levels
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
            this.label1 = new System.Windows.Forms.Label();
            this.levelButtons1 = new GregPostingsST10114245_PROG3B_POE.UserControls.LevelButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(339, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select A Level";
            // 
            // levelButtons1
            // 
            this.levelButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.levelButtons1.Location = new System.Drawing.Point(0, 179);
            this.levelButtons1.MaximumSize = new System.Drawing.Size(1134, 532);
            this.levelButtons1.MinimumSize = new System.Drawing.Size(1134, 532);
            this.levelButtons1.Name = "levelButtons1";
            this.levelButtons1.Size = new System.Drawing.Size(1134, 532);
            this.levelButtons1.TabIndex = 2;
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.levelButtons1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1150, 750);
            this.MinimumSize = new System.Drawing.Size(1150, 750);
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private UserControls.LevelButtons levelButtons1;
    }
}