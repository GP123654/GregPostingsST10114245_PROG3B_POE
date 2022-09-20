
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    partial class BoringGameOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoringGameOne));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookCartUnsortedListBox = new System.Windows.Forms.ListBox();
            this.BookShelfSortedListBox = new System.Windows.Forms.ListBox();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.boringGameTimer = new System.Windows.Forms.Timer(this.components);
            this.numCorrectLbl = new System.Windows.Forms.Label();
            this.numMovesMadeLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkOrder = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BookCartUnsortedListBox
            // 
            this.BookCartUnsortedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BookCartUnsortedListBox.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCartUnsortedListBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.BookCartUnsortedListBox.FormattingEnabled = true;
            this.BookCartUnsortedListBox.ItemHeight = 20;
            this.BookCartUnsortedListBox.Location = new System.Drawing.Point(72, 110);
            this.BookCartUnsortedListBox.Name = "BookCartUnsortedListBox";
            this.BookCartUnsortedListBox.Size = new System.Drawing.Size(199, 224);
            this.BookCartUnsortedListBox.TabIndex = 1;
            this.BookCartUnsortedListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookCartUnsortedListBox_MouseDown);
            // 
            // BookShelfSortedListBox
            // 
            this.BookShelfSortedListBox.AllowDrop = true;
            this.BookShelfSortedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BookShelfSortedListBox.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookShelfSortedListBox.ForeColor = System.Drawing.Color.MediumPurple;
            this.BookShelfSortedListBox.FormattingEnabled = true;
            this.BookShelfSortedListBox.ItemHeight = 20;
            this.BookShelfSortedListBox.Location = new System.Drawing.Point(382, 110);
            this.BookShelfSortedListBox.Name = "BookShelfSortedListBox";
            this.BookShelfSortedListBox.Size = new System.Drawing.Size(199, 224);
            this.BookShelfSortedListBox.TabIndex = 2;
            this.BookShelfSortedListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.BookShelfSortedListBox_DragDrop);
            this.BookShelfSortedListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.BookShelfSortedListBox_DragEnter);
            this.BookShelfSortedListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.BookShelfSortedListBox_DragOver);
            this.BookShelfSortedListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookShelfSortedListBox_MouseDown);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.moveUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.moveUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.moveUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.moveUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveUpBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUpBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.moveUpBtn.Location = new System.Drawing.Point(640, 136);
            this.moveUpBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(220, 40);
            this.moveUpBtn.TabIndex = 4;
            this.moveUpBtn.Text = "Move Up";
            this.moveUpBtn.UseVisualStyleBackColor = false;
            this.moveUpBtn.Click += new System.EventHandler(this.MoveUpBtn_Click);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.moveDownBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.moveDownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.moveDownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.moveDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveDownBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDownBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.moveDownBtn.Location = new System.Drawing.Point(640, 210);
            this.moveDownBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(220, 40);
            this.moveDownBtn.TabIndex = 5;
            this.moveDownBtn.Text = "Move Down";
            this.moveDownBtn.UseVisualStyleBackColor = false;
            this.moveDownBtn.Click += new System.EventHandler(this.MoveDownBtn_Click);
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
            this.startBtn.Location = new System.Drawing.Point(897, 315);
            this.startBtn.MinimumSize = new System.Drawing.Size(220, 40);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(220, 40);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.timeLbl.Location = new System.Drawing.Point(985, 21);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(118, 25);
            this.timeLbl.TabIndex = 7;
            this.timeLbl.Text = "00:00:00";
            // 
            // boringGameTimer
            // 
            this.boringGameTimer.Interval = 10;
            this.boringGameTimer.Tick += new System.EventHandler(this.boringGameTimer_Tick);
            // 
            // numCorrectLbl
            // 
            this.numCorrectLbl.AutoSize = true;
            this.numCorrectLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.numCorrectLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.numCorrectLbl.Location = new System.Drawing.Point(862, 27);
            this.numCorrectLbl.Name = "numCorrectLbl";
            this.numCorrectLbl.Size = new System.Drawing.Size(18, 17);
            this.numCorrectLbl.TabIndex = 20;
            this.numCorrectLbl.Text = "0";
            // 
            // numMovesMadeLbl
            // 
            this.numMovesMadeLbl.AutoSize = true;
            this.numMovesMadeLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.numMovesMadeLbl.ForeColor = System.Drawing.Color.BlueViolet;
            this.numMovesMadeLbl.Location = new System.Drawing.Point(538, 25);
            this.numMovesMadeLbl.Name = "numMovesMadeLbl";
            this.numMovesMadeLbl.Size = new System.Drawing.Size(18, 17);
            this.numMovesMadeLbl.TabIndex = 19;
            this.numMovesMadeLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(889, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "/ 10";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(158, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(178, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(617, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Num Books In Correct Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(66, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Progress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(425, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Moves Made:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(378, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book Shelf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(68, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Book Cart";
            // 
            // checkOrder
            // 
            this.checkOrder.AllowDrop = true;
            this.checkOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkOrder.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOrder.ForeColor = System.Drawing.Color.MediumPurple;
            this.checkOrder.FormattingEnabled = true;
            this.checkOrder.ItemHeight = 20;
            this.checkOrder.Location = new System.Drawing.Point(904, 67);
            this.checkOrder.Name = "checkOrder";
            this.checkOrder.Size = new System.Drawing.Size(199, 224);
            this.checkOrder.TabIndex = 23;
            // 
            // BoringGameOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1134, 711);
            this.Controls.Add(this.checkOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCorrectLbl);
            this.Controls.Add(this.numMovesMadeLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.moveDownBtn);
            this.Controls.Add(this.moveUpBtn);
            this.Controls.Add(this.BookShelfSortedListBox);
            this.Controls.Add(this.BookCartUnsortedListBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1150, 750);
            this.MinimumSize = new System.Drawing.Size(1150, 750);
            this.Name = "BoringGameOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Where That Book Go?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox BookCartUnsortedListBox;
        private System.Windows.Forms.ListBox BookShelfSortedListBox;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer boringGameTimer;
        private System.Windows.Forms.Label numCorrectLbl;
        private System.Windows.Forms.Label numMovesMadeLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox checkOrder;
    }
}