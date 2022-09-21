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
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.WorkingGameClasses
{
    //Class
    class WGDeweyDecimalNumberGenerator
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
        private string randomTopicNumbers;

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a List<string> to store the the randomly generated dewey decimal numbers
        /// </summary>
        public  List<string> deweyNums = new List<string>();

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
        public string RandomDeweyCallNumber()
        {
            //Three diget random number for first general topic
            string one = RandomTopicNum(3);
            //Three diget random number for second specialized topic
            string two = RandomTopicNum(3);
            //Three random letters for author
            string author = RandomAuthor(3);
            //String to store the dewey decimal call number
            string deweyDecimal;

            //Storing the different numbers and letter joined with dots for the dewey decimal call number
            deweyDecimal = one + "." + two + "." + author;

            //Returning the dewey decimal number
            return deweyDecimal;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random letters for the author
        /// </summary>
        /// <param name="numOfLetters"></param>
        /// <returns></returns>
        private string RandomAuthor(int numOfLetters)
        {
            //this just resets the letters back to null
            randomLetters = null;

            //For loop to create the number of letters specified
            for (int i = 0; i < numOfLetters; i++)
            {
                randomLetters += letters[random.Next(0, letters.Length)];
            }

            //Returning the letters in uppercase format
            return randomLetters.ToUpper();
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random numbers for the topics
        /// </summary>
        /// <param name="numOfNumbers"></param>
        /// <returns></returns>
        private string RandomTopicNum(int numOfNumbers)
        {
            //this just resets the letters back to null
            randomTopicNumbers = null;

            //For loop to create the amount of numbers specified
            for (int i = 0; i < numOfNumbers; i++)
            {
                randomTopicNumbers += numbers[random.Next(0, numbers.Length)];
            }

            //Returning the numbers
            return randomTopicNumbers;
        }

        #endregion


        ////////////////////////////////////////////////////////
        // These methods add the random dewey decimal numbers
        // to a List. Then those numbers get displayed into
        // a listBox.
        ////////////////////////////////////////////////////////

        //Generate And Display Random Call Number Methods

        #region Generating And Displying Random Numbers

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will add a specified List<string> to the BookCartUnsortedListBox
        /// </summary>
        /// <param name="list"></param>
        public void DisplayList(List<string> list, ListBox listbox)
        {
            //For loop that loops for the length/count of the specified List<string>
            for (int i = 0; i < list.Count; i++)
            {
                //Adds the specified List<string> values to the BookCartUnsortedListBox listbox
                listbox.Items.Add(list[i]);
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This will create 10 random dewey decimal call numbers and add
        /// them to a List<string> and then display them in the BookCartUnsortedListBox listbox
        /// </summary>
        public void GenerateAndDisplyRandomNumbers(ListBox listbox)
        {
            //For loop that adds 10 random dewey decimal numbers to the deweyNums List
            for (int i = 0; i < 10; i++)
            {
                //Adding random call numbers to the deweyNums List
                deweyNums.Add(RandomDeweyCallNumber());
            }

            /** Calling the DisplayList Method */
            DisplayList(deweyNums, listbox);
        }

        #endregion

    }
}
