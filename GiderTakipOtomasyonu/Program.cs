﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiderTakipOtomasyonu
{
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
            Application.Run(new SifreSıfırlama());
            /*
             * Application.Run(new Forms.InfrastructureForm());
             * Application.Run(new Form1());
             * Application.Run(new KayitOl());
            */
        }
    }
}
