

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
        /// 
        /// </summary>
        public Dictionary<string, string> bookQna = new Dictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> bookQna2 = new Dictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        private string bookCategory;

        /// <summary>
        /// 
        /// </summary>
        //private string bookDescription;

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
        // These methods are used for generating the random
        // topic numbers and authors letters. It then puts them
        // together to make a random dewey decimal call number.
        ////////////////////////////////////////////////////////

        //Random Number Generator Methods

        #region Random Number Generator


        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict"></param>
        /// <returns></returns>
        public IEnumerable<TKey> RandomKeys<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            List<TKey> keys = Enumerable.ToList(dict.Keys);
            int size = dict.Count;
            while (true)
            {
                yield return keys[random.Next(size)];
            }
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetRandomKey()
        {
            foreach (var key in RandomKeys(bookQna).Take(8))//Was 7
            {
                bookCategory = key;
            }
            return bookCategory;
        }

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetRandomKey2()
        {
            foreach (var key in RandomKeys(bookQna2).Take(4))//Was 3
            {
                bookCategory = key;
            }
            return bookCategory;
        }


        #endregion









        //Random Values - Not used

        #region WORKS BUT NOT USED

        /*
        public IEnumerable<TValue> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            //Random rand = new Random();
            List<TValue> values = Enumerable.ToList(dict.Values);
            int size = dict.Count;
            while (true)
            {
                yield return values[random.Next(size)];
            }
        }

        
        public string GetRandomValue()
        {
            foreach (var value in RandomValues(bookQna).Take(1))
            {
                bookDescription = value;                
            }
            return bookDescription;
        }*/

        #endregion




        //TESTS

        #region Tests

        //Trying to get random one

        /*

        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random dewey decimal call number
        /// </summary>
        /// <returns></returns>
        //public string RandomDeweyCallNumber()
        //{
            //Three random letters for author
            //string author = RandomAuthor(4);
            //String to store the dewey decimal call number
            //string deweyDecimal;

            //Storing the different numbers and letter joined with dots for the dewey decimal call number
            //deweyDecimal = author;

            //Returning the dewey decimal number
            //return author;
        //}


        public void RandomDeweyCallNumber2()
        {
            //Three random letters for author
            //string author = RandomAuthor(4);

            //MessageBox.Show(author);
        }


        //----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates the random letters for the author
        /// </summary>
        /// <param name="numOfLetters"></param>
        /// <returns></returns>
        public void RandomAuthor()//int numOfbooks)
        {
            Pop();

            string book = "";

            try
            {
                //For loop to create the number of letters specified
                //for (int i = 0; i < numOfbooks; i++)
                //{
                    foreach (var entry in bookQna)
                    {
                    //book = this.random.Next(bookQna.Values.).ToString();
                    book = entry.Value;//this.random.Next(entry.Key).ToString();
                    ;
                        MessageBox.Show(book);
                    }
                
                    
                //}
            }
            catch (Exception ex)
            {
                //Error message
                MessageBox.Show("Please select a valid item");
            }
            //Returning the letters in uppercase format
            //return book;
        }
        




        //Random Keys and Values

        /*

        public IEnumerable<TValue> RandomValuesAndKeys<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            //Random rand = new Random();
            List<TValue> values = Enumerable.ToList(dict.Values);
            List<TKey> keys = Enumerable.ToList(dict.Keys);
            int size = dict.Count;
            while (true)
            {
                yield return values[random.Next(size)];
            }
        }

        */



        /*
        public IEnumerable<KeyValuePair> RandomValuesAndKeys<TKey, KeyValuePair>(IDictionary<TKey, KeyValuePair> dict)
        {
            //Random rand = new Random();
            List<KeyValuePair> values = Enumerable.ToList(dict.Values);
            List<TKey> keys = Enumerable.ToList(dict.Keys);
            int size = dict.Count;
            while (true)
            {
                yield return values[random.Next(size)];
            }
        }
        */




        //Checking to see if printing values work

        /*
        public void Check()
        {
            Pop();
            foreach (var entry in bookQna)
            {
                MessageBox.Show(entry.Key + entry.Value);
            }
        }
        */


        //Displaying the values with checks

        /*
        public string GetRandomValue()
        {
            //bookQna.Clear();
            //Pop();
            foreach (var value in RandomValues(bookQna).Take(1))
            {
                
                if (!bookQna.ContainsValue(value))
                {
                    bookCategory = value;
                }

                //MessageBox.Show(value);
                bookDescription = value;

            }
            return bookDescription;
        }


        public string GetRandomKey()
        {
            //bookQna.Clear();
            //Pop();
            foreach (var key in RandomKeys(bookQna).Take(1))
            {
                
                if (!bookQna.ContainsValue(value))
                {
                    bookCategory = value;
                }
                
                //MessageBox.Show(value);
                bookCategory = key;

            }
            return bookCategory;
        }

        */


        #endregion


    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//