using GregPostingsST10114245_PROG3B_POE.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregPostingsST10114245_PROG3B_POE.Game3Classes
{
    class Game3Functionality
    {


        public List<string> deweyDeci = new List<string>();
        public List<DeweyNumbers> topLevelSpecific = new List<DeweyNumbers>();
        public List<DeweyNumbers> secondLevelSpecific = new List<DeweyNumbers>();
        public List<DeweyNumbers> thirdLevelSpecific = new List<DeweyNumbers>();
        public List<DeweyNumbers> thirdLevel = new List<DeweyNumbers>();

        public List<DeweyNumbers> deweyNumbers = new List<DeweyNumbers>();

        public List<DeweyNumbers> fourRandomTopLevelSpecific = new List<DeweyNumbers>();
        public List<DeweyNumbers> fourRandomSecondLevelSpecific = new List<DeweyNumbers>();
        public List<DeweyNumbers> fourRandomThirdLevelSpecific = new List<DeweyNumbers>();


        public string filePath = @"D:\BCAD3\Semester 2\PROG 3B\POE\RedBlack.txt";

        public Random random = new Random();
        public int randomTopicNumbers;

        public int SelectedGeneralTopic;
        public int SelectedSecondLevelTopic;
        public int SpecificTopic;

        public int score;
        public int currentQuestion = 1;


        public string RandomlySelectedThirdLevelDesc;
        public string RandomlySelectedThirdLevelNum;

        public int RandomNum(List<DeweyNumbers> list)
        {
            //this just resets the letters back to null
            randomTopicNumbers = 0;

            randomTopicNumbers = random.Next(list.Count);

            //Returning the numbers
            return randomTopicNumbers;
        }
    }
}
