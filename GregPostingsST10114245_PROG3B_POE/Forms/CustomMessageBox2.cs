
//Imports
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
            this.messageTitleLbl.Text = "Congradulations !";
            this.messageTextLbl.Text = "Well done. You completed the challange. Here is a badge for you.";
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will set the message to be a unsuccessful message
        /// </summary>
        public void RanOutOfTimeMessage()
        {
            this.messageTitleLbl.Text = "Oh No !!!";
            this.messageTextLbl.Text = "You were unable to finish the game in time. Keep trying and play again";
        }

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