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
using GregPostingsST10114245_PROG3B_POE.Game3Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Forms
{
    //Class
    public partial class Game3 : Form
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
        public Game3()
        {
            /** Calling the InitializeComponent Method */
            InitializeComponent();
          
            SaveToRedBlackTree();
        }

        #endregion




        ////////////////////////////////////////////////////////
        // These are different variables that are being declared
        // and some are being initialized as well. They are used
        // for storing different values and some are objects of
        // classes.
        ////////////////////////////////////////////////////////

        //Variables

        #region Variables

        /// <summary>
        /// 
        /// </summary>
        Game3Functionality game3Functionality = new Game3Functionality();

        /// <summary>
        /// 
        /// </summary>
        RedBlackTreeStructure redBlackTreeStructure = new RedBlackTreeStructure();

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
        /// 
        /// </summary>
        enum TopicLevel
        {
            Top,
            Second,
            Third
        }

        /// <summary>
        /// 
        /// </summary>
        private TopicLevel currentLevel;

        /// <summary>
        /// Creating an object of the CustomMessageBox2 form
        /// </summary>
        CustomMessageBox2 customMessageBox2 = new CustomMessageBox2();

        #endregion


        ////////////////////////////////////////////////////////
        // 
        ////////////////////////////////////////////////////////

        //Saving Data To Red-Black Tree

        #region Saving Data To Red-Black Tree

        public void SaveToRedBlackTree()
        {
            using (var streamReader = new StreamReader(game3Functionality.filePath))
            {
                string line;


                while (!string.IsNullOrWhiteSpace(line = streamReader.ReadLine()))
                {
                    string[] entries = line.Split('/');

                    DeweyNumbers newDeweyNum = new DeweyNumbers();

                    newDeweyNum.DeweyNumber = entries[0];
                    newDeweyNum.DeweyDescription = entries[1];

                    game3Functionality.deweyNumbers.Add(newDeweyNum);
                    redBlackTreeStructure.Insert(newDeweyNum.DeweyNumber, newDeweyNum.DeweyDescription);

                    //Testing
                    //listBox1.Items.Add(newDeweyNum.DeweyNumber + " " + newDeweyNum.DeweyDescription);                                     
                }
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // 
        ////////////////////////////////////////////////////////

        //Third Level

        #region Third Level

        public void ThirdLevelSpecific()
        {
            using (var streamReader = new StreamReader(game3Functionality.filePath))
            {
                string line;

                while (!string.IsNullOrWhiteSpace(line = streamReader.ReadLine()))
                {
                    string[] entries = line.Split('/');

                    DeweyNumbers newDeweyNum2 = new DeweyNumbers();

                    newDeweyNum2.DeweyNumber = entries[0];
                    newDeweyNum2.DeweyDescription = entries[1];

                    if (!entries[0].Trim().EndsWith("0"))
                    {
                        game3Functionality.thirdLevelSpecific.Add(newDeweyNum2);
                    }
                }
                game3Functionality.SpecificTopic = game3Functionality.RandomNum(game3Functionality.thirdLevelSpecific);

                game3Functionality.RandomlySelectedThirdLevelDesc = game3Functionality.thirdLevelSpecific[game3Functionality.SpecificTopic].DeweyDescription;
                game3Functionality.RandomlySelectedThirdLevelNum = game3Functionality.thirdLevelSpecific[game3Functionality.SpecificTopic].DeweyNumber;
               
                questionLbl.Text = game3Functionality.RandomlySelectedThirdLevelDesc;

                //Testing
                MessageBox.Show(game3Functionality.RandomlySelectedThirdLevelNum + game3Functionality.RandomlySelectedThirdLevelDesc);              //You can use this to know which random selection was made
                //game3.listBox1.Items.Add(thirdLevelSpecific[SpecificTopic].DeweyNumber + thirdLevelSpecific[SpecificTopic].DeweyDescription);
                //game3.listBox1.Items.Add(thirdLevelSpecific[SpecificTopic].DeweyDescription);
            }
        }


        public void ThirdLevel()
        {
            currentLevel = TopicLevel.Third;

            questionDescriptionLbl.Text = "Please select the corresponding third level number\nthat matches the following third level description:";

            using (var streamReader = new StreamReader(game3Functionality.filePath))
            {
                string line;

                while (!string.IsNullOrWhiteSpace(line = streamReader.ReadLine()))
                {
                    string[] entries = line.Split('/');

                    DeweyNumbers newDeweyNum2 = new DeweyNumbers();

                    newDeweyNum2.DeweyNumber = entries[0];
                    newDeweyNum2.DeweyDescription = entries[1];

                    if (entries[0].Trim().StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
                    {
                        game3Functionality.thirdLevel.Add(newDeweyNum2);
                    }
                }
            }

            FourRandomThirdLevel();
        }



        public void FourRandomThirdLevel()
        {
            //Getting three random values
            for (int i = 0; i < 3; i++)
            {

                game3Functionality.SpecificTopic = game3Functionality.RandomNum(game3Functionality.thirdLevel);
                DeweyNumbers newDeweyNum6 = new DeweyNumbers();
                newDeweyNum6.DeweyNumber = game3Functionality.thirdLevel[game3Functionality.SpecificTopic].DeweyNumber;
                newDeweyNum6.DeweyDescription = game3Functionality.thirdLevel[game3Functionality.SpecificTopic].DeweyDescription;
                game3Functionality.fourRandomThirdLevelSpecific.Add(newDeweyNum6);

                //Testing
                //listBox1.Items.Add(game3Functionality.thirdLevelSpecific[game3Functionality.SpecificTopic].DeweyNumber + game3Functionality.thirdLevelSpecific[game3Functionality.SpecificTopic].DeweyDescription);

            }

            for (int i = 0; i < game3Functionality.thirdLevel.Count; i++)
            {
                if (game3Functionality.thirdLevel[i].DeweyNumber.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
                {
                    DeweyNumbers newDeweyNum6 = new DeweyNumbers();
                    newDeweyNum6.DeweyNumber = game3Functionality.thirdLevel[i].DeweyNumber;
                    newDeweyNum6.DeweyDescription = game3Functionality.thirdLevel[i].DeweyDescription;
                    game3Functionality.fourRandomThirdLevelSpecific.Add(newDeweyNum6);

                    //Testing
                    //listBox1.Items.Add(game3Functionality.thirdLevelSpecific[i].DeweyNumber + game3Functionality.thirdLevelSpecific[i].DeweyDescription);
                }
            }

            //Testing
            //for (int i = 0; i < game3Functionality.fourRandomThirdLevelSpecific.Count; i++)
            //{
            //    listBox1.Items.Add(game3Functionality.fourRandomThirdLevelSpecific[i].DeweyNumber + game3Functionality.fourRandomThirdLevelSpecific[i].DeweyDescription);
            //}


            SortListAndPopulateThirdLevel();

        }

        public void SortListAndPopulateThirdLevel()
        {

            List<DeweyNumbers> sorted = (from ddn in game3Functionality.fourRandomThirdLevelSpecific orderby ddn.DeweyNumber select ddn).ToList();

            answerRadioBtn1.Text = sorted[0].DeweyNumber;
            answerRadioBtn2.Text = sorted[1].DeweyNumber;
            answerRadioBtn3.Text = sorted[2].DeweyNumber;
            answerRadioBtn4.Text = sorted[3].DeweyNumber;

            //Testing
            //for (int i = 0; i < sorted.Count; i++)
            //{
            //    listBox1.Items.Add(sorted[i].DeweyNumber + sorted[i].DeweyDescription);
            //}
        }

        #endregion


        ////////////////////////////////////////////////////////
        // 
        ////////////////////////////////////////////////////////

        //Second Level

        #region Second Level

        public void SecondLevel()
        {
            currentLevel = TopicLevel.Second;

            questionDescriptionLbl.Text = "Please select the corresponding second level topic\nthat matches the following third level topic:";

            //This is getting the file location that will be used
            using (var streamReader = new StreamReader(game3Functionality.filePath))
            {
                //A variable to store the information on each line of the file
                string line;

                //This will read the informationfrom the file and will save it to the variable
                while (!string.IsNullOrWhiteSpace(line = streamReader.ReadLine()))
                {
                    string[] entries = line.Split('/');

                    DeweyNumbers newDeweyNum5 = new DeweyNumbers();

                    newDeweyNum5.DeweyNumber = entries[0];
                    newDeweyNum5.DeweyDescription = entries[1];

                    if (entries[0].Trim().EndsWith("0") && entries[0].StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
                    {
                        game3Functionality.secondLevelSpecific.Add(newDeweyNum5);
                    }
                }
            }

            //Testing
            //for (int i = 0; i < game3Functionality.secondLevelSpecific.Count; i++)
            //{
            //    listBox1.Items.Add(game3Functionality.secondLevelSpecific[i].DeweyNumber + game3Functionality.secondLevelSpecific[i].DeweyDescription);
            //}

            FourRandomSecondLevel();
        }


        public void FourRandomSecondLevel()
        {

            //Getting three random values
            for (int i = 0; i < 3; i++)
            {
                game3Functionality.SelectedSecondLevelTopic = game3Functionality.RandomNum(game3Functionality.secondLevelSpecific);
                DeweyNumbers newDeweyNum6 = new DeweyNumbers();
                newDeweyNum6.DeweyNumber = game3Functionality.secondLevelSpecific[game3Functionality.SelectedSecondLevelTopic].DeweyNumber;
                newDeweyNum6.DeweyDescription = game3Functionality.secondLevelSpecific[game3Functionality.SelectedSecondLevelTopic].DeweyDescription;
                game3Functionality.fourRandomSecondLevelSpecific.Add(newDeweyNum6);

                //Testing
                //listBox1.Items.Add(game3Functionality.secondLevelSpecific[game3Functionality.SelectedSecondLevelTopic].DeweyNumber + game3Functionality.secondLevelSpecific[game3Functionality.SelectedSecondLevelTopic].DeweyDescription);
            }

            for (int i = 0; i < game3Functionality.secondLevelSpecific.Count; i++)
            {

                if (game3Functionality.secondLevelSpecific[i].DeweyNumber.Trim().StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
                {
                    DeweyNumbers newDeweyNum6 = new DeweyNumbers();
                    newDeweyNum6.DeweyNumber = game3Functionality.secondLevelSpecific[i].DeweyNumber;
                    newDeweyNum6.DeweyDescription = game3Functionality.secondLevelSpecific[i].DeweyDescription;
                    game3Functionality.fourRandomSecondLevelSpecific.Add(newDeweyNum6);

                    //Testing
                    //listBox1.Items.Add(game3Functionality.secondLevelSpecific[i].DeweyNumber + game3Functionality.secondLevelSpecific[i].DeweyDescription);
                }
            }

            //Testing
            //for (int i = 0; i < game3Functionality.fourRandomSecondLevelSpecific.Count; i++)
            //{
            //    listBox1.Items.Add(game3Functionality.fourRandomSecondLevelSpecific[i].DeweyNumber + game3Functionality.fourRandomSecondLevelSpecific[i].DeweyDescription);
            //}


            SortListAndPopulateSecondLevel();

        }


        public void SortListAndPopulateSecondLevel()
        {

            List<DeweyNumbers> sorted = (from ddn in game3Functionality.fourRandomSecondLevelSpecific orderby ddn.DeweyNumber select ddn).ToList();

            answerRadioBtn1.Text = sorted[0].DeweyNumber + sorted[0].DeweyDescription;
            answerRadioBtn2.Text = sorted[1].DeweyNumber + sorted[1].DeweyDescription;
            answerRadioBtn3.Text = sorted[2].DeweyNumber + sorted[2].DeweyDescription;
            answerRadioBtn4.Text = sorted[3].DeweyNumber + sorted[3].DeweyDescription;

            //Testing
            for (int i = 0; i < sorted.Count; i++)
            {
                listBox1.Items.Add(sorted[i].DeweyNumber + sorted[i].DeweyDescription);
            }
        }


        #endregion


        ////////////////////////////////////////////////////////
        // 
        ////////////////////////////////////////////////////////

        //Top Level

        #region Top Level

        public void TopLevel()
        {

            currentLevel = TopicLevel.Top;

            questionDescriptionLbl.Text = "Please select the corresponding top level topic\nthat matches the following third level topic:";

            //This is getting the file location that will be used
            using (var streamReader = new StreamReader(game3Functionality.filePath))
            {
                //A variable to store the information on each line of the file
                string line;

                //This will read the informationfrom the file and will save it to the variable
                while (!string.IsNullOrWhiteSpace(line = streamReader.ReadLine()))
                {
                    string[] entries = line.Split('/');

                    DeweyNumbers newDeweyNum3 = new DeweyNumbers();

                    newDeweyNum3.DeweyNumber = entries[0];
                    newDeweyNum3.DeweyDescription = entries[1];

                    if (entries[0].Trim().EndsWith("00"))
                    {
                        game3Functionality.topLevelSpecific.Add(newDeweyNum3);
                    }
                }
            }

            FourRandomTopLevel();
        }

        public void FourRandomTopLevel()
        {

            //Getting three random values
            for (int i = 0; i < 3; i++)
            {
                game3Functionality.SelectedGeneralTopic = game3Functionality.RandomNum(game3Functionality.topLevelSpecific);
                DeweyNumbers newDeweyNum4 = new DeweyNumbers();
                newDeweyNum4.DeweyNumber = game3Functionality.topLevelSpecific[game3Functionality.SelectedGeneralTopic].DeweyNumber;
                newDeweyNum4.DeweyDescription = game3Functionality.topLevelSpecific[game3Functionality.SelectedGeneralTopic].DeweyDescription;
                game3Functionality.fourRandomTopLevelSpecific.Add(newDeweyNum4);

                //Testing
                //listBox1.Items.Add(game3Functionality.topLevelSpecific[game3Functionality.SelectedGeneralTopic].DeweyNumber + game3Functionality.topLevelSpecific[game3Functionality.SelectedGeneralTopic].DeweyDescription);
            }

            for (int i = 0; i < game3Functionality.topLevelSpecific.Count; i++)
            {

                if (game3Functionality.topLevelSpecific[i].DeweyNumber.Trim().StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
                {
                    DeweyNumbers newDeweyNum4 = new DeweyNumbers();
                    newDeweyNum4.DeweyNumber = game3Functionality.topLevelSpecific[i].DeweyNumber;
                    newDeweyNum4.DeweyDescription = game3Functionality.topLevelSpecific[i].DeweyDescription;
                    game3Functionality.fourRandomTopLevelSpecific.Add(newDeweyNum4);

                    //Testing
                    //listBox1.Items.Add(game3Functionality.topLevelSpecific[i].DeweyNumber + game3Functionality.topLevelSpecific[i].DeweyDescription);
                }
            }

            //Testing
            //for (int i = 0; i < game3Functionality.fourRandomTopLevelSpecific.Count; i++)
            //{
            //    listBox1.Items.Add(game3Functionality.fourRandomTopLevelSpecific[i].DeweyNumber + game3Functionality.fourRandomTopLevelSpecific[i].DeweyDescription);
            //}


            SortListAndPopulateTopLevel();

        }

        public void SortListAndPopulateTopLevel()
        {

            List<DeweyNumbers> sorted = (from ddn in game3Functionality.fourRandomTopLevelSpecific orderby ddn.DeweyNumber select ddn).ToList();

            answerRadioBtn1.Text = sorted[0].DeweyNumber + sorted[0].DeweyDescription;
            answerRadioBtn2.Text = sorted[1].DeweyNumber + sorted[1].DeweyDescription;
            answerRadioBtn3.Text = sorted[2].DeweyNumber + sorted[2].DeweyDescription;
            answerRadioBtn4.Text = sorted[3].DeweyNumber + sorted[3].DeweyDescription;

            //Testing
            //for (int i = 0; i < sorted.Count; i++)
            //{
            //    listBox1.Items.Add(sorted[i].DeweyNumber + sorted[i].DeweyDescription);
            //}
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
        private void Game3GameTimer_Tick(object sender, System.EventArgs e)

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
                    //countdownProgressBar.Value = countdownProgressBar.Value - 2;
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
                    /** Calling the ClearDataReset Method */
                    ClearDataReset();
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
        // 
        ////////////////////////////////////////////////////////

        //Checking Answers

        #region Checking Answers

        public void CheckTopLevel()
        {
            if (answerRadioBtn1.Checked && answerRadioBtn1.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else if (answerRadioBtn2.Checked && answerRadioBtn2.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else if (answerRadioBtn3.Checked && answerRadioBtn3.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else if (answerRadioBtn4.Checked && answerRadioBtn4.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else
            {
                MessageBox.Show("That is not correct");
                ClearDataReset();
            }

            UnCheckRadioButtons();
        }

        public void CheckSecondLevel()
        {
            if (answerRadioBtn1.Checked && answerRadioBtn1.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else if (answerRadioBtn2.Checked && answerRadioBtn2.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else if (answerRadioBtn3.Checked && answerRadioBtn3.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else if (answerRadioBtn4.Checked && answerRadioBtn4.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else
            {
                MessageBox.Show("That is not correct");
                ClearDataReset();
            }

            UnCheckRadioButtons();
        }

        public void CheckThirdLevel()
        {
            if (answerRadioBtn1.Checked && answerRadioBtn1.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else if (answerRadioBtn2.Checked && answerRadioBtn2.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else if (answerRadioBtn3.Checked && answerRadioBtn3.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else if (answerRadioBtn4.Checked && answerRadioBtn4.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                MessageBox.Show("That is correct");
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else
            {
                MessageBox.Show("That is not correct");
                ClearDataReset();
            }

            UnCheckRadioButtons();
        }

        #endregion

        public void UnCheckRadioButtons()
        {
            answerRadioBtn1.Checked = false;
            answerRadioBtn2.Checked = false;
            answerRadioBtn3.Checked = false;
            answerRadioBtn4.Checked = false;
        }

        public void ClearDataReset()
        {

            if (game3Functionality.currentQuestion == 5)
            {
                /** Calling the AchievementCheck Method */
                AchievementCheck();
                QuestionAndAnswersVisibility(false);
                timeLbl.Text = "00:00:00";
            }
            else
            {
                game3Functionality.fourRandomTopLevelSpecific.Clear();
                game3Functionality.fourRandomSecondLevelSpecific.Clear();
                game3Functionality.fourRandomThirdLevelSpecific.Clear();

                game3Functionality.topLevelSpecific.Clear();
                game3Functionality.secondLevelSpecific.Clear();
                game3Functionality.thirdLevelSpecific.Clear();
                game3Functionality.thirdLevel.Clear();

                game3Functionality.RandomlySelectedThirdLevelDesc = "";
                game3Functionality.RandomlySelectedThirdLevelNum = "";

                game3Functionality.currentQuestion = game3Functionality.currentQuestion + 1;
                questionNumberLbl.Text = game3Functionality.currentQuestion.ToString();

                UnCheckRadioButtons();

                ThirdLevelSpecific();
                TopLevel();

                //Resetting the timer
                this.ms = 1;
                this.s = 50;
                this.m = 0;
            }
            
        }






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
                game3Functionality.score + "/30 \n" + " Here is a badge for you. :)";
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
                //Stops the game2GameTimer timer
                this.game3GameTimer.Stop();
                //Makes the playAgainBtn Button visible
                this.playAgainBtn.Visible = true;
                //Makes the checkAnswersBtn Button invisible
                this.checkAnswersBtn.Visible = false;

                //Setting the message for the congradulations message
                customMessageBox2.CongradulationsMessage();
                CustomMessageBox();

                //If the score is more than 20
                if (game3Functionality.score > 20)
                {
                    //Shows the achievementImage1 gold achievement image
                    customMessageBox2.achievementImage1.Visible = true;
                }
                //If the score is more than 10 and lass than or equal to 20
                else if (game3Functionality.score > 10 && game3Functionality.score <= 20)
                {
                    //Shows the achievementImage2 silver achievement image
                    customMessageBox2.achievementImage2.Visible = true;
                }
                //Otherwise if the score is more than or equal to 5 and less than or equal to 10
                else if (game3Functionality.score >= 5 && game3Functionality.score <= 10)
                {
                    //Shows the achievementImage3 bronze achievement image
                    customMessageBox2.achievementImage3.Visible = true;
                }
                //If the score is less than 5
                else if (game3Functionality.score < 5)
                {
                    //Setting the title for the unsuccessful message
                    customMessageBox2.messageTitleLbl.Text = "Oh No !!!";
                    //Setting the message for the unsuccessful message
                    customMessageBox2.messageTextLbl.Text = "Unfortunately you did not get an achievement";

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


        #endregion







        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will change the visibility of all the question and answer labels
        /// </summary>
        /// <param name="areTheyVisible"></param>
        public void QuestionAndAnswersVisibility(bool areTheyVisible)
        {
            //Answers
            this.answerRadioBtn1.Visible = areTheyVisible;
            this.answerRadioBtn2.Visible = areTheyVisible;
            this.answerRadioBtn3.Visible = areTheyVisible;
            this.answerRadioBtn4.Visible = areTheyVisible;

            //Question
            this.questionLbl.Visible = areTheyVisible;
            this.questionDescriptionLbl.Visible = areTheyVisible;

            //Other
            this.questionNumberLbl.Visible = areTheyVisible;
            this.questionNumLbl.Visible = areTheyVisible;
            this.scoreLbl.Visible = areTheyVisible;
        }



        private void StartBtn_Click(object sender, EventArgs e)
        {
            game3GameTimer.Start();
            startBtn.Visible = false;
            //Makes the checkAnswersBtn Button invisible
            this.checkAnswersBtn.Visible = true;
            QuestionAndAnswersVisibility(true);

            ThirdLevelSpecific();
            TopLevel();
        }

        private void CheckAnswersBtn_Click(object sender, EventArgs e)
        {
            switch (currentLevel)
            {
                case TopicLevel.Top:
                    CheckTopLevel();
                    break;
                case TopicLevel.Second:
                    CheckSecondLevel();
                    break;
                case TopicLevel.Third:
                    CheckThirdLevel();
                    break;
            }
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {

            //Resetting the timer
            this.ms = 1;
            this.s = 50;
            this.m = 0;

            game3Functionality.score = 0;
            game3Functionality.currentQuestion = 1;

            scoreLbl.Text = "0";
            questionNumberLbl.Text = "1";           

            game3Functionality.fourRandomTopLevelSpecific.Clear();
            game3Functionality.fourRandomSecondLevelSpecific.Clear();
            game3Functionality.fourRandomThirdLevelSpecific.Clear();

            game3Functionality.topLevelSpecific.Clear();
            game3Functionality.secondLevelSpecific.Clear();
            game3Functionality.thirdLevelSpecific.Clear();
            game3Functionality.thirdLevel.Clear();

            game3Functionality.RandomlySelectedThirdLevelDesc = "";
            game3Functionality.RandomlySelectedThirdLevelNum = "";

            ThirdLevelSpecific();
            TopLevel();


            game3GameTimer.Start();
            playAgainBtn.Visible = false;
            checkAnswersBtn.Visible = true;
            QuestionAndAnswersVisibility(true);
        }

    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//