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
    public partial class CustomMessageBox2 : Form
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
        public CustomMessageBox2()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();
        }

        #endregion

        ////////////////////////////////////////////////////////
        // These methods set the text of the custom message box
        // to either congradulate the user or encorage them if 
        // they were unsuccessful.
        ////////////////////////////////////////////////////////
        
        //Setting message text

        #region Setting The Message Text

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will set the message to be a congratulatory message
        /// </summary>
        public void CongradulationsMessage()
        {
            try
            {
                //This sets the heading/ title of the CustomMessageBox2 message box
                this.messageTitleLbl.Text = "Congradulations !";
                //This sets the message of the CustomMessageBox2 message box
                this.messageTextLbl.Text = "Well done. You completed the challange. Here is a badge for you.";
                //This sets the button text of the CustomMessageBox2 message box
                this.UnderstandBtn.Text = "Thank you";
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }            
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will set the message to be a unsuccessful message
        /// </summary>
        public void RanOutOfTimeMessage()
        {
            try
            {
                //This sets the heading/ title of the CustomMessageBox2 message box
                this.messageTitleLbl.Text = "Oh No !!!";
                //This sets the message of the CustomMessageBox2 message box
                this.messageTextLbl.Text = "You were unable to finish the game in time. Keep trying and play again";
                //This sets the button text of the CustomMessageBox2 message box
                this.UnderstandBtn.Text = "I understand";
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }            
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
        /// Understand Button Click Method - Closes the CustomMessageBox2 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnderstandBtn_Click(object sender, EventArgs e)
        {
            //Hiding the CustomMessageBox2 form
            this.Hide();
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are just tests
        ////////////////////////////////////////////////////////

        //TESTS

        #region TESTS

        /*
        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Exit Button Click Method - Closes the CustomMessageBox2 and the BoringGameOne form and opens the Form1/ MianMenu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the BoringGameOne form
                BoringGameOne boringGameOne = new BoringGameOne();
                //Hiding the BoringGameOne form - This does not work
                boringGameOne.Hide();


                //Creating an object of the Form1 form
                Form1 mainMenu = new Form1();
                //Showing the Form1 form
                mainMenu.Show();


                //Hiding the CustomMessageBox2 message box
                this.Hide();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Play Again Or Try Again Button Click Method - Closes the CustomMessageBox2 form and enables or makes buttons vissible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayTryAgainBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an object of the BoringGameOne form
                BoringGameOne boringGameOne = new BoringGameOne();
                //Making the start button enabled - Does not work
                boringGameOne.startBtn.Enabled = true;
                //So tried making a play again button - Does not work
                boringGameOne.tryAgainBtn.Visible = true;

                //Hiding the CustomMessageBox2 message box
                this.Hide();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        */

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//



//                              __________          __________
//                             /          \        /          \
//                            /            \      /            \
//                           /              \    /              \
//                           |               \  /                |
//                           |                \/                 |
//                            \                                 /
//                             \                               /
//                              \                             /
//                               \                           /
//                                \                         /
//                                 \                       /
//                                  \                     /
//                                   \                   /
//                                    \                 /
//                                     \               /
//                                      \             /
//                                       \           /
//                                        \         /
//                                         \       /
//                                          \     /
//                                           \   /
//                                            \ /

//                            "For God so loved the world that he
//                              gave his one and only son, that
//                               whoever believes in him shall
//                                    not perish but have
//                                       eternal life
//                                                  - John 3:16