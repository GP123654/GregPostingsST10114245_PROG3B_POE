
namespace GregPostingsST10114245_PROG3B_POE.UserControls
{
    partial class Game1GameModeButtons
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
            this.highScoreBtn = new System.Windows.Forms.Button();
            this.timeTraialBtn = new System.Windows.Forms.Button();
            this.workingGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.buttonToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // highScoreBtn
            // 
            this.highScoreBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.highScoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.highScoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highScoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.highScoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.highScoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.highScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoreBtn.Font = new System.Drawing.Font("Georgia", 12F);
            this.highScoreBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.highScoreBtn.Location = new System.Drawing.Point(480, 100);
            this.highScoreBtn.MaximumSize = new System.Drawing.Size(220, 40);
            this.highScoreBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.highScoreBtn.Name = "highScoreBtn";
            this.highScoreBtn.Size = new System.Drawing.Size(220, 40);
            this.highScoreBtn.TabIndex = 3;
            this.highScoreBtn.Text = "High Score";
            this.buttonToolTip1.SetToolTip(this.highScoreBtn, "A more relaxed game mode where you try and beat yours and others high scores");
            this.highScoreBtn.UseVisualStyleBackColor = false;
            this.highScoreBtn.Click += new System.EventHandler(this.HighScoreBtn_Click);
            // 
            // timeTraialBtn
            // 
            this.timeTraialBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeTraialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.timeTraialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeTraialBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.timeTraialBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.timeTraialBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.timeTraialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeTraialBtn.Font = new System.Drawing.Font("Georgia", 12F);
            this.timeTraialBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.timeTraialBtn.Location = new System.Drawing.Point(480, 220);
            this.timeTraialBtn.MaximumSize = new System.Drawing.Size(220, 40);
            this.timeTraialBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.timeTraialBtn.Name = "timeTraialBtn";
            this.timeTraialBtn.Size = new System.Drawing.Size(220, 40);
            this.timeTraialBtn.TabIndex = 4;
            this.timeTraialBtn.Text = "Time Trial";
            this.buttonToolTip1.SetToolTip(this.timeTraialBtn, "A more time sensitive game where you race against the clock to try and win");
            this.timeTraialBtn.UseVisualStyleBackColor = false;
            this.timeTraialBtn.Click += new System.EventHandler(this.TimeTraialBtn_Click);
            // 
            // workingGameBtn
            // 
            this.workingGameBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.workingGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.workingGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workingGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.workingGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.workingGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.workingGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workingGameBtn.Font = new System.Drawing.Font("Georgia", 12F);
            this.workingGameBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.workingGameBtn.Location = new System.Drawing.Point(480, 340);
            this.workingGameBtn.MaximumSize = new System.Drawing.Size(220, 40);
            this.workingGameBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.workingGameBtn.Name = "workingGameBtn";
            this.workingGameBtn.Size = new System.Drawing.Size(220, 40);
            this.workingGameBtn.TabIndex = 5;
            this.workingGameBtn.Text = "Working Game";
            this.buttonToolTip1.SetToolTip(this.workingGameBtn, "This is the only working game mode");
            this.workingGameBtn.UseVisualStyleBackColor = false;
            this.workingGameBtn.Click += new System.EventHandler(this.WorkingGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(719, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Still in development Does not work but you can look at it";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(719, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Still in development Does not work but you can look at it";
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 12F);
            this.backBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.backBtn.Location = new System.Drawing.Point(900, 480);
            this.backBtn.MaximumSize = new System.Drawing.Size(220, 40);
            this.backBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(220, 40);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // buttonToolTip1
            // 
            this.buttonToolTip1.AutoPopDelay = 5000;
            this.buttonToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonToolTip1.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonToolTip1.InitialDelay = 400;
            this.buttonToolTip1.ReshowDelay = 100;
            this.buttonToolTip1.ToolTipTitle = "Click";
            // 
            // Game1GameModeButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workingGameBtn);
            this.Controls.Add(this.timeTraialBtn);
            this.Controls.Add(this.highScoreBtn);
            this.MaximumSize = new System.Drawing.Size(1134, 532);
            this.MinimumSize = new System.Drawing.Size(1134, 532);
            this.Name = "Game1GameModeButtons";
            this.Size = new System.Drawing.Size(1134, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button highScoreBtn;
        private System.Windows.Forms.Button timeTraialBtn;
        private System.Windows.Forms.Button workingGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ToolTip buttonToolTip1;
    }
}
