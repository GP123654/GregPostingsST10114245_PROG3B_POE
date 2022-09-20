
namespace GregPostingsST10114245_PROG3B_POE
{
    partial class Form1
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
            this.mainMenuButtons2 = new GregPostingsST10114245_PROG3B_POE.MainMenuButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(219, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dewey Decimal Learning Games";
            // 
            // mainMenuButtons2
            // 
            this.mainMenuButtons2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainMenuButtons2.Location = new System.Drawing.Point(0, 179);
            this.mainMenuButtons2.MaximumSize = new System.Drawing.Size(1134, 532);
            this.mainMenuButtons2.MinimumSize = new System.Drawing.Size(1134, 532);
            this.mainMenuButtons2.Name = "mainMenuButtons2";
            this.mainMenuButtons2.Size = new System.Drawing.Size(1134, 532);
            this.mainMenuButtons2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.mainMenuButtons2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1150, 750);
            this.MinimumSize = new System.Drawing.Size(1150, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the dewey decimal learning application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MainMenuButtons mainMenuButtons1;
        private UserControls.BookDrawing bookDrawing1;
        private MainMenuButtons mainMenuButtons2;
    }
}

