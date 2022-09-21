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
using GregPostingsST10114245_PROG3B_POE.UserControls;
using System;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE.Classes
{
    //Class
    class GameTimer
    {
        /// <summary>
        /// 
        /// </summary>       
        public static int H { get; set; }

        /// <summary>
        /// 
        /// </summary>       
        public static int M { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static int S { get; set; }

        //public int H { get; set; }
        //public int M { get; set; }
        //public int S { get; set; }

        /// <summary>
        /// To decide which game mode it is
        /// </summary>
        public bool GameModeHS { get; set; }

        /// <summary>
        /// Or this
        /// </summary>
        private enum GameMode
        {
            HighScore,
            TimeTrail
        }

        /// <summary>
        /// Used for timer
        /// </summary>
        public void TimerIncrease()
        {
            Game1GameBar game1GameBar = new Game1GameBar();

            S++;
            game1GameBar.timerLbl.Text = String.Format("{0}:{1}:{2}", H.ToString().PadLeft(2, '0'), M.ToString().PadLeft(2, '0'), S.ToString().PadLeft(2, '0'));


            if (S == 60)
            {
                S = 0;
                M += 1;
            }
            if (M == 60)
            {
                M = 0;
                H += 1;
            }
        }


        /// <summary>
        /// Used for timer
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <param name="h"></param>
        public void TimerIncrease2(Label d, int s, int m, int h)
        {
            s++;
            d.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));


            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }
        }

        /// <summary>
        /// Used for countdown timer
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <param name="h"></param>
        public void TimerDecrease(Label d, int s, int m, int h)
        {
            //s--;



            //S = s;
            //M = m;
            //H = h;

            if (s == 0)
            {
                s = 60;                
                m -= 1;              
            }
            if (m == 0)
            {
                m = 60;
                h -= 1;                
            }

            d.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//