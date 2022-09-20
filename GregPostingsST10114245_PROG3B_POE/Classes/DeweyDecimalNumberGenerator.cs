using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregPostingsST10114245_PROG3B_POE.Classes
{
    class DeweyDecimalNumberGenerator
    {
        private Random random = new Random();
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToArray();
        private char[] numbers = "1234567890".ToArray();
        private string randomLetters;
        private string random3DigetNumbers;
        private int randomNumbers;

        private string de;


        public List<string> deweyNums = new List<string>();
        //public List<string> DeweyNums { get; set; }
        //Game1 g1 = new Game1();
        
        
        //public void StoreDeweyNums()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        DeweyNums.Add(RandomDNumber());
        //    }
        //}






        //public void DisplayList(Label a, List<string> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        a.Text = list[i];
        //    }
        //}


        public string RandomDNumber()
        {
            //int one = RandomNum(3); //Could just make it random.Next(0, 999)
            //int two = RandomNum(3); //OR (00, 999) OR (000, 999)

            string one = Random3DigetNum(3);
            string two = Random3DigetNum(3);
            string author = RandomAuthor(3);
            string deweyDecimal;

            deweyDecimal = one + "." + two + "." + author;

            return deweyDecimal;
        }




        private string RandomAuthor(int numOfLetters)
        {
            randomLetters = null;
            for (int i = 0; i < numOfLetters; i++)
            {
                randomLetters += letters[random.Next(0, letters.Length)];
            }
            return randomLetters.ToUpper();
        }

        private string Random3DigetNum(int numOfNumbers)
        {
            random3DigetNumbers = null;
            for (int i = 0; i < numOfNumbers; i++)
            {
                random3DigetNumbers += numbers[random.Next(0, numbers.Length)];
            }
            return random3DigetNumbers;
        }

        //private int RandomNum(int numOfNumbers)
        //{
        //    randomNumbers = 0;
        //    for (int i = 0; i < numOfNumbers; i++)
        //    {
        //        randomNumbers = random.Next(000, 999);
        //    }
        //    return randomNumbers;
        //}
    }
}
