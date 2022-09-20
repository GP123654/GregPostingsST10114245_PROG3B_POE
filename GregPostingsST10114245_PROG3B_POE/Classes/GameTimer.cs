using GregPostingsST10114245_PROG3B_POE.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregPostingsST10114245_PROG3B_POE.Classes
{
    class GameTimer
    {
        public static int H { get; set; }
        public static int M { get; set; }
        public static int S { get; set; }

        //public int H { get; set; }
        //public int M { get; set; }
        //public int S { get; set; }

        public bool GameModeHS { get; set; }


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
