/*
 * Done By: Greg Postings ST10114245 
 * Module: PROG 3B
 * Class: BCA3 G7
 * Task: POE Task 1
 * Start Date and Time: 10 September 2022 at 14:30
 * Finish Date and Time: 21 September 2022 at 16:45
 * 
 */


//Impots
using GregPostingsST10114245_PROG3B_POE.Forms;
using System;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE
{
    //Class
    public partial class MainMenuButtons : UserControl
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
        public MainMenuButtons()
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
        /// Replace Books Button Click Method - Opens the Game1 form and closes the Main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplaceBooksBtn_Click(object sender, EventArgs e)
        {
            //Creating an object of the Game1GameMode form
            Game1GameMode game1GameMode = new Game1GameMode();
            //Showing the game1GameMode form
            game1GameMode.Show();
            //Hiding the Main Menu / Form1 form
            this.ParentForm.Hide();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Identify Area Button Click Method - Opens the Game2 form and closes the Main menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdentifyAreaBtn_Click(object sender, EventArgs e)
        {
            //Creating an object of the Game2 form
            Game2 game2 = new Game2();
            //Showing the Game2 form
            game2.Show();
            //Hiding the Main Menu / Form1 form
            this.ParentForm.Hide();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Find Call Num Button Click Method - Opens the Game3 form and closes the Main menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindCallNumBtn_Click(object sender, EventArgs e)
        {
            //Creating an object of the Game3 form
            Game3 game3 = new Game3();
            //Showing the Game3 form
            game3.Show();
            //Hiding the Main Menu / Form1 form
            this.ParentForm.Hide();
        }

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//