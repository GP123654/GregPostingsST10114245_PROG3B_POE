﻿
//Imports
using GregPostingsST10114245_PROG3B_POE.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Package
namespace GregPostingsST10114245_PROG3B_POE
{
    //Class
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
//---------------------------------------ooo000 END OF FILE 000ooo--------------------------------------//