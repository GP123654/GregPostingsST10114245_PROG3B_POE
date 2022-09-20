

//Imports
using GregPostingsST10114245_PROG3B_POE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.UserControls
{
    //Class
    public partial class BookDrawing : UserControl
    {
        //Variables

        #region Most Of The Variables

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a object of the DeweyDecimalNumberGenerator
        /// </summary>
        private DeweyDecimalNumberGenerator d = new DeweyDecimalNumberGenerator();

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a object of the Random class that stor numbers up to 255 for the color of the books
        /// </summary>
        private readonly Random RandomNumber = new Random(255);

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Storing the books color
        /// </summary>
        private Brush BookColor;

        #endregion


        ////////////////////////////////////////////////////////
        // This is the default contructor used to initialize
        // all the different components and to populate all
        // the labels of the books.
        ////////////////////////////////////////////////////////

        //Constructor

        #region Constructor

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructor
        /// </summary>
        public BookDrawing()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();

            //TESTS - DONT WORK

            #region TESTS

            //DeweyDecimalNumberGenerator dd = new DeweyDecimalNumberGenerator();

            //for (int i = 0; i < 10; i++)
            //{
            //    d.DeweyNums.Add(d.RandomDNumber());
            //}

            //---------------------------------------------

            //for (int i = 0; i < 10; i++)
            //{
            //    DeweyDecimalNumberGenerator.DeweyNums.Add(d.RandomDNumber());
            //    label1.Text = DeweyDecimalNumberGenerator.DeweyNums.ToArray().ToString();
            //}

            //---------------------------------------------

            //for (int i = 0; i < 10; i++)
            //{
            //    label1.Text = d.RandomDNumber();
            //}

            //---------------------------------------------

            //for (int i = 0; i < 10; i++)
            //{
            //    dd.deweyNums.Add(d.RandomDNumber());
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    label1.Text = dd.deweyNums[i];
            //}

            //---------------------------------------------

            #endregion


            for (int i = 0; i < 10; i++)
            {
                d.deweyNums.Add(d.RandomDNumber());
            }
            DisplayList(label1, d.deweyNums);

        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is just setting the label of the books to a
        // random dewey decimal number that is stored in a list.
        ////////////////////////////////////////////////////////

        //Displaying Dewey Decimal Numbers

        #region Displaying Dewey Decimal Numbers

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will add a specified List<string> to the a specified label of a book
        /// </summary>
        /// <param name="list"></param>
        public void DisplayList(Label a, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            { 
                //Sets the book label to a dewey decimal number from the list
                a.Text = list[i];
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is used for drawing the book and giving them
        // random colors using graphics. 
        ////////////////////////////////////////////////////////

        //Drawing Books

        #region Drawing Books

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Used for drawing the books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookDrawing_Paint(object sender, PaintEventArgs e)
        {
            //Brush brush = new SolidBrush(Color.Red);

            //White color for the label
            Brush brush2 = new SolidBrush(Color.White);

            //Random color for each book
            var color = Color.FromArgb((byte)this.RandomNumber.Next(), (byte)this.RandomNumber.Next(), (byte)this.RandomNumber.Next());
            //Setting the color of the book to a random color
            this.BookColor = new SolidBrush(color);


            Graphics g = e.Graphics;
            //Main book
            g.FillRectangle(this.BookColor, 0, 0, 200, 800);
            //Book label
            g.FillRectangle(brush2, 5, 180, 80, 50);
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are just tests CAN DELETE 
        ////////////////////////////////////////////////////////

        //TESTS - DONT WORK

        #region TESTS

        //public void Something()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        d.deweyNums.Add(d.RandomDNumber());
        //    }
        //    DisplayList(d.deweyNums);
        //}

        //public void DisplayList(List<string> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    { 
        //        d.deweyNums.Add(list[i]);
        //    }
        //}

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//