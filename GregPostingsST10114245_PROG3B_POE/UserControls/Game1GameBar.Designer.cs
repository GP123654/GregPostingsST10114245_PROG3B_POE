
namespace GregPostingsST10114245_PROG3B_POE.UserControls
{
    partial class Game1GameBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerLbl = new System.Windows.Forms.Label();
            this.gameTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameProgressBar1
            // 
            this.gameProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gameProgressBar1.ForeColor = System.Drawing.Color.MediumPurple;
            this.gameProgressBar1.Location = new System.Drawing.Point(12, 10);
            this.gameProgressBar1.Name = "gameProgressBar1";
            this.gameProgressBar1.Size = new System.Drawing.Size(213, 30);
            this.gameProgressBar1.TabIndex = 0;
            this.gameProgressBar1.Value = 40;
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.timerLbl.Location = new System.Drawing.Point(847, 10);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(75, 27);
            this.timerLbl.TabIndex = 1;
            this.timerLbl.Text = "00:00";
            this.timerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer1
            // 
            this.gameTimer1.Interval = 1000;
            this.gameTimer1.Tick += new System.EventHandler(this.gameTimer1_Tick);
            // 
            // Game1GameBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.gameProgressBar1);
            this.MaximumSize = new System.Drawing.Size(1134, 50);
            this.MinimumSize = new System.Drawing.Size(1134, 50);
            this.Name = "Game1GameBar";
            this.Size = new System.Drawing.Size(1134, 50);
            this.Leave += new System.EventHandler(this.Game1GameBar_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar gameProgressBar1;
        public System.Windows.Forms.Timer gameTimer1;
        public System.Windows.Forms.Label timerLbl;
    }
}
