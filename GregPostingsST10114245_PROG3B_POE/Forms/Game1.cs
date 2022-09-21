/*
 * Done By: Greg Postings ST10114245 
 * Module: PROG 3B
 * Class: BCA3 G7
 * Task: POE Task 1
 * Start Date and Time: 10 September 2022 at 14:30
 * Finish Date and Time: 21 September 2022 at 16:45
 * 
 */


//Imports
using GregPostingsST10114245_PROG3B_POE.Classes;
using GregPostingsST10114245_PROG3B_POE.UserControls;
using System;
using System.Linq;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE
{
    //Class
    public partial class Game1 : Form
    {

        /// <summary>
        /// 
        /// </summary>
        private DeweyDecimalNumberGenerator d = new DeweyDecimalNumberGenerator();

        /// <summary>
        /// 
        /// </summary>
        private BookDrawing b = new BookDrawing();

        /// <summary>
        /// 
        /// </summary>
        BookDrawing[] bookDrawings = new BookDrawing[10];


        ////////////////////////////////////////////////////////
        // This is the default contructor used to initialize
        // all the different components.
        ////////////////////////////////////////////////////////

        //Constructor

        #region Constructor

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
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

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Show();
            //this.Hide();

            flowLayoutPanel1.Visible = true;

            //SystemSounds.Beep.Play();

            timer1.Start();
        }

        /// <summary>
        /// Goes back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Creating an object of the Form1 form
            Form1 mainMenu = new Form1();
            //Showing the Form1 form
            mainMenu.Show();
            //Hiding the Game Mode Menu / Game1GameMode form
            this.Hide();
        }



        //--------------------------------------------------------------------------------------------

        int s = 0;
        int m = 0;
        int h = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.DoDragDrop(flowLayoutPanel1.Parent.Controls, DragDropEffects.Move);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            //flowLayoutPanel2.Parent = e.Data.GetData(flowLayoutPanel2.Controls.GetChildIndex());
        }
    }
}
//------------------------------------ooo000 END OF FILE 000ooo---------------------------------------------//