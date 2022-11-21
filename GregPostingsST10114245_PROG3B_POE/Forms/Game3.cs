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

            /** Calling the SaveToRedBlackTree Method */
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
        /// Creating an object of the Game3Functionality class
        /// </summary>
        Game3Functionality game3Functionality = new Game3Functionality();

        /// <summary>
        /// Creating an object of the RedBlackTreeStructure class
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
        /// Enum to decide which level the user is on
        /// </summary>
        enum TopicLevel
        {
            Top,
            Second,
            Third
        }

        /// <summary>
        /// Checks to see what their current level is
        /// </summary>
        private TopicLevel currentLevel;

        /// <summary>
        /// Creating an object of the CustomMessageBox2 form
        /// </summary>
        CustomMessageBox2 customMessageBox2 = new CustomMessageBox2();

        #endregion


        ////////////////////////////////////////////////////////
        // This will save the data from the file into the tree.
        ////////////////////////////////////////////////////////

        //Saving Data To Red-Black Tree

        #region Saving Data To Red-Black Tree

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will save the data from the file into the tree
        /// </summary>
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
        // This is used to get the random third level call
        // number description and number used for the question.
        // It will also be used for getting all the third level
        // call number descriptions and numbers used for the
        // final answer. It will also sort and display the
        // different options in numerical order.
        ////////////////////////////////////////////////////////

        //Third Level

        #region Third Level

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to get the random third level call number description and number used for the question
        /// </summary>
        public void ThirdLevelSpecific()
        {
            try
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
                    //MessageBox.Show(game3Functionality.RandomlySelectedThirdLevelNum + game3Functionality.RandomlySelectedThirdLevelDesc);              //You can use this to know which random selection was made
                    //game3.listBox1.Items.Add(thirdLevelSpecific[SpecificTopic].DeweyDescription);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to get all the third level call number descriptions and numbers used for the answers
        /// </summary>
        public void ThirdLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }


        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to get four random third level call number descriptions and numbers 
        /// with one of them being the correct answer used for the answers
        /// </summary>
        public void FourRandomThirdLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to sort all the third level call number descriptions and answers 
        /// and then to display them in numerical order
        /// </summary>
        public void SortListAndPopulateThirdLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is used for getting all the second level call
        // number descriptions and numbers used for the answers.
        // It will also sort and display the different options
        // in numerical order.
        ////////////////////////////////////////////////////////

        //Second Level

        #region Second Level

    //----------------------------------------------------------------------------------------------//
    /// <summary>
    /// This is used to get all the second level call number descriptions and numbers used for the answers
    /// </summary>
    public void SecondLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to get four random second level call number descriptions and numbers 
        /// with one of them being the correct answer used for the answers
        /// </summary>
        public void FourRandomSecondLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to sort all the second level call number descriptions and answers 
        /// and then to display them in numerical order
        /// </summary>
        public void SortListAndPopulateSecondLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }


        #endregion


        ////////////////////////////////////////////////////////
        // This is used for getting all the top level call
        // number descriptions and numbers used for the answers.
        // It will also sort and display the different options
        // in numerical order. 
        ////////////////////////////////////////////////////////

        //Top Level

        #region Top Level

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to get all the top level call number descriptions and numbers used for the answers
        /// </summary>
        public void TopLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }          
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to get four random top level call number descriptions and numbers 
        /// with one of them being the correct answer used for the answers
        /// </summary>
        public void FourRandomTopLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to sort all the top level call number descriptions and answers 
        /// and then to display them in numerical order
        /// </summary>
        public void SortListAndPopulateTopLevel()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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
        // This will check to see if the answer that is selected
        // is correct for each of the sub question and it will do
        // certain things depending on which sub question you are
        // on and if it is correct or not.
        ////////////////////////////////////////////////////////

        //Checking Answers

        #region Checking Answers

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will check to see if the answer that is selected is correct for the top level
        /// </summary>
        public void CheckTopLevel()
        {
            if (answerRadioBtn1.Checked && answerRadioBtn1.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else if (answerRadioBtn2.Checked && answerRadioBtn2.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else if (answerRadioBtn3.Checked && answerRadioBtn3.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
                game3Functionality.score = game3Functionality.score + 1;
                scoreLbl.Text = game3Functionality.score.ToString();
                SecondLevel();
            }
            else if (answerRadioBtn4.Checked && answerRadioBtn4.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString()))
            {
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

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will check to see if the answer that is selected is correct for the second level
        /// </summary>
        public void CheckSecondLevel()
        {
            if (answerRadioBtn1.Checked && answerRadioBtn1.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else if (answerRadioBtn2.Checked && answerRadioBtn2.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else if (answerRadioBtn3.Checked && answerRadioBtn3.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
                game3Functionality.score = game3Functionality.score + 2;
                scoreLbl.Text = game3Functionality.score.ToString();
                ThirdLevel();
            }
            else if (answerRadioBtn4.Checked && answerRadioBtn4.Text.StartsWith(game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(0).ToString() + game3Functionality.RandomlySelectedThirdLevelNum.ElementAt(1).ToString()))
            {
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

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will check to see if the answer that is selected is correct for the third level
        /// </summary>
        public void CheckThirdLevel()
        {
            if (answerRadioBtn1.Checked && answerRadioBtn1.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else if (answerRadioBtn2.Checked && answerRadioBtn2.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else if (answerRadioBtn3.Checked && answerRadioBtn3.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
                game3Functionality.score = game3Functionality.score + 3;
                scoreLbl.Text = game3Functionality.score.ToString();
                ClearDataReset();
            }
            else if (answerRadioBtn4.Checked && answerRadioBtn4.Text.Equals(game3Functionality.RandomlySelectedThirdLevelNum))
            {
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


        ////////////////////////////////////////////////////////
        // This is used for clearing, resetting and changing the
        // visibility of components and data as well as game features.
        ////////////////////////////////////////////////////////

        //Clearing and Resetting

        #region Clearing and Resetting

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will uncheck all the radio buttons and disable the check answer button
        /// </summary>
        public void UnCheckRadioButtons()
        {
            answerRadioBtn1.Checked = false;
            answerRadioBtn2.Checked = false;
            answerRadioBtn3.Checked = false;
            answerRadioBtn4.Checked = false;

            checkAnswersBtn.Enabled = false;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will reset all the data and check if the game is finished
        /// </summary>
        public void ClearDataReset()
        {
            try
            {
                if (game3Functionality.currentQuestion == 5)
                {
                    /** Calling the AchievementCheck Method */
                    AchievementCheck();
                    /** Calling the QuestionAndAnswersVisibility Method */
                    QuestionAndAnswersVisibility(false);
                    //Resetting the timer label
                    timeLbl.Text = "00:00:00";
                }
                else
                {
                    //Clearing all the lists
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

                    /** Calling the UnCheckRadioButtons Method */
                    UnCheckRadioButtons();

                    /** Calling the ThirdLevelSpecific Method */
                    ThirdLevelSpecific();
                    /** Calling the TopLevel Method */
                    TopLevel();

                    //Resetting the timer
                    this.ms = 1;
                    this.s = 50;
                    this.m = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

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


        ////////////////////////////////////////////////////////
        // These are all the button click methods used for
        // game controls and functionality.
        ////////////////////////////////////////////////////////

        //Button Click Methods

        #region Button Clicks

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This starts the timer and sets everything up for the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                game3GameTimer.Start();
                startBtn.Visible = false;
                checkAnswersBtn.Enabled = false;
                //Makes the checkAnswersBtn Button invisible
                this.checkAnswersBtn.Visible = true;
                QuestionAndAnswersVisibility(true);

                ThirdLevelSpecific();
                TopLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            } 
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is used to check the different answers for each of the sub questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAnswersBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This resets everything so that the user can play again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Resetting the timer
                this.ms = 1;
                this.s = 50;
                this.m = 0;

                game3Functionality.score = 0;
                game3Functionality.currentQuestion = 1;

                scoreLbl.Text = "0";
                questionNumberLbl.Text = "1";

                //Clearing all the lists
                game3Functionality.fourRandomTopLevelSpecific.Clear();
                game3Functionality.fourRandomSecondLevelSpecific.Clear();
                game3Functionality.fourRandomThirdLevelSpecific.Clear();

                game3Functionality.topLevelSpecific.Clear();
                game3Functionality.secondLevelSpecific.Clear();
                game3Functionality.thirdLevelSpecific.Clear();
                game3Functionality.thirdLevel.Clear();

                game3Functionality.RandomlySelectedThirdLevelDesc = "";
                game3Functionality.RandomlySelectedThirdLevelNum = "";

                //Making all the achievement invisible
                customMessageBox2.achievementImage1.Visible = false;
                customMessageBox2.achievementImage2.Visible = false;
                customMessageBox2.achievementImage3.Visible = false;

                ThirdLevelSpecific();
                TopLevel();


                game3GameTimer.Start();
                playAgainBtn.Visible = false;
                checkAnswersBtn.Visible = true;
                QuestionAndAnswersVisibility(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            } 
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is used for making the check answer button enabled
        ////////////////////////////////////////////////////////

        //Radio ButtonCheck Changed Methods

        #region Radio ButtonCheckChanged

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This checks if the answerRadioBtn1 has been checked and then enables the check answer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerRadioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the check answer button
            checkAnswersBtn.Enabled = true;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This checks if the answerRadioBtn2 has been checked and then enables the check answer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerRadioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the check answer button
            checkAnswersBtn.Enabled = true;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This checks if the answerRadioBtn3 has been checked and then enables the check answer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerRadioBtn3_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the check answer button
            checkAnswersBtn.Enabled = true;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This checks if the answerRadioBtn4 has been checked and then enables the check answer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerRadioBtn4_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the check answer button
            checkAnswersBtn.Enabled = true;
        }

        #endregion


        ////////////////////////////////////////////////////////
        // This is for when the Game3 form is closing.
        ////////////////////////////////////////////////////////

        //Game3 Form Closing Method

        #region Game3 Form Closing Method

        //----------------------------------------------------------------------------------------------//
        //Form Closing Method

        /// <summary>
        /// Game2 Closing Method - It will take you back to the main menu / Form1 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game3_FormClosing(object sender, FormClosingEventArgs e)
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