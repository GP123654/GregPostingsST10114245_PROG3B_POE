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
using System;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    //Class
    public partial class CustomMessageBox : Form
    {

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
        public CustomMessageBox()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            label2.Text = "Hello, Welcome to: where that book go?\n\n" +
                "In this game you will have to sort the books according to their call numbers.\n" +
                "You will have to sort them by their numbers first in ascending order and then by their letters";
            */


            this.Hide();
        }
    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//