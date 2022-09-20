
//Imports
using GregPostingsST10114245_PROG3B_POE.Classes;
using GregPostingsST10114245_PROG3B_POE.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE
{
    //Class
    public partial class Game1 : Form
    {

        private DeweyDecimalNumberGenerator d = new DeweyDecimalNumberGenerator();
        private BookDrawing b = new BookDrawing();
        BookDrawing[] bookDrawings = new BookDrawing[10];

        //--------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructor
        /// </summary>
        public Game1()
        {
            /** Calling the InitializeComponent method*/
            InitializeComponent();


            

            for (int i = 0; i < bookDrawings.Count(); i++)
            {
                bookDrawings[i] = new BookDrawing();
                //bookDrawings[i].Controls.Add(Parent);

                flowLayoutPanel1.Controls.Add(bookDrawings[i]);

                //flowLayoutPanel1.Controls.GetChildIndex(bookDrawings[i]);
            }



            //BookDrawing[] bookDrawings = new BookDrawing[10];
            //BookDrawing bd = new BookDrawing();


            //for (int i = 0; i < bookDrawings.Count(); i++)
            //{
            //    bookDrawings[i] = new BookDrawing();
            //    //bookDrawings[i].Controls.Add(Parent);

            //    flowLayoutPanel1.Controls.Add(bookDrawings[i]);

            //    //bookDrawings[i].label1.Text;
            //    //bookDrawings[i].
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Show();
            //this.Hide();

            flowLayoutPanel1.Visible = true;

            //SystemSounds.Beep.Play();

            timer1.Start();
        }

        private void Game1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
        }



        //--------------------------------------------------------------------------------------------

        int s = 0;
        int m = 0;
        int h = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            
            if (s == 60)
            {
                s = 0;
                m += 1;
                //SystemSounds.Beep.Play();     Could be cool for countdown
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }

            label1.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.DoDragDrop(flowLayoutPanel1.Parent.Controls, DragDropEffects.Move);
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            //flowLayoutPanel2.Parent = e.Data.GetData(flowLayoutPanel2.Controls.GetChildIndex());
        }
    }
}
//------------------------------------ooo000 END OF FILE 000ooo---------------------------------------------//