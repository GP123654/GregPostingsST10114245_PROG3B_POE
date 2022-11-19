
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    partial class Game3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.checkAnswersBtn = new System.Windows.Forms.Button();
            this.answerRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.answerRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.answerRadioBtn3 = new System.Windows.Forms.RadioButton();
            this.answerRadioBtn4 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.game3GameTimer = new System.Windows.Forms.Timer(this.components);
            this.questionDescriptionLbl = new System.Windows.Forms.Label();
            this.questionNumLbl = new System.Windows.Forms.Label();
            this.questionNumberLbl = new System.Windows.Forms.Label();
            this.questionNumberTitleLbl = new System.Windows.Forms.Label();
            this.scoreTitleLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(595, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(595, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GregPostingsST10114245_PROG3B_POE.Properties.Resources.Books2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 711);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.playAgainBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.playAgainBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.playAgainBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.playAgainBtn.Location = new System.Drawing.Point(900, 660);
            this.playAgainBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(220, 40);
            this.playAgainBtn.TabIndex = 31;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = false;
            this.playAgainBtn.Visible = false;
            this.playAgainBtn.Click += new System.EventHandler(this.PlayAgainBtn_Click);
            // 
            // checkAnswersBtn
            // 
            this.checkAnswersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.checkAnswersBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.checkAnswersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkAnswersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkAnswersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAnswersBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAnswersBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.checkAnswersBtn.Location = new System.Drawing.Point(660, 660);
            this.checkAnswersBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.checkAnswersBtn.Name = "checkAnswersBtn";
            this.checkAnswersBtn.Size = new System.Drawing.Size(220, 40);
            this.checkAnswersBtn.TabIndex = 30;
            this.checkAnswersBtn.Text = "Check Answers";
            this.checkAnswersBtn.UseVisualStyleBackColor = false;
            this.checkAnswersBtn.Click += new System.EventHandler(this.CheckAnswersBtn_Click);
            // 
            // answerRadioBtn1
            // 
            this.answerRadioBtn1.AutoSize = true;
            this.answerRadioBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioBtn1.ForeColor = System.Drawing.Color.BlueViolet;
            this.answerRadioBtn1.Location = new System.Drawing.Point(601, 378);
            this.answerRadioBtn1.Name = "answerRadioBtn1";
            this.answerRadioBtn1.Size = new System.Drawing.Size(263, 24);
            this.answerRadioBtn1.TabIndex = 32;
            this.answerRadioBtn1.TabStop = true;
            this.answerRadioBtn1.Text = "This is an answer for the question";
            this.answerRadioBtn1.UseVisualStyleBackColor = true;
            this.answerRadioBtn1.Visible = false;
            // 
            // answerRadioBtn2
            // 
            this.answerRadioBtn2.AutoSize = true;
            this.answerRadioBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioBtn2.ForeColor = System.Drawing.Color.BlueViolet;
            this.answerRadioBtn2.Location = new System.Drawing.Point(601, 428);
            this.answerRadioBtn2.Name = "answerRadioBtn2";
            this.answerRadioBtn2.Size = new System.Drawing.Size(263, 24);
            this.answerRadioBtn2.TabIndex = 33;
            this.answerRadioBtn2.TabStop = true;
            this.answerRadioBtn2.Text = "This is an answer for the question";
            this.answerRadioBtn2.UseVisualStyleBackColor = true;
            this.answerRadioBtn2.Visible = false;
            // 
            // answerRadioBtn3
            // 
            this.answerRadioBtn3.AutoSize = true;
            this.answerRadioBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioBtn3.ForeColor = System.Drawing.Color.BlueViolet;
            this.answerRadioBtn3.Location = new System.Drawing.Point(601, 478);
            this.answerRadioBtn3.Name = "answerRadioBtn3";
            this.answerRadioBtn3.Size = new System.Drawing.Size(263, 24);
            this.answerRadioBtn3.TabIndex = 34;
            this.answerRadioBtn3.TabStop = true;
            this.answerRadioBtn3.Text = "This is an answer for the question";
            this.answerRadioBtn3.UseVisualStyleBackColor = true;
            this.answerRadioBtn3.Visible = false;
            // 
            // answerRadioBtn4
            // 
            this.answerRadioBtn4.AutoSize = true;
            this.answerRadioBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioBtn4.ForeColor = System.Drawing.Color.BlueViolet;
            this.answerRadioBtn4.Location = new System.Drawing.Point(601, 528);
            this.answerRadioBtn4.Name = "answerRadioBtn4";
            this.answerRadioBtn4.Size = new System.Drawing.Size(263, 24);
            this.answerRadioBtn4.TabIndex = 35;
            this.answerRadioBtn4.TabStop = true;
            this.answerRadioBtn4.Text = "This is an answer for the question";
            this.answerRadioBtn4.UseVisualStyleBackColor = true;
            this.answerRadioBtn4.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(913, 317);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 264);
            this.listBox1.TabIndex = 36;
            this.listBox1.Visible = false;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.questionLbl.Location = new System.Drawing.Point(597, 232);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(138, 20);
            this.questionLbl.TabIndex = 37;
            this.questionLbl.Text = "label1 vhh gigiugiu";
            this.questionLbl.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.startBtn.Location = new System.Drawing.Point(900, 660);
            this.startBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(220, 40);
            this.startBtn.TabIndex = 38;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.timeLbl.Location = new System.Drawing.Point(1002, 9);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(118, 25);
            this.timeLbl.TabIndex = 39;
            this.timeLbl.Text = "00:00:00";
            // 
            // game3GameTimer
            // 
            this.game3GameTimer.Interval = 10;
            this.game3GameTimer.Tick += new System.EventHandler(this.Game3GameTimer_Tick);
            // 
            // questionDescriptionLbl
            // 
            this.questionDescriptionLbl.AutoSize = true;
            this.questionDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDescriptionLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.questionDescriptionLbl.Location = new System.Drawing.Point(597, 159);
            this.questionDescriptionLbl.Name = "questionDescriptionLbl";
            this.questionDescriptionLbl.Size = new System.Drawing.Size(339, 40);
            this.questionDescriptionLbl.TabIndex = 40;
            this.questionDescriptionLbl.Text = "Please select the corresponding top level topic \r\nthat matches the following thir" +
    "d level topic:";
            this.questionDescriptionLbl.Visible = false;
            // 
            // questionNumLbl
            // 
            this.questionNumLbl.AutoSize = true;
            this.questionNumLbl.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.questionNumLbl.Location = new System.Drawing.Point(576, 17);
            this.questionNumLbl.Name = "questionNumLbl";
            this.questionNumLbl.Size = new System.Drawing.Size(29, 21);
            this.questionNumLbl.TabIndex = 41;
            this.questionNumLbl.Text = "/5";
            this.questionNumLbl.Visible = false;
            // 
            // questionNumberLbl
            // 
            this.questionNumberLbl.AutoSize = true;
            this.questionNumberLbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.questionNumberLbl.Location = new System.Drawing.Point(556, 9);
            this.questionNumberLbl.Name = "questionNumberLbl";
            this.questionNumberLbl.Size = new System.Drawing.Size(22, 25);
            this.questionNumberLbl.TabIndex = 42;
            this.questionNumberLbl.Text = "1";
            this.questionNumberLbl.Visible = false;
            // 
            // questionNumberTitleLbl
            // 
            this.questionNumberTitleLbl.AutoSize = true;
            this.questionNumberTitleLbl.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.questionNumberTitleLbl.ForeColor = System.Drawing.Color.MediumPurple;
            this.questionNumberTitleLbl.Location = new System.Drawing.Point(409, 18);
            this.questionNumberTitleLbl.Name = "questionNumberTitleLbl";
            this.questionNumberTitleLbl.Size = new System.Drawing.Size(144, 20);
            this.questionNumberTitleLbl.TabIndex = 43;
            this.questionNumberTitleLbl.Text = "Question Number:";
            // 
            // scoreTitleLbl
            // 
            this.scoreTitleLbl.AutoSize = true;
            this.scoreTitleLbl.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.scoreTitleLbl.ForeColor = System.Drawing.Color.MediumPurple;
            this.scoreTitleLbl.Location = new System.Drawing.Point(707, 18);
            this.scoreTitleLbl.Name = "scoreTitleLbl";
            this.scoreTitleLbl.Size = new System.Drawing.Size(54, 20);
            this.scoreTitleLbl.TabIndex = 44;
            this.scoreTitleLbl.Text = "Score:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.scoreLbl.Location = new System.Drawing.Point(767, 17);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(27, 25);
            this.scoreLbl.TabIndex = 45;
            this.scoreLbl.Text = "0";
            this.scoreLbl.Visible = false;
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.scoreTitleLbl);
            this.Controls.Add(this.questionNumberTitleLbl);
            this.Controls.Add(this.questionNumberLbl);
            this.Controls.Add(this.questionNumLbl);
            this.Controls.Add(this.questionDescriptionLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.answerRadioBtn4);
            this.Controls.Add(this.answerRadioBtn3);
            this.Controls.Add(this.answerRadioBtn2);
            this.Controls.Add(this.answerRadioBtn1);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.checkAnswersBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1150, 750);
            this.MinimumSize = new System.Drawing.Size(1150, 750);
            this.Name = "Game3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find That Call Number";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Button checkAnswersBtn;
        private System.Windows.Forms.RadioButton answerRadioBtn1;
        private System.Windows.Forms.RadioButton answerRadioBtn2;
        private System.Windows.Forms.RadioButton answerRadioBtn3;
        private System.Windows.Forms.RadioButton answerRadioBtn4;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button startBtn;
        public System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer game3GameTimer;
        public System.Windows.Forms.Label questionDescriptionLbl;
        private System.Windows.Forms.Label questionNumLbl;
        private System.Windows.Forms.Label questionNumberLbl;
        private System.Windows.Forms.Label questionNumberTitleLbl;
        private System.Windows.Forms.Label scoreTitleLbl;
        private System.Windows.Forms.Label scoreLbl;
    }
}