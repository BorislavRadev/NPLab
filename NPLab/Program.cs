﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NPLab.Models;

namespace NPLab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       // public Objects currObj = new Objects();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
