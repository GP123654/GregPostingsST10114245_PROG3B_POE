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
using System;
using System.Collections.Generic;
using System.Linq;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Classes
{
    //Class
    class DeweyDecimalNumberGenerator
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

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating an object of the Random class
        /// </summary>
        private Random random = new Random();

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a char array for the letters that are available for the random author letters
        /// </summary>
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToArray();

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a char array for the numbers that are available for the random topic numbers
        /// </summary>
        private char[] numbers = "1234567890".ToArray();

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// A string to store the randomly generated letters
        /// </summary>
        private string randomLetters;

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// A string to store the randomly generated topic numbers
        /// </summary>
        private string random3DigetNumbers;

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a List<string> to store the the randomly generated dewey decimal numbers
        /// </summary>
        public List<string> deweyNums = new List<string>();

        #endregion


        ////////////////////////////////////////////////////////
        // These methods are used for generating the random
        // topic numbers and authors letters. It then puts them
        // together to make a random dewey decimal call number.
        ////////////////////////////////////////////////////////

        //Random Number Generator Methods

        #region Random Number Generator

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random dewey decimal call number
        /// </summary>
        /// <returns></returns>
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

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random letters for the author
        /// </summary>
        /// <param name="numOfLetters"></param>
        private string RandomAuthor(int numOfLetters)
        {
            this.randomLetters = null;
            for (int i = 0; i < numOfLetters; i++)
            {
                this.randomLetters += this.letters[this.random.Next(0, this.letters.Length)];
            }
            return this.randomLetters.ToUpper();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random numbers for the topics
        /// </summary>
        /// <param name="numOfNumbers"></param>
        /// <returns></returns>
        private string Random3DigetNum(int numOfNumbers)
        {
            this.random3DigetNumbers = null;
            for (int i = 0; i < numOfNumbers; i++)
            {
                this.random3DigetNumbers += this.numbers[this.random.Next(0, this.numbers.Length)];
            }
            return this.random3DigetNumbers;
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These are just some tests
        ////////////////////////////////////////////////////////

        //TESTS

        #region Tests

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


        //private int RandomNum(int numOfNumbers)
        //{
        //    randomNumbers = 0;
        //    for (int i = 0; i < numOfNumbers; i++)
        //    {
        //        randomNumbers = random.Next(000, 999);
        //    }
        //    return randomNumbers;
        //}

        #endregion
    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//