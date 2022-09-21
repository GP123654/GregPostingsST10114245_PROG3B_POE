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
using GregPostingsST10114245_PROG3B_POE.WorkingGameClasses;
using System;
using System.Media;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    //Class
    public partial class BoringGameOne : Form
    {

        ////////////////////////////////////////////////////////
        // These are different variables that are being declared
        // and some are being initialized as well. They are used
        // for storing different values and some are objects of
        // classes.
        ////////////////////////////////////////////////////////

        //Variables

        #region Variables

        //----------------------------------------------------------------------------------------------//
        //Variables

        /// <summary>
        /// Creating an object of the WGDeweyDecimalNumberGenerator class
        /// </summary>
        private WGDeweyDecimalNumberGenerator wGDeweyDecimalNumberGenerator = new WGDeweyDecimalNumberGenerator();

        /// <summary>
        /// Creating an object of the WGSortingAlgorithims class
        /// </summary>
        private WGSortingAlgorithims wGSortingAlgorithims = new WGSortingAlgorithims();

        /// <summary>
        /// This stores the numbers of moves made by the user
        /// </summary>
        private int numberOfMoves = 0;

        /// <summary>
        /// This stores the total numbers of moves made by the user
        /// </summary>
        private int totalNumberOfMoves;

        /// <summary>
        /// This stores the number of correct items in order
        /// </summary>
        private int itemCheckCount = 0;

        /// <summary>
        /// This stores the amount of progress the user has made in the game
        /// </summary>
        private int progressBar = 0;

        /// <summary>
        /// This stores the total amount of progress the user has made in the game
        /// </summary>
        private int totalProgressBar;

        #endregion


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
        public BoringGameOne()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();           
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is used for the dragging and dropping of call
        // numbers from the book cart to the book shelf.
        ////////////////////////////////////////////////////////

        //Drag And Drop Methods

        #region Drag And Drop

        //----------------------------------------------------------------------------------------------//
        //Drag And Drop Methods

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This starts the dragging when you click and hold the left mouse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookCartUnsortedListBox_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //If the user drags a valid item
                if (this.bookCartUnsortedListBox.SelectedItem != null)
                {
                    //It will be copied from the BookCartUnsortedListBox listbox to the BookShelfSortedListBox listbox
                    this.bookShelfSortedListBox.DoDragDrop(this.bookCartUnsortedListBox.SelectedItem.ToString(), DragDropEffects.Copy);
                }
                else
                {
                    //Error message
                    MessageBox.Show("Please select a valid item");
                }
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }  
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start dragging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookShelfSortedListBox_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                //If there is data
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    //It copys the data
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    //No effect takes place
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }            
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This adds items to the BookShelfSortedListBox listbox and removes them from the BookCartUnsortedListBox listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookShelfSortedListBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //Adds the data to the BookShelfSortedListBox listbox
                this.bookShelfSortedListBox.Items.Add(e.Data.GetData(DataFormats.Text));
                //Removes the data from the BookCartUnsortedListBox listbox
                this.bookCartUnsortedListBox.Items.Remove(e.Data.GetData(DataFormats.Text));

                //BookShelfSortedListBox.Items.RemoveAt(BookShelfSortedListBox.SelectedIndex);


                SuccessfulCompletionCheck();

                IncreaseNumberOfMoves();
                
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }
        
        //Not being used

        #region Not Used

        //----------------------------------------
        //DONT THINK THESE ARE DOING ANYTHING

        //They were supposed to be able to reorder the
        //items in the bookshelf by dragging and dropping

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookShelfSortedListBox_MouseDown(object sender, MouseEventArgs e)
        {
            //if (BookShelfSortedListBox.SelectedItem != null)
            //{
            //    BookShelfSortedListBox.DoDragDrop(BookShelfSortedListBox.SelectedIndex.ToString(), DragDropEffects.Move);

            //    //string d = BookShelfSortedListBox.SelectedIndex.ToString();

            //}
            //else
            //{
            //    MessageBox.Show("Please select a valid item");
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookShelfSortedListBox_DragOver(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Move;
        }

        //--------------------------------------------------------

        #endregion


        #endregion


        ////////////////////////////////////////////////////////
        // These are all the button click methods used for
        // opening and closing different forms for navigation
        ////////////////////////////////////////////////////////

        //Button Click Methods

        #region Button Clicks

        //----------------------------------------------------------------------------------------------//
        //Button Click Methods

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This moves the selected listbox item up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            //If the user selects a valid item
            if (this.bookShelfSortedListBox.SelectedItem != null)
            {
                //Stores the selected items index into an int called index
                int index = this.bookShelfSortedListBox.SelectedIndex;
                //Stores the selected item as a string in a string called selectedBook
                string selectedBook = this.bookShelfSortedListBox.SelectedItem.ToString();

                //If the index is bigger than 0 (so the top one cannot move up)
                if (index > 0)
                {
                    //The item at that index will be removed
                    this.bookShelfSortedListBox.Items.RemoveAt(index);
                    //Then the item will be inserted at an index one higher with its information
                    this.bookShelfSortedListBox.Items.Insert(index - 1, selectedBook);
                    //It keeps the selected item at its new position selected
                    this.bookShelfSortedListBox.SetSelected(index - 1, true);
                }

                /** Calling the SuccessfulCompletionCheck Method */
                SuccessfulCompletionCheck();

                /** Calling the IncreaseNumberOfMoves Method */
                IncreaseNumberOfMoves();
            }
            else
            {
                //Error message
                MessageBox.Show("Please select a valid item");
            }

        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This moves the selected listbox item down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            //If the user selects a valid item
            if (this.bookShelfSortedListBox.SelectedItem != null)
            {
                //Stores the selected items index into an int called index
                int index = this.bookShelfSortedListBox.SelectedIndex;
                //Stores the selected item as a string in a string called selectedBook
                string selectedBook = this.bookShelfSortedListBox.SelectedItem.ToString();

                //If the index is less than the number of items - 1 (so the last one cannot move down)
                if (index < this.bookShelfSortedListBox.Items.Count - 1)
                {
                    //The item at that index will be removed
                    this.bookShelfSortedListBox.Items.RemoveAt(index);
                    //Then the item will be inserted at an index one lower with its information
                    this.bookShelfSortedListBox.Items.Insert(index + 1, selectedBook);
                    //It keeps the selected item at its new position selected
                    this.bookShelfSortedListBox.SetSelected(index + 1, true);
                }


                /** Calling the SuccessfulCompletionCheck Method */
                SuccessfulCompletionCheck();

                /** Calling the IncreaseNumberOfMoves Method */
                IncreaseNumberOfMoves();
            }
            else
            {
                //Error message
                MessageBox.Show("Please select a valid item");
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Start Button Click Method - This will make the timer start and the book cart list visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /** Calling the GenerateAndDisplyRandomNumbers Method */
                this.wGDeweyDecimalNumberGenerator.GenerateAndDisplyRandomNumbers(bookCartUnsortedListBox);
                //Starts the boringGameTimer timer
                this.boringGameTimer.Start();
                //Hides the startBtn button
                this.startBtn.Visible = false;

                /** Calling the SortList Method */
                SortList();
                
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Try Again Button Click Method - Lets you play the game again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TryAgainBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /** Calling the Reset Method */
                Reset();

                //Hides the tryAgainBtn button
                this.tryAgainBtn.Visible = false;

                /** Calling the GenerateAndDisplyRandomNumbers Method */
                this.wGDeweyDecimalNumberGenerator.GenerateAndDisplyRandomNumbers(bookCartUnsortedListBox);
                //Starts the timer
                this.boringGameTimer.Start();

                /** Calling the SortList Method */
                SortList();

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are for resetting all the gamification features
        // for when the user wants to play again.
        ////////////////////////////////////////////////////////

        //Reset Gamification Features Method

        #region Reset Gamification Features

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This resets all the gamification features
        /// </summary>
        public void Reset()
        {
            try
            {
                //Resetting the listBoxes
                this.bookCartUnsortedListBox.Items.Clear();
                this.bookShelfSortedListBox.Items.Clear();
                this.checkOrderListBox.Items.Clear();

                //Resetting the timer
                this.ms = 1;
                this.s = 45;
                this.m = 0;

                //Resetting the progressBar
                this.totalProgressBar = 0;
                this.progressBar = 0;
                this.gameProgressBar.Value = 0;

                //Resetting the numbers in the correct order
                this.itemCheckCount = 0;
                this.numCorrectLbl.Text = "";

                //Resetting the number of moves
                this.numberOfMoves = 0;
                this.totalNumberOfMoves = 0;
                this.numMovesMadeLbl.Text = "";

                //Resetting the deweyNums List list of numbers
                this.wGDeweyDecimalNumberGenerator.deweyNums.Clear();
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are methods to start and keep track of the
        // time as well as to stop the timer as well as a few
        // extra things.
        ////////////////////////////////////////////////////////

        //Timer Methods

        #region Timer

        //----------------------------------------------------------------------------------------------//
        //Timer variables

        /// <summary>
        /// Miliseconds for timer
        /// </summary>
        private int ms = 1;

        /// <summary>
        /// Seconds for timer
        /// </summary>
        private int s = 45;

        /// <summary>
        /// Minutes for timer
        /// </summary>
        private int m = 0;

        //----------------------------------------------------------------------------------------------//
        //Timer Methods

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is the timer tick method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoringGameTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //Decreases the miliseconds each time the timer ticks
                ms--;

                if (ms == 0)
                {
                    ms = 60;
                    s -= 1;

                    /** Calling the Beep Method */
                    Beeps();
                }
                if (s == 0)
                {
                    s = 60;
                    m -= 1;
                }

                /** Calling the OutOfTimeStopTimer Method */
                OutOfTimeStopTimer();


                //This formats the timer label
                this.timeLbl.Text = String.Format("{0}:{1}:{2}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(2, '0'));
            }          
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will play the beeping sound
        /// </summary>
        public void Beeps()
        {
            try
            {
                //If the timer gets to 10 seconds beeps will be played every second
                if (s <= 9)
                {
                    //Plays the beeping sound
                    SystemSounds.Beep.Play();
                }
            }          
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is for if you run out of time
        /// </summary>
        public void OutOfTimeStopTimer()
        {
            try
            {
                //If the timer runs out of time
                if (m == -1 && s == 60 && ms == 60)
                {
                    //Stoping the timer
                    this.boringGameTimer.Stop();

                    //Sets the time label to 00:00:00
                    ms = 0;
                    s = 0;
                    m = 0;

                    //Creating an object of the CustomMessageBox2 form
                    CustomMessageBox2 customMessageBox2 = new CustomMessageBox2();
                    //Setting the message to the ran out of time message
                    customMessageBox2.RanOutOfTimeMessage();
                    //Showing the CustomMessageBox2 form
                    customMessageBox2.Show();

                    //Makes the tryAgainBtn button visible
                    this.tryAgainBtn.Visible = true;
                }
            }           
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are methods that are used to keep track of all
        // the gamification features.
        ////////////////////////////////////////////////////////

        //Miscellaneous Gamification Feature Methods

        #region Miscellaneous Gamification Features

        //----------------------------------------------------------------------------------------------//
        //Miscellaneous Methods

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This checks to see if the user has finished the game successfully
        /// </summary>
        public void SuccessfulCompletionCheck()
        {
            //If the the number of items in the correct order is equal to 10
            if (this.itemCheckCount.ToString().Equals("9"))
            {
                //This stops the boringGameTimer timer
                this.boringGameTimer.Stop();

                //Creating an object of the CustomMessageBox2 form
                CustomMessageBox2 customMessageBox2 = new CustomMessageBox2();
                //Setting the message to the congradulations message
                customMessageBox2.CongradulationsMessage();

                //If the seconds left after the timer stops is more than or equal to 15
                if (s >= 15)
                {
                    //Shows the achievementImage1 gold achievement image
                    customMessageBox2.achievementImage1.Visible = true;
                }
                //If the seconds left after the timer stops is less than or equal to 14 and more than or equal to 6
                if (s <= 14 && s >= 6)
                {
                    //Shows the achievementImage2 silver achievement image
                    customMessageBox2.achievementImage2.Visible = true;
                }
                //Otherwise if the seconds left after the timer stops is less than or equal to 5 and more than 0
                else if (s <= 5 && s > 0)
                {
                    //Shows the achievementImage3 bronze achievement image
                    customMessageBox2.achievementImage3.Visible = true;
                }

                //Showing the CustomMessageBox2 form
                customMessageBox2.Show();

                //Makes the tryAgainBtn button visible
                this.tryAgainBtn.Visible = true;
            }
            //Otherwise it will continue to check if the items are in the correct order
            else
            {
                /** Calling the CheckCallNumberOrder Method */
                CheckCallNumberOrder();
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This makes sure that each item is in the correct order
        /// </summary>
        public void CheckCallNumberOrder()
        {
            //For as long as bookShelfSortedListBox listBox item count is more than 0
            for (int i = 0; i < this.bookShelfSortedListBox.Items.Count; i++)
            {
                //If the bookShelfSortedListBox listBox items are equal to the checkOrderListBox ListBox items at the same index/ location
                if (this.bookShelfSortedListBox.Items[i] == this.checkOrderListBox.Items[i])
                {
                    //Making the items in the checkOrderListBox equal 1 when it is correct
                    //so that the indexes don't change but it does'nt add multiple points
                    this.checkOrderListBox.Items[i] = 1;
                    //Increases the number of items in the correct order by 1 each time 
                    this.itemCheckCount++;
                    /** Calling the CheckCallNumberOrder Method */
                    IncreaseProgressBar();
                    //Changing the numCorrectLbl label to display the number of correct items
                    this.numCorrectLbl.Text = itemCheckCount.ToString();
                }
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This increases the progress that the user makes with the game
        /// </summary>
        public void IncreaseProgressBar()
        {
            //Setting the totalProgressBar value to equal the progressBar value plus 10
            this.totalProgressBar = this.progressBar + 10;
            //Setting the progressBar value to equal the totalProgressBar value
            this.progressBar = this.totalProgressBar;
            //Setting the value of the gameProgressBar progress bar to equal the totalProgressBar value
            this.gameProgressBar.Value = this.totalProgressBar;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This increases the amount of moves that the user makes
        /// </summary>
        public void IncreaseNumberOfMoves()
        {
            //Setting the totalNumberOfMoves value to equal the numberOfMoves value plus 1
            this.totalNumberOfMoves = this.numberOfMoves + 1;
            //Setting the numberOfMoves value to equal the totalNumberOfMoves value
            this.numberOfMoves = this.totalNumberOfMoves;
            //Setting the text of the numMovesMadeLbl label to equal the totalNumberOfMoves value
            this.numMovesMadeLbl.Text = (this.totalNumberOfMoves).ToString();
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This method is used for sorting the deweyNums List
        ////////////////////////////////////////////////////////

        //Sorting The DeweyNums List Method

        #region Sorting The DeweyNums List

        //----------------------------------------------------------------------------------------------//
        //Sorting Methods

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to sort the list of dewey decimal numbers
        /// </summary>
        public void SortList()
        {
            //Clearing the values of the checkOrderListBox listBox
            this.checkOrderListBox.Items.Clear();
            //Sorting the deweyNums List<string>
            this.wGDeweyDecimalNumberGenerator.deweyNums.Sort();

            //Other sorting methods 
            //wGSortingAlgorithims.EasySort(checkOrderListBox);
            //wGSortingAlgorithims.EasySortWithLINQ(checkOrderListBox);
            //wGSortingAlgorithims.BubbleSort(this.wGDeweyDecimalNumberGenerator.deweyNums.ToArray());
            //wGSortingAlgorithims.QuickSort(this.wGDeweyDecimalNumberGenerator.deweyNums.ToArray());

            //For each number in the deweyNums List<string> 
            foreach (var num in this.wGDeweyDecimalNumberGenerator.deweyNums)
            {
                //Will be added to the checkOrderListBox listBox in the sorted order
                this.checkOrderListBox.Items.Add(num);
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is for when the BoringGameOne form is closing.
        ////////////////////////////////////////////////////////

        //BoringGameOne Form Closing Method

        #region BoringGameOne Form Closing Method

        //----------------------------------------------------------------------------------------------//
        //Form Closing Methods

        /// <summary>
        /// BoringGameOne Closing Method - It will take you back to the main menu / Form1 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoringGameOne_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Creating an object of the Form1 form
            Form1 mainMenu = new Form1();
            //Showing the Form1 form
            mainMenu.Show();
            //Hiding the Game Mode Menu / Game1GameMode form
            this.Hide();
        }

        #endregion
       
    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//


//                                              _________
//                                             |         |
//                                             |         |                                          
//                                             |         |                                          
//                                             |         |                                          
//                                   __________|         |__________
//                                  |                               |
//                                  |                               |                                          
//                                  |__________           __________|                                          
//                                             |         |                    
//                                             |         |                                           
//                                             |         |                                           
//                                             |         |                                           
//                                             |         |                                           
//                                             |         |                                           
//                                             |         |                                           
//                                             |         |
//                                             |         |
//                                             |         |
//                                             |         | 
//        \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |_________| //////////////////////////////////

//                          Whatever you do, work at it with all your heart,
//                               as working for the Lord, not for men
//                                                    - Colossians 3: 23 NIV

//        ///////////////////////////////////////////////////////////////////////////////////