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
using GregPostingsST10114245_PROG3B_POE.Forms;
using System;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.UserControls
{
    //Class
    public partial class Game1GameModeButtons : UserControl
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
        public Game1GameModeButtons()
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
        /// High Score Button Click Method - Opens the Game1 form and closes the Game1GameMode form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the Game1 form
                Game1 game1 = new Game1();
                //Showing the Game1 form
                game1.Show();
                //Hiding the Game Mode Menu / Game1GameMode form
                this.ParentForm.Hide();


                //Trying to set the game mode using a boolean could also use an enum
                GameTimer gt = new GameTimer();
                //Setting the game mode to high score
                gt.GameModeHS = true;


                //Creating an object of the CustomMessageBox form
                CustomMessageBox cmb = new CustomMessageBox();
                //Shows the instructions in the custom message box
                cmb.Show();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Time Trial Button Click Method - Opens the Levels form and closes the Game1GameMode form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeTraialBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the Levels form
                Levels levels = new Levels();
                //Showing the Levels form
                levels.Show();
                //Hiding the Game Mode Menu / Game1GameMode form
                this.ParentForm.Hide();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Working Game Button Click Method - Opens the BoringGameOne form and closes the Game1GameMode form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkingGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the BoringGameOne form
                BoringGameOne boringGameOne = new BoringGameOne();
                //Showing the BoringGameOne form
                boringGameOne.Show();
                //Hiding the Game Mode Menu / Game1GameMode form
                this.ParentForm.Hide();


                //Creating an object of the CustomMessageBox form
                CustomMessageBox cmb = new CustomMessageBox();
                //Shows the instructions in the custom message box
                cmb.Show();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Back Button Click Method - Opens the Form1 form and closes the Game1GameMode form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the Form1 form
                Form1 mainMenu = new Form1();
                //Showing the Form1 form
                mainMenu.Show();
                //Hiding the Game Mode Menu / Game1GameMode form
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