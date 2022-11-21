/*
 * Done By: Greg Postings ST10114245 
 * Module: PROG 3B
 * Class: BCA3 G7
 * Task: POE Task 2
 * Start Date and Time: 19 October 2022 at 9:30
 * Finish Date and Time: 25 October 2022 at 10:40
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

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Setting the text of the congradulations message
        /// </summary>
        public void CustomMessageBox()
        {
            //Setting the message for the congradulations message and letting the user know their score
            customMessageBox2.messageTextLbl.Text = "Well done. You completed the challange. Your score was: " + 
                answersCorrect +  "/4 \n" + " Here is a badge for you. :)";
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This just deterimnes the achievement awarded determied by the users
        /// score as well as the message they recieve
        /// </summary>
        public void AchievementCheck()
        {
            try
            {
                //Setting the message for the congradulations message
                customMessageBox2.CongradulationsMessage();
                CustomMessageBox();

                //If the seconds left after the timer stops is more than or equal to 15
                if (answersCorrect == 4)
                {
                    //Shows the achievementImage1 gold achievement image
                    customMessageBox2.achievementImage1.Visible = true;
                }
                //If the seconds left after the timer stops is less than or equal to 14 and more than or equal to 6
                else if (answersCorrect == 3)
                {
                    //Shows the achievementImage2 silver achievement image
                    customMessageBox2.achievementImage2.Visible = true;
                }
                //Otherwise if the seconds left after the timer stops is less than or equal to 5 and more than 0
                else if (answersCorrect == 2 || answersCorrect == 1)
                {
                    //Shows the achievementImage3 bronze achievement image
                    customMessageBox2.achievementImage3.Visible = true;
                }
                //If the seconds left after the timer stops is less than or equal to 14 and more than or equal to 6
                else if (answersCorrect == 0)
                {
                    //Setting the title for the unsuccessful message
                    customMessageBox2.messageTitleLbl.Text = "Oh No !!!";
                    //Setting the message for the unsuccessful message
                    customMessageBox2.messageTextLbl.Text = "Unfortunately you did not get any correct";

                    //Making all the achievement invisible
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

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This checks to see what answers are correct and which achievement the user gets
        /// </summary>
        private void AnswerAchievementCheck()
        {
            //Stops the game2GameTimer timer
            this.game2GameTimer.Stop();
            //Makes the playAgainBtn Button visible
            this.playAgainBtn.Visible = true;
            //Makes the checkAnswersBtn Button invisible
            this.checkAnswersBtn.Visible = false;

            //Checks the count of which setup is used and then check the aswers of the corresponding setup
            switch (counter)
            {
                case 1:
                    /** Calling the CheckAnswer3 method */
                    CheckAnswer3();
                    break;
                case 2:
                    /** Calling the CheckAnswer1 method */
                    CheckAnswer1();
                    break;
                case 3:
                    /** Calling the CheckAnswer2 method */
                    CheckAnswer2();
                    break;
            }

            /** Calling the AchievementCheck method */
            AchievementCheck();
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
        /// This button will check the answers for the different setups
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAnswersBtn_Click(object sender, EventArgs e)
        {
            /** Calling the AnswerAchievementCheck method */
            AnswerAchievementCheck();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This button starts the game by displaying the different lables and populating
        /// them with random questions and answers. It also starts the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            /** Calling the LabelVisibility method */
            LabelVisibility(true);
            /** Calling the RandomQandA1 method */
            RandomQandA1();
            //Starts the game2GameTimer timer
            game2GameTimer.Start();
            //Makes the startBtn Button invisible
            startBtn.Visible = false;
            //Makes the checkAnswersBtn Button visible
            checkAnswersBtn.Visible = true;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This button will reset everything and repopulate the lables with random 
        /// questions and answers using a different setup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            /** Calling the ResetGame2 method */
            ResetGame2();

            //Checks the count to determine which setup is used
            switch (counter)
            {
                case 1:
                    /** Calling the RandomQandA1 method */
                    RandomQandA1();
                    break;
                case 2:
                    /** Calling the RandomQandA2 method */
                    RandomQandA2();
                    break;
                case 3:
                    /** Calling the RandomQandA3 method */
                    RandomQandA3();
                    break;
            }

            //Makes the playAgainBtn Button invisible
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
        /// This will change the visibility of all the question and answer labels
        /// </summary>
        /// <param name="areTheyVisible"></param>
        public void LabelVisibility(bool areTheyVisible)
        {
            //Answers
            this.answer1Lbl.Visible = areTheyVisible;
            this.answer3Lbl.Visible = areTheyVisible;
            this.answer4Lbl.Visible = areTheyVisible;
            this.answer2Lbl.Visible = areTheyVisible;
            
            //Questions
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
        /// This will determine if the textboxes are enabled or disabled
        /// </summary>
        /// <param name="areTheyEnabled"></param>
        public void TextBoxesEnabled(bool areTheyEnabled)
        {
            //TextBoxes for answers
            this.answerTextBox1.Enabled = areTheyEnabled;
            this.answerTextBox2.Enabled = areTheyEnabled;
            this.answerTextBox3.Enabled = areTheyEnabled;
            this.answerTextBox4.Enabled = areTheyEnabled;
            this.answerTextBox5.Enabled = areTheyEnabled;
            this.answerTextBox6.Enabled = areTheyEnabled;
            this.answerTextBox7.Enabled = areTheyEnabled;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This resets the text in the textboxes
        /// </summary>
        public void TextBoxesRemoveText()
        {
            //TextBoxes for answers
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
        /// This resets all the game features
        /// </summary>
        public void ResetGame2()
        {
            //Resetting the timer
            this.ms = 1;
            this.s = 50;
            this.m = 0;

            //Resets the progress bar
            this.countdownProgressBar.Value = 100;

            //Starts the game2GameTimer timer
            this.game2GameTimer.Start();

            /** Calling the TextBoxesRemoveText method */
            TextBoxesRemoveText();

            //Makes the checkAnswersBtn Button visible
            checkAnswersBtn.Visible = true;

            //Makes all the achievements invisible
            customMessageBox2.achievementImage1.Visible = false;
            customMessageBox2.achievementImage2.Visible = false;
            customMessageBox2.achievementImage3.Visible = false;

            //Sets the answers correct back to 0
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
                    //Decreases the countdownProgressBar progressbar every second
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

                    /** Calling the AnswerAchievementCheck method */
                    AnswerAchievementCheck();                  
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
                    /** Calling the TextBoxesEnabled Method */
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
                    /** Calling the TextBoxesEnabled Method */
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
                    /** Calling the TextBoxesEnabled Method */
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
                    /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox1 textbox
                this.answerTextBox1.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox2 textbox
                this.answerTextBox2.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox3 textbox
                this.answerTextBox3.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox4 textbox
                this.answerTextBox4.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox5 textbox
                this.answerTextBox5.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox6 textbox
                this.answerTextBox6.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
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
                //Copies the answer labels text and puts it into the answerTextBox7 textbox
                this.answerTextBox7.Text = (string)e.Data.GetData(DataFormats.Text);
                /** Calling the TextBoxesEnabled Method */
                TextBoxesEnabled(false);
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Error is: " + ex);
            }
        }


        #endregion


        ////////////////////////////////////////////////////////
        // This is for when the Game2 form is closing.
        ////////////////////////////////////////////////////////

        //Game2 Form Closing Method

        #region Game2 Form Closing Method

        //----------------------------------------------------------------------------------------------//
        //Form Closing Method

        /// <summary>
        /// Game2 Closing Method - It will take you back to the main menu / Form1 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Creating an object of the Form1 form
                Form1 mainMenu = new Form1();
                //Showing the Form1 form
                mainMenu.Show();
                //Hiding the Game Mode Menu / Game1GameMode form
                this.Hide();
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
//                          ////////////////////////////////////////////////////////
//
//                               You make known to me the path of life; in your
//                                  presence there is fullness of joy; at
//                                      your right hand are pleasures
//                                        forevermore. -Psalm 16:11
//                                 
//                          ////////////////////////////////////////////////////////
//                          