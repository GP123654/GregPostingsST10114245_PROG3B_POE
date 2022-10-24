/*
 * Done By: Greg Postings ST10114245 
 * Module: PROG 3B
 * Class: BCA3 G7
 * Task: POE Task 2
 * Start Date and Time: 19 October 2022 at 9:30
 * Finish Date and Time: 25 October 2022 at 12:20
 * 
 */

//Imports
using System;
using System.Collections.Generic;
using System.Linq;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Game2Classes
{
    //Class
    class Dictionary
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
        /// Creating an object of the Random class
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Creating a dictionary to store questions and answers
        /// </summary>
        public Dictionary<string, string> bookQna = new Dictionary<string, string>();

        /// <summary>
        /// Creating a dictionary to store questions and answers in the reverse order
        /// </summary>
        public Dictionary<string, string> bookQna2 = new Dictionary<string, string>();

        /// <summary>
        /// This stores a random key value from the dictionary
        /// </summary>
        private string bookCategory;

        #endregion


        ////////////////////////////////////////////////////////
        // These methods are used populating the dictionaries
        // with values. They are stored as key value pairs.
        ////////////////////////////////////////////////////////

        //Populating Dictionary Methods

        #region Populating Dictionaries

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        public void Pop()
        {
            bookQna.Add("000", "General Knowledge");
            bookQna.Add("100", "Psycology and Philosophy");
            bookQna.Add("200", "Religions and Mythology");
            bookQna.Add("300", "Social Sciences and Folklore");
            bookQna.Add("400", "Languages and Grammar");
            bookQna.Add("500", "Math and Science");
            bookQna.Add("600", "Medicine and Technology");
            bookQna.Add("700", "Arts and Recreation");
            bookQna.Add("800", "Literature");
            bookQna.Add("900", "Geography and History");
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        public void Pop2()
        {
            bookQna2.Add("General Knowledge", "000");
            bookQna2.Add("Psycology and Philosophy", "100");     
            bookQna2.Add("Religions and Mythology", "200");     
            bookQna2.Add("Social Sciences and Folklore", "300");    
            bookQna2.Add("Languages and Grammar", "400");          
            bookQna2.Add("Math and Science", "500");   
            bookQna2.Add("Medicine and Technology", "600");           
            bookQna2.Add("Arts and Recreation", "700");
            bookQna2.Add("Literature", "800");         
            bookQna2.Add("Geography and History", "900");
        }

        #endregion



        ////////////////////////////////////////////////////////
        // These methods generate the random key values
        ////////////////////////////////////////////////////////

        //Random Key Generator Methods

        #region Random Key Generator


        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creating a random generator for getting a random key from the dictionaries
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <returns></returns>
        public IEnumerable<TKey> RandomKeys<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            //Making a list of keys from the dictionary
            List<TKey> keys = Enumerable.ToList(dict.Keys);
            //Getting the size of the dictionary
            int size = dict.Count;
            while (true)
            {
                //Returning a random value from the list which will be a key from the dictionary
                yield return keys[random.Next(size)];
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Getting a random key from the first dictionary
        /// </summary>
        /// <returns></returns>
        public string GetRandomKey()
        {
            foreach (var key in RandomKeys(bookQna).Take(8))
            {
                //Assigning a random key value to the variable
                bookCategory = key;
            }
            //Returns the random key
            return bookCategory;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Getting a random key from the second dictionary
        /// </summary>
        /// <returns></returns>
        public string GetRandomKey2()
        {
            foreach (var key in RandomKeys(bookQna2).Take(6))
            {
                //Assigning a random key value to the variable
                bookCategory = key;
            }
            //Returns the random key
            return bookCategory;
        }

        #endregion


    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//


//                  
//                                   ___________________________________
//                                  /    ___________________________    \
//                                 /    /    ___________________    \    \
//                                /    /    /   _____________   \    \    \
//                               /    /    /   /  _________  \   \    \    \
//                              /    /    /   /  /         \  \   \    \    \
//                             /    /    /   /  /  _______  \  \   \    \    \
//                            /    /    /   /  /  /       \  \  \   \    \    \
//                           /    /    /   /  /  /   ___   \  \  \   \    \    \
//                          /    /    /   /  /  /   /   \   \  \  \   \    \    \
//                         /    /    /   /  /  /   / ___ \   \  \  \   \    \    \
//                         |    |    |   |  |  |  / /   \ \   |  |  |   |    |    |
//                         |    |    |   |  |  |  | |   |  |  |  |  |   |    |    |
//                         |    |    |   |  |  |  | |   |  |  |  |  |   |    |    |
//                         |    |    |   |  |  |  | |   |  |  |  |  |   |    |    |
//                         |    |    |   |  |  |  | |   |  |  |  |  |   |    |    |
//                         |    |    |   |  |  |  | |   |  |  |  |  |   |    |    |
//          //////////////////////////////////////////////////////////////////////////////////////////////
//
//          I establish my covenant with you: Never again will all life be cut off by the waters of a flood;
//          never again will there be a flood to destroy the earth.” And God said, “This is the sign of the
//          covenant I am making between me and you and every living creature with you, a covenant for all
//          generations to come: I have set my rainbow in the clouds, and it will be the sign of the covenant
//          between me and the earth. Whenever I bring clouds over the earth and the rainbow appears in the
//          clouds, I will remember my covenant between me and you and all living creatures of every kind.
//          Never again will the waters become a flood to destroy all life. Whenever the rainbow appears in
//          the clouds, I will see it and remember the everlasting covenant between God and all living
//          creatures of every kind on the earth.”
//
//                      So God said to Noah, “This is the sign of the covenant I have established
//                              between me and all life on the earth.”   - Genesis 9:11-17         
      
//          //////////////////////////////////////////////////////////////////////////////////////////////
//          
//          

