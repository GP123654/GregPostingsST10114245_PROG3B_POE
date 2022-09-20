

//Imports
using GregPostingsST10114245_PROG3B_POE.WorkingGameClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    //Class
    public partial class BoringGameOne : Form
    {

        //Variables
        
        #region Most Of The Variables

        //----------------------------------------------------------------------------------------------//
        //Variables

        /// <summary>
        /// 
        /// </summary>
        private WGDeweyDecimalNumberGenerator wGDeweyDecimalNumberGenerator = new WGDeweyDecimalNumberGenerator();

        /// <summary>
        /// 
        /// </summary>
        private WGSortingAlgorithims wGSortingAlgorithims = new WGSortingAlgorithims();

        private int numberOfMoves = 0;
        private int totalNumberOfMoves;

        #endregion


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
                if (this.BookCartUnsortedListBox.SelectedItem != null)
                {
                    //It will be copied from the BookCartUnsortedListBox listbox to the BookShelfSortedListBox listbox
                    this.BookShelfSortedListBox.DoDragDrop(this.BookCartUnsortedListBox.SelectedItem.ToString(), DragDropEffects.Copy);
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
                this.BookShelfSortedListBox.Items.Add(e.Data.GetData(DataFormats.Text));
                //Removes the data from the BookCartUnsortedListBox listbox
                this.BookCartUnsortedListBox.Items.Remove(e.Data.GetData(DataFormats.Text));

                //BookShelfSortedListBox.Items.RemoveAt(BookShelfSortedListBox.SelectedIndex);


                CheckCallNumberOrder();

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
            if (this.BookShelfSortedListBox.SelectedItem != null)
            {
                //Stores the selected items index into an int called index
                int index = this.BookShelfSortedListBox.SelectedIndex;
                //Stores the selected item as a string in a string called selectedBook
                string selectedBook = this.BookShelfSortedListBox.SelectedItem.ToString();

                //If the index is bigger than 0 (so the top one cannot move up)
                if (index > 0)
                {
                    //The item at that index will be removed
                    this.BookShelfSortedListBox.Items.RemoveAt(index);
                    //Then the item will be inserted at an index one higher with its information
                    this.BookShelfSortedListBox.Items.Insert(index - 1, selectedBook);
                    //It keeps the selected item at its new position selected
                    this.BookShelfSortedListBox.SetSelected(index - 1, true);
                }


                CheckCallNumberOrder();

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
            if (this.BookShelfSortedListBox.SelectedItem != null)
            {
                //Stores the selected items index into an int called index
                int index = this.BookShelfSortedListBox.SelectedIndex;
                //Stores the selected item as a string in a string called selectedBook
                string selectedBook = this.BookShelfSortedListBox.SelectedItem.ToString();

                //If the index is less than the number of items - 1 (so the last one cannot move down)
                if (index < this.BookShelfSortedListBox.Items.Count - 1)
                {
                    //The item at that index will be removed
                    this.BookShelfSortedListBox.Items.RemoveAt(index);
                    //Then the item will be inserted at an index one lower with its information
                    this.BookShelfSortedListBox.Items.Insert(index + 1, selectedBook);
                    //It keeps the selected item at its new position selected
                    this.BookShelfSortedListBox.SetSelected(index + 1, true);
                }


                CheckCallNumberOrder();

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
        /// This will make the timer start and the book cart list visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                /** Calling the GenerateAndDisplyRandomNumbers Method */
                this.wGDeweyDecimalNumberGenerator.GenerateAndDisplyRandomNumbers(BookCartUnsortedListBox);
                //Starts the timer
                this.boringGameTimer.Start();
                //Disables the start button
                this.startBtn.Enabled = false;

                SortTest();
                //wGSortingAlgorithims.EasySort(checkOrder);
                //wGSortingAlgorithims.EasySortWithLINQ(checkOrder);
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion


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
        private int s = 40;

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
        private void boringGameTimer_Tick(object sender, EventArgs e)
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

                    //Disables the BookCartUnsortedListBox listbox
                    this.BookCartUnsortedListBox.Enabled = false;


                    CustomMessageBox2 customMessageBox2 = new CustomMessageBox2();
                    customMessageBox2.RanOutOfTimeMessage();
                    customMessageBox2.Show();

                }
            }           
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion






        //public void CheckCallNumberOrder2()
        //{
        //    deweyNums.Sort();
        //    int numInCorrectOrder = 0;

        //    //if (deweyNums.FindIndex(1) == BookShelfSortedListBox.Items.IndexOf(1))
        //    //{
        //    //    numCorrectLbl.Text = (numInCorrectOrder + 1).ToString();
        //    //}

        //    foreach (var num in deweyNums)
        //    {

        //    }

        //}

        //private int numInCorrectOrder = 0;

        //public void CheckCallNumberOrder()
        //{
        //    numCorrectLbl.Text = "0";
        //    deweyNums.Sort();

        //    if (BookShelfSortedListBox.Items != null)
        //    {

        //            if (deweyNums[0].ToString() == BookShelfSortedListBox.Items.IndexOf(1).ToString())
        //            {
        //                numCorrectLbl.Text = (numInCorrectOrder + 1).ToString();
        //            }


        //    }


        //}


        private int numInCorrectOrder = -1;
         

        public void CheckCallNumberOrder()
        {

            //checkOrder.Items.Clear();
            //wGDeweyDecimalNumberGenerator.deweyNums.Sort();


            //foreach (var num in wGDeweyDecimalNumberGenerator.deweyNums)
            //{
            //    if (BookShelfSortedListBox.Items.IndexOf(1).ToString() == num[1].ToString())
            //    {
            //        numCorrectLbl.Text = "5";//(numInCorrectOrder + 1).ToString();
            //    }
            //    if (checkOrder.Items.IndexOf(1).ToString() == BookShelfSortedListBox.Items.IndexOf(1).ToString())
            //    {
            //        numCorrectLbl.Text = "3";//(numInCorrectOrder + 1).ToString();
            //    }
            //    if (checkOrder.Items.IndexOf(1).ToString() == BookShelfSortedListBox.Items.IndexOf(2).ToString())
            //    {
            //        numCorrectLbl.Text = "37";//(numInCorrectOrder + 1).ToString();
            //    }
            //}


            //switch (sortedDewey.Count())
            //{
            //    case 0:
            //        // code block
            //        break;
            //    case 2:
            //        // code block
            //        break;
            //    default:
            //        // code block
            //        break;
            //}

            //deweyNums.Sort();


            //numCorrectLbl.Text = "0";



            if (this.BookShelfSortedListBox.Items.IndexOf(0).ToString() == this.BookShelfSortedListBox.Items.IndexOf(0).ToString())
            {
                this.numCorrectLbl.Text = "5";//(numInCorrectOrder + 1).ToString();
            }
            if (this.checkOrder.Items.IndexOf(1).ToString() == this.BookShelfSortedListBox.Items.IndexOf(1).ToString())
            {
                this.numCorrectLbl.Text = "3";//(numInCorrectOrder + 1).ToString();
            }
            if (this.checkOrder.Items.IndexOf(1).ToString() == this.BookShelfSortedListBox.Items.IndexOf(2).ToString())
            {
                this.numCorrectLbl.Text = "37";//(numInCorrectOrder + 1).ToString();
            }


        }

        public void IncreaseNumberOfMoves()
        {
            totalNumberOfMoves = numberOfMoves + 1;
            numberOfMoves = totalNumberOfMoves;
            numMovesMadeLbl.Text = (totalNumberOfMoves).ToString();
        }





        public void SortTest()
        {
            this.checkOrder.Items.Clear();
            this.wGDeweyDecimalNumberGenerator.deweyNums.Sort();


            foreach (var num in this.wGDeweyDecimalNumberGenerator.deweyNums)
            {
                this.checkOrder.Items.Add(num);
            }
        }

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//


//                                          _________
//                                         |         |
//                                         |         |                                          
//                                         |         |                                          
//                                         |         |                                          
//                               __________|         |__________
//                              |                               |
//                              |                               |                                          
//                              |__________           __________|                                          
//                                         |         |                    
//                                         |         |                                           
//                                         |         |                                           
//                                         |         |                                           
//                                         |         |                                           
//                                         |         |                                           
//                                         |         |                                           
//                                         |         |
//                                         |         |
//                                         |         |
//                                         |         | 
//    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ |_________| //////////////////////////////////

//                      Whatever you do, work at it with all your heart,
//                           as working for the Lord, not for men
//                                                - Colossians 3: 23 NIV

//    ///////////////////////////////////////////////////////////////////////////////////