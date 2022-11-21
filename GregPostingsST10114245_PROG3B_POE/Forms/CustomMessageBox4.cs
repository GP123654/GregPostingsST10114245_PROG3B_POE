
//Imports
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    //Class
    public partial class CustomMessageBox4 : Form
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
        public CustomMessageBox4()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are all the button click methods used for
        // opening and closing different forms for navigation
        ////////////////////////////////////////////////////////

        //Button Click Methods

        #region Button Clicks Methods

        /// <summary>
        /// Ready Button Click Method - closes the CustomMessageBox form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadyButton_Click(object sender, System.EventArgs e)
        {
            //Hide the CustomMessageBox form
            this.Hide();
        }

        #endregion

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//