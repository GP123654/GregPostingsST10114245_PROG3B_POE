/*
 * Done By: Greg Postings ST10114245 
 * Module: PROG 3B
 * Class: BCA3 G7
 * Task: POE Task 2
 * Start Date and Time: 19 October 2022 at 9:30
 * Finish Date and Time: 25 October 2022 at 15:20
 * 
 */


//Imports
using GregPostingsST10114245_PROG3B_POE.Game2Classes;
using System;
using System.Media;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    //Class
    public partial class Game2 : Form
    {

        ////////////////////////////////////////////////////////
        // These are different variables that are being declared
        // and some are being initialized as well. They are used
        // for storing different values and some are objects of
        // classes.
        ////////////////////////////////////////////////////////

        //Variables

        #region Variables

        /// <summary>
        /// Creating an object of the Dictionary class
        /// </summary>
        private Dictionary dictionary = new Dictionary();


        /// <summary>
        /// Miliseconds for timer
        /// </summary>
        private int ms = 1;

        /// <summary>
        /// Seconds for timer
        /// </summary>
        private int s = 50;

        /// <summary>
        /// Minutes for timer
        /// </summary>
        private int m = 0;


        /// <summary>
        /// This will determine the setup of the questions and answers
        /// by keeping track of how many times the user has played the game
        /// </summary>
        private int counter;


        /// <summary>
        /// This keeps track of the number of correct answers the user gets
        /// </summary>
        private int answersCorrect;


        /// <summary>
        /// Creating an object of the CustomMessageBox2 form
        /// </summary>
        CustomMessageBox2 customMessageBox2 = new CustomMessageBox2();


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
        public Game2()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();

            //Populating the dicionaries
            dictionary.Pop();
            dictionary.Pop2();

            //Making the labels not visible
            LabelVisibility(false);

            //Making the check answer button invisible
            checkAnswersBtn.Visible = false;
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This will randomly assign values to the different
        // colunms with corresponding matching answer and three
        // random incorrect values. It has three different
        // setups to add a bit more randomness and replayability
        // to the game.
        ////////////////////////////////////////////////////////

        //Setup Methods

        #region Different Setups To Make It Slightly More Random

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is a  setup for the different questions and answers that populate the different 
        /// textboxes with random values from the dictionaries. It also makes sure that there is 
        /// a corresponding matching question for each of the answers.
        /// </summary>
        public void RandomQandA1()
        {
            //Setting the answer lables
            answer1Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            answer3Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            answer4Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];
            answer2Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];

            //Setting the question lables
            question1Lbl.Text = dictionary.bookQna[answer2Lbl.Text];
            question2Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            question3Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];
            question4Lbl.Text = dictionary.bookQna2[answer1Lbl.Text];
            question5Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            question6Lbl.Text = dictionary.bookQna2[answer3Lbl.Text];
            question7Lbl.Text = dictionary.bookQna[answer4Lbl.Text];

            //Changing the counter value so that it changes the setup of the questions and answers
            counter = 2;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is a  setup for the different questions and answers that populate the different 
        /// textboxes with random values from the dictionaries. It also makes sure that there is 
        /// a corresponding matching question for each of the answers.
        /// </summary>
        public void RandomQandA2()
        {
            //Setting the answer lables
            answer3Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            answer4Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            answer1Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];
            answer2Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];

            //Setting the question lables
            question1Lbl.Text = dictionary.bookQna[answer2Lbl.Text];
            question2Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            question5Lbl.Text = dictionary.bookQna[answer1Lbl.Text];
            question7Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            question3Lbl.Text = dictionary.bookQna2[answer3Lbl.Text];
            question4Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];
            question6Lbl.Text = dictionary.bookQna2[answer4Lbl.Text];

            //Changing the counter value so that it changes the setup of the questions and answers
            counter = 3;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is a  setup for the different questions and answers that populate the different 
        /// textboxes with random values from the dictionaries. It also makes sure that there is 
        /// a corresponding matching question for each of the answers.
        /// </summary>
        public void RandomQandA3()
        {
            //Setting the answer lables
            answer1Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            answer2Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            answer3Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];
            answer4Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];

            //Setting the question lables
            question1Lbl.Text = dictionary.bookQna[answer4Lbl.Text];
            question2Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            question5Lbl.Text = dictionary.bookQna[dictionary.GetRandomKey()];
            question7Lbl.Text = dictionary.bookQna[answer3Lbl.Text];
            question3Lbl.Text = dictionary.bookQna2[dictionary.GetRandomKey2()];
            question4Lbl.Text = dictionary.bookQna2[answer2Lbl.Text];
            question6Lbl.Text = dictionary.bookQna2[answer1Lbl.Text];

            //Changing the counter value so that it changes the setup of the questions and answers
            counter = 1;
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This will check to see if the user has matched the
        // answers with the correct questions in the other
        // colunm. It also gives the users points depending if
        // they got the matches correct.
        ////////////////////////////////////////////////////////

        //Check Answer Methods

        #region Check Answers

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will check that the answer in the textbox matches the question label for the first setup
        /// </summary>
        private void CheckAnswer1()
        {
            if (answerTextBox1.Text == dictionary.bookQna2[question1Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;               
            }
            if (answerTextBox4.Text == dictionary.bookQna[question4Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox6.Text == dictionary.bookQna[question6Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox7.Text == dictionary.bookQna2[question7Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will check that the answer in the textbox matches the question label for the second setup
        /// </summary>
        private void CheckAnswer2()
        {
            if (answerTextBox5.Text == dictionary.bookQna2[question5Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox1.Text == dictionary.bookQna2[question1Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox3.Text == dictionary.bookQna[question3Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox6.Text == dictionary.bookQna[question6Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will check that the answer in the textbox matches the question label for the third setup
        /// </summary>
        private void CheckAnswer3()
        {
            if (answerTextBox6.Text == dictionary.bookQna[question6Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox4.Text == dictionary.bookQna[question4Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox7.Text == dictionary.bookQna2[question7Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
            if (answerTextBox1.Text == dictionary.bookQna2[question1Lbl.Text])
            {
                //This increases the users score if the answer is correct
                answersCorrect = answersCorrect + 1;
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This will get the users number of correct answers and
        // depending on their score they will be shown a message
        // to congradulate them and give them an achievement.
        // Unless they never got any answers correct.
        ////////////////////////////////////////////////////////

        //Achievement Methods

        #region Achievements

        public void CustomMessageBox()
        {
            customMessageBox2.messageTextLbl.Text = "Well done. You completed the challange. Your score was: " + answersCorrect +  "/4 \n" +
                " Here is a badge for you. :)";
        }

        public void AchievementCheck()
        {
            try
            {
                //Setting the message to the congradulations message
                customMessageBox2.CongradulationsMessage();

                //If the seconds left after the timer stops is more than or equal to 15
                if (answersCorrect == 4)
                {
                    //Shows the achievementImage1 gold achievement image
                    customMessageBox2.achievementImage1.Visible = true;
                    CustomMessageBox();
                }
                //If the seconds left after the timer stops is less than or equal to 14 and more than or equal to 6
                else if (answersCorrect == 3)
                {
                    //Shows the achievementImage2 silver achievement image
                    customMessageBox2.achievementImage2.Visible = true;
                    CustomMessageBox();
                }
                //Otherwise if the seconds left after the timer stops is less than or equal to 5 and more than 0
                else if (answersCorrect == 2 || answersCorrect == 1)
                {
                    //Shows the achievementImage3 bronze achievement image
                    customMessageBox2.achievementImage3.Visible = true;
                    CustomMessageBox();
                }
                //If the seconds left after the timer stops is less than or equal to 14 and more than or equal to 6
                else if (answersCorrect == 0)
                {
                    customMessageBox2.messageTitleLbl.Text = "Oh No !!!";
                    customMessageBox2.messageTextLbl.Text = "Unfortunately you did not get any correct";
                    customMessageBox2.achievementImage1.Visible = false;
                    customMessageBox2.achievementImage2.Visible = false;
                    customMessageBox2.achievementImage3.Visible = false;
                }

                //Showing the CustomMessageBox2 form
                customMessageBox2.Show();

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
        // game controls and functionality.
        ////////////////////////////////////////////////////////

        //Button Click Methods

        #region Button Clicks

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAnswersBtn_Click(object sender, EventArgs e)
        {
            this.game2GameTimer.Stop();
            this.playAgainBtn.Visible = true;
            this.checkAnswersBtn.Visible = false;
            

            switch (counter)
            {
                case 1:
                    CheckAnswer3();
                    break;
                case 2:
                    CheckAnswer1();
                    break;
                case 3:
                    CheckAnswer2();
                    break;
            }

            AchievementCheck();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            LabelVisibility(true);
            RandomQandA1();
            game2GameTimer.Start();
            startBtn.Visible = false;
            checkAnswersBtn.Visible = true;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            ResetGame2();

            switch(counter)
            {
                case 1:
                    RandomQandA1();
                    break;
                case 2:
                    RandomQandA2();
                    break;
                case 3:
                    RandomQandA3();
                    break;
            }

            playAgainBtn.Visible = false;
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is to enable and disable the textboxes as well
        // as reset them each time to remove their contents. It
        // also reset all the gamification features as well as
        // changes the visibility of all the lables.
        ////////////////////////////////////////////////////////

        //Reset / LabelVisibility / TextBoxes Enabled Methods

        #region Reset / LabelVisibility / TextBoxes Enabled

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="areTheyVisible"></param>
        public void LabelVisibility(bool areTheyVisible)
        {
            this.answer1Lbl.Visible = areTheyVisible;
            this.answer3Lbl.Visible = areTheyVisible;
            this.answer4Lbl.Visible = areTheyVisible;
            this.answer2Lbl.Visible = areTheyVisible;
            
            this.question1Lbl.Visible = areTheyVisible;
            this.question2Lbl.Visible = areTheyVisible;
            this.question3Lbl.Visible = areTheyVisible;
            this.question4Lbl.Visible = areTheyVisible;
            this.question5Lbl.Visible = areTheyVisible;
            this.question6Lbl.Visible = areTheyVisible;
            this.question7Lbl.Visible = areTheyVisible;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="areTheyEnabled"></param>
        public void TextBoxesEnabled(bool areTheyEnabled)
        {
            this.answerTextBox1.Enabled = areTheyEnabled;
            this.answerTextBox2.Enabled = areTheyEnabled;
            this.answerTextBox3.Enabled = areTheyEnabled;
            this.answerTextBox4.Enabled = areTheyEnabled;
            this.answerTextBox5.Enabled = areTheyEnabled;
            this.answerTextBox6.Enabled = areTheyEnabled;
            this.answerTextBox7.Enabled = areTheyEnabled;
        }

        public void TextBoxesRemoveText()
        {
            this.answerTextBox1.Text = "";
            this.answerTextBox2.Text = "";
            this.answerTextBox3.Text = "";
            this.answerTextBox4.Text = "";
            this.answerTextBox5.Text = "";
            this.answerTextBox6.Text = "";
            this.answerTextBox7.Text = "";
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        public void ResetGame2()
        {
            //Resetting the timer
            this.ms = 1;
            this.s = 50;
            this.m = 0;

            this.countdownProgressBar.Value = 100;

            this.game2GameTimer.Start();

            TextBoxesRemoveText();

            checkAnswersBtn.Visible = true;

            customMessageBox2.achievementImage1.Visible = false;
            customMessageBox2.achievementImage2.Visible = false;
            customMessageBox2.achievementImage3.Visible = false;

            answersCorrect = 0;
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
        /// <summary>
        /// This is the timer tick method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void game2GameTimer_Tick(object sender, EventArgs e)
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
                    countdownProgressBar.Value = countdownProgressBar.Value - 2;
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
                    this.game2GameTimer.Stop();

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
                    this.playAgainBtn.Visible = true;
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
        // This starts the dragging and makes sure that there is
        // a valid item / answer label selected. It also enables
        // the textboxes so that you can drop the selected
        // answer into it.
        ////////////////////////////////////////////////////////

        //Answer Mouse Down Methods

        #region Answer Mouse Down

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This starts the dragging when you click and hold the left mouse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Answer1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //If the user drags a valid item
                if (this.answer1Lbl.Text != null)
                {
                    TextBoxesEnabled(true);
                    //It will be copied from the BookCartUnsortedListBox listbox to the BookShelfSortedListBox listbox
                    this.answer1Lbl.DoDragDrop(this.answer1Lbl.Text, DragDropEffects.Copy);
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
        /// This starts the dragging when you click and hold the left mouse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Answer2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //If the user drags a valid item
                if (this.answer2Lbl.Text != null)
                {
                    TextBoxesEnabled(true);
                    //It will be copied from the BookCartUnsortedListBox listbox to the BookShelfSortedListBox listbox
                    this.answer2Lbl.DoDragDrop(this.answer2Lbl.Text, DragDropEffects.Copy);
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
        /// This starts the dragging when you click and hold the left mouse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Answer3Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //If the user drags a valid item
                if (this.answer3Lbl.Text != null)
                {
                    TextBoxesEnabled(true);
                    //It will be copied from the BookCartUnsortedListBox listbox to the BookShelfSortedListBox listbox
                    this.answer3Lbl.DoDragDrop(this.answer3Lbl.Text, DragDropEffects.Copy);
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
        /// This starts the dragging when you click and hold the left mouse button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Answer4Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                //If the user drags a valid item
                if (this.answer4Lbl.Text != null)
                {
                    TextBoxesEnabled(true);
                    //It will be copied from the BookCartUnsortedListBox listbox to the BookShelfSortedListBox listbox
                    this.answer4Lbl.DoDragDrop(this.answer4Lbl.Text, DragDropEffects.Copy);
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


        #endregion


        ////////////////////////////////////////////////////////
        // This is the rest of the dragging and dropping which
        // copies the answers and places it into the textbox
        // that the user selects. It then disables the textboxes
        // so that the answers cant be edited. 
        ////////////////////////////////////////////////////////

        //Drag And Dropping For TextBox Methods

        #region Drag And Dropping For TextBoxes

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox1_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox1.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox2_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox2_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox2.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox3_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox3_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox3.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox4_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox4_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox4.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox5_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox5_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox5.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox6_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox6_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox6.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks to see if there is data selected when you start
        /// dragging and then copies it it there is data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox7_DragEnter(object sender, DragEventArgs e)
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
        /// This adds the dragged answer into one of the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerTextBox7_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                this.answerTextBox7.Text = (string)e.Data.GetData(DataFormats.Text);
                TextBoxesEnabled(false);

            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }

        #endregion





        //TESTS

        #region TESTS


        //------------------------------------------------------------------------------------//
        //Trying to get a random label tset 1


        /*
        List<Label> tBoxes = new List<Label>();
        Label lbl;

        public void PopTextBoxList()
        {
            tBoxes.AddRange((IEnumerable<Label>)label1);
            tBoxes.AddRange((IEnumerable<Label>)label2);
            tBoxes.AddRange((IEnumerable<Label>)label3);
            tBoxes.AddRange((IEnumerable<Label>)label5);
        }


        public IEnumerable<Label> RandomTextBox<Label>()
        {
            //Random rand = new Random();
            //List<Label> tBox = Enumerable.ToList(tBoxes);
            int size = tBoxes.Count;
            while (true)
            {
                //lbl = tBoxes[random.Next(size)];
                yield return (Label)(IEnumerable<Label>)tBoxes[random.Next(size)];
                //return (IEnumerable<Label>)lbl;
            }
            
        }*/



        //------------------------------------------------------------------------------------//
        //Trying to get a random label tset 2


        /*
        public Dictionary<int, Label> labels = new Dictionary<int, Label>();

        public void PopLabels2()
        {
            labels.Add(1, label1);
            labels.Add(2, label5);
            labels.Add(3, label2);
            labels.Add(4, label3);
        }


        public IEnumerable<TValue> RandomLabelss<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            //Random rand = new Random();
            List<TValue> keys = Enumerable.ToList(dict.Values);
            int size = dict.Count;
            while (true)
            {
                yield return keys[random.Next(size)];
            }
        }



        public void TestRandomLabel()
        {
            RandomLabelss() = dictionary.GetRandomValue();
        }
        */



        //------------------------------------------------------------------------------------//

        /*
        public void Test()
        {
            
            for(int i = 0; i > 4; i++)
            {
                
            }

            
            foreach (KeyValuePair<string, string> item in dictionary.bookQna)
            {
                //item.Key = dictionary.GetRandomKey().ToString();

                //RandomTextBox() = item.Value;

                //PopTextBoxList();
                //Label lb = RandomTextBox();


                //string oiod = dictionary.GetRandomValue();
                //dictionary.bookQna.TryGetValue(dictionary.GetRandomKey(), out oiod);

                //string val;

                //val = dictionary.GetRandomValue();
                //val = item.Value;

                
                for (int i = 0; i > 4; i++)
                {
                    label5.Text = item.Value[i].ToString();
                    label8.Text = item.Key.ToString();
                }

                
            
                //label1.Text = val;
                label6.Text = item.Key.ToString();


                //label1.Text = item.Value;
                //label6.Text = item.Key.ToString();

                label2.Text = item.Value;
                label9.Text = item.Key.ToString();

                //label5.Text = item.Value;
                label11.Text = item.Key.ToString();

                label3.Text = item.Value;
                label13.Text = item.Key.ToString();

            }
        }*/


        //------------------------------------------------------------------------------------//

        /*
        public void HardcodedTest()
        {
            label1.Text = dictionary.bookQna["100"];
            label2.Text = dictionary.bookQna["300"];
            label3.Text = dictionary.bookQna2["Math and Science"].ToString();
            label5.Text = dictionary.bookQna2["Literature"].ToString();


            label6.Text = dictionary.bookQna["500"];
            label7.Text = dictionary.bookQna["000"];
            label9.Text = dictionary.bookQna2["Religions"].ToString();
            label10.Text = dictionary.bookQna2[label2.Text].ToString();
            label11.Text = dictionary.bookQna["800"];
            label12.Text = dictionary.bookQna2[label1.Text].ToString();
            label13.Text = dictionary.bookQna["400"];
        }*/


        #endregion


    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//


//                                       _________________________           
//                                      /                         \
//                                     /                           \
//                                    /                             \
//                                   /        _           _          \
//                                  /        / \         / \          \
//                                 /         \_/         \_/           \
//                                /                                     \
//                               |                                       |
//                               |                  |                    |
//                               |                  |_                   |
//                               |                                       |
//                               |                                       |
//                                \      \                       /      /
//                                 \      \_____________________/      /
//                                  \                                 /
//                                   \                               /
//                                    \                             /
//                                     \                           /
//                                      \_________________________/
//                                 
//                                 
//                                 
//                                 