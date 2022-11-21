using GregPostingsST10114245_PROG3B_POE.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GregPostingsST10114245_PROG3B_POE.Game3Classes
{
    class Game3Functionality
    {

        ////////////////////////////////////////////////////////
        // These are different variables that are being declared
        // and some are being initialized as well. They are used
        // for storing different values and some are objects of
        // classes.
        ////////////////////////////////////////////////////////

        //Variables

        #region Variables

        //A lot of different Lists used to store different values

        /// <summary>
        /// 
        /// </summary>
        public List<string> deweyDeci = new List<string>();

        /// <summary>
        /// This List stores all the top level numbers and descriptions
        /// </summary>
        public List<DeweyNumbers> topLevelSpecific = new List<DeweyNumbers>();

        /// <summary>
        /// This List stores all the second level numbers and descriptions
        /// </summary>
        public List<DeweyNumbers> secondLevelSpecific = new List<DeweyNumbers>();

        /// <summary>
        /// This List stores all the third level numbers and descriptions and
        /// is used to get the random call number at the beginning
        /// </summary>
        public List<DeweyNumbers> thirdLevelSpecific = new List<DeweyNumbers>();

        /// <summary>
        /// This List stores all the third level numbers and descriptions
        /// </summary>
        public List<DeweyNumbers> thirdLevel = new List<DeweyNumbers>();

        /// <summary>
        /// This List stores all the numbers and descriptions
        /// </summary>
        public List<DeweyNumbers> deweyNumbers = new List<DeweyNumbers>();

        /// <summary>
        /// This List will store four randomly selected top level
        /// call numbers and their descriptions
        /// </summary>
        public List<DeweyNumbers> fourRandomTopLevelSpecific = new List<DeweyNumbers>();

        /// <summary>
        /// This List will store four randomly selected second level
        /// call numbers and their descriptions
        /// </summary>>
        public List<DeweyNumbers> fourRandomSecondLevelSpecific = new List<DeweyNumbers>();

        /// <summary>
        /// This List will store four randomly selected third level
        /// call numbers and their descriptions
        /// </summary>
        public List<DeweyNumbers> fourRandomThirdLevelSpecific = new List<DeweyNumbers>();

        /// <summary>
        /// This is the file path of the text file that stores all the data
        /// </summary>
        public string filePath = @"D:\BCAD3\Semester 2\PROG 3B\POE\Task 2\GregPostingsST10114245_PROG3B_POE\GregPostingsST10114245_PROG3B_POE\TextFile\RedBlack.txt";


        //FILE PATH

        //public string filePath = @"D:\BCAD3\Semester 2\PROG 3B\POE\RedBlack.txt";
        //public string filePath = @"D:\BCAD3\Semester 2\PROG 3B\POE\Task 2\GregPostingsST10114245_PROG3B_POE\GregPostingsST10114245_PROG3B_POE\bin\Debug\RedBlack.txt";

        //TRYING TO MAKE A RELATIVE PATH

        //public string path = Path.Combine(Directory.GetCurrentDirectory(), "GregPostingsST10114245_PROG3B_POE\\GregPostingsST10114245_PROG3B_POE\\TextFile\\RedBlack.txt");

        //static Assembly assembly = Assembly.GetExecutingAssembly();
        //public StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("GregPostingsST10114245_PROG3B_POE.TextFile.RedBlack.txt"));


        /// <summary>
        /// Creating an object of the Random class
        /// </summary>
        public Random random = new Random();

        /// <summary>
        /// This is used to save the random number
        /// </summary>
        public int randomTopicNumbers;

        /// <summary>
        /// This is a random number used for the top level
        /// </summary>
        public int SelectedGeneralTopic;

        /// <summary>
        /// This is a random number used for the second level
        /// </summary>
        public int SelectedSecondLevelTopic;

        /// <summary>
        /// This is a random number used for the third level
        /// </summary>
        public int SpecificTopic;

        /// <summary>
        /// This will keep track of the users score
        /// </summary>
        public int score;

        /// <summary>
        /// This will keep track of which question the user is on
        /// </summary>
        public int currentQuestion = 1;

        /// <summary>
        /// This is used to store the randomly selected description that is used for the question
        /// </summary>
        public string RandomlySelectedThirdLevelDesc;

        /// <summary>
        /// This is used to store the randomly selected number that is used for the answer to the question
        /// </summary>
        public string RandomlySelectedThirdLevelNum;

        #endregion


        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random numbers for the topics
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int RandomNum(List<DeweyNumbers> list)
        {
            //this just resets the letters back to null
            randomTopicNumbers = 0;

            //Gets the number of items in the list and selects a random number
            randomTopicNumbers = random.Next(list.Count);

            //Returning the numbers
            return randomTopicNumbers;
        }
    }
}
