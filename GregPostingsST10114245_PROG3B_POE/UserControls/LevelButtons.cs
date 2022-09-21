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
using GregPostingsST10114245_PROG3B_POE.Forms;
using System;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.UserControls
{
    //Class
    public partial class LevelButtons : UserControl
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
        public LevelButtons()
        {
            /** Calling the InitializeComponent method*/
            InitializeComponent();
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are all the button click methods used for
        // opening and closing different forms for navigation
        ////////////////////////////////////////////////////////

        //Button Click Methods

        #region Button Clicks Methods

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Level 1 Button Click Method - Opens the Game1 form and closes the Levels form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level1Btn_Click(object sender, EventArgs e)
        {
            //Would be used to change to amount of time available using the
            //TimerDecrease Method from the GameTimer class
            //And maybe also the number of letters and numbers available
            //To make it harder
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Level 2 Button Click Method - Opens the Game1 form and closes the Levels form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level2Btn_Click(object sender, EventArgs e)
        {
            //Would be used to change to amount of time available using the
            //TimerDecrease Method from the GameTimer class
            //And maybe also the number of letters and numbers available
            //To make it harder
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Level 3 Button Click Method - Opens the Game1 form and closes the Levels form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Level3Btn_Click(object sender, EventArgs e)
        {
            //Would be used to change to amount of time available using the
            //TimerDecrease Method from the GameTimer class
            //And maybe also the number of letters and numbers available
            //To make it harder
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Back Button Click Method - Opens the Game1GameMode form and closes the Levels form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the Game1GameMode form
                Game1GameMode game1GameMode = new Game1GameMode();
                //Showing the game1GameMode form
                game1GameMode.Show();
                //Hiding the Levels form
                this.ParentForm.Hide();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion
        
    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//