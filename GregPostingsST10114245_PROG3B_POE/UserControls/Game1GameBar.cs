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
namespace GregPostingsST10114245_PROG3B_POE.UserControls
{
    //Class
    public partial class Game1GameBar : UserControl
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
        public Game1GameBar()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are methods to start and keep track of the
        // time as well as to stop the timer.
        ////////////////////////////////////////////////////////

        //Timer Methods

        #region Timer

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Used to stop the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game1GameBar_Leave(object sender, EventArgs e)
        {
            //gameTimer1.Stop();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Used to change the time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer1_Tick(object sender, EventArgs e)
        {
            //h = 0;
            //m = 5;
            //s = 5;

            //s--;

            //timerLbl.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            //if (s == 0)
            //{
            //    s = 59;
            //    m -= 1;
            //}
            //if (m == 0)
            //{
            //    m = 59;
            //    h -= 1;
            //}

        }

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//